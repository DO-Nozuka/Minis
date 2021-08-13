using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace Minis.Runtime.MidiVector3Device
{
    //
    // MIDI state struct with 128 notes and 128 controls
    //
    [StructLayout(LayoutKind.Auto)]
    public unsafe struct MidiVector3DeviceState : IInputStateTypeInfo
    {
        public FourCC format => new FourCC('M', 'I', 'D', 'V');

        //0x8n
        [InputControl(name = "Vec3NoteOff", layout = "Vector3")]
        public Vector3 __vec3NoteOff;
        //0x9n
        [InputControl(name = "Vec3NoteOn", layout = "Vector3")]
        public Vector3 __vec3NoteOn;
        //0xAn
        [InputControl(name = "Vec3PP", layout = "Vector3")]
        public Vector3 __vec3PP;
        //0xBn
        [InputControl(name = "Vec3CC", layout = "Vector3")]
        public Vector3 __vec3CC;
        //0xCn
        [InputControl(name = "Vec3PC", layout = "Vector3")]
        public Vector3 __vec3PC;
        //0xDn
        [InputControl(name = "Vec3CP", layout = "Vector3")]
        public Vector3 __vec3CP;
        //0xEn
        [InputControl(name = "Vec3Pitch", layout = "Vector3")]
        public Vector3 __vec3Pitch;
        //0xFn
        [InputControl(name = "Vec3SysMsg", layout = "Vector3")]
        public Vector3 __vec3SysMsg;

        //0x8n, 0x9n
        [InputControl(name = "Vec3AnyNote", layout = "Vector3")]
        public Vector3 __vec3AnyNote;
        //0xnn
        [InputControl(name = "Vec3AnyMsg", layout = "Vector3")]
        public Vector3 __vec3AnyMessage;

        public void SetNoteOn(byte stats, byte data1, byte data2) 
        {
            __vec3NoteOn.Set(stats, data1, data2);
            SetAnyNote(stats, data1, data2);
            SetAnyMsg(stats, data1, data2);
        }
        public void SetNoteOff(byte stats, byte data1, byte data2)
        {
            __vec3NoteOff.Set(stats, data1, data2);
            SetAnyNote(stats, data1, data2);
            SetAnyMsg(stats, data1, data2);
        }
        public void SetPP(byte stats, byte data1, byte data2) 
        {
            __vec3PP.Set(stats, data1, data2);
            SetAnyMsg(stats, data1, data2);
        }
        public void SetCC(byte stats, byte data1, byte data2) 
        {
            __vec3CC.Set(stats, data1, data2);
            SetAnyMsg(stats, data1, data2);
        }
        public void SetPC(byte stats, byte data1, byte data2) 
        {
            __vec3PC.Set(stats, data1, data2);
            SetAnyMsg(stats, data1, data2);
        }
        public void SetCP(byte stats, byte data1, byte data2)
        {
            __vec3CP.Set(stats, data1, data2);
            SetAnyMsg(stats, data1, data2);
        }
        public void SetPitch(byte stats, byte data1, byte data2) 
        {
            __vec3Pitch.Set(stats, data1, data2);
            SetAnyMsg(stats, data1, data2);
        }
        public void SetSysMsg(byte stats, byte data1, byte data2) 
        {
            __vec3SysMsg.Set(stats, data1, data2);
            SetAnyMsg(stats, data1, data2);
        }

        private void SetAnyNote(byte stats, byte data1, byte data2) { __vec3AnyNote.Set(stats, data1, data2); }
        private void SetAnyMsg(byte stats, byte data1, byte data2) { __vec3AnyMessage.Set(stats, data1, data2); }
    }
}
