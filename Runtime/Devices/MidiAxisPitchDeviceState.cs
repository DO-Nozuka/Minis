using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace Minis.Runtime.Devices
{
    [StructLayout(LayoutKind.Auto)]//, Size = 20)]   //Size : in Byte Note:16, Pitch:4, AnyNote:4 
    public unsafe struct MidiAxisPitchDeviceState : IInputStateTypeInfo
    {
        public FourCC format => new FourCC('M', 'I', 'A', 'P'); //MIdi Axis Pitch

        [InputControl(name = "AxisPitch", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        public float __axisPitch;
        [InputControl(name = "AxisPitchUp", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        public float __axisPitchUp;
        [InputControl(name = "AxisPitchDown", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        public float __axisPitchDown;


        public float GetPitch(byte note) { return __axisPitch; }
        public void SetPitch(float value)
        {
            __axisPitch = value;
            if (value >= 0.0f)
            {
                __axisPitchUp = value;
                __axisPitchDown = 0.0f;
            }
            else if(value < 0.0f)
            {
                __axisPitchUp = 0.0f;
                __axisPitchDown = -value;
            }
        }
    }
}