using System;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiInputSystemDevice
{
    public abstract partial class MidiInputSystemDevice : InputDevice, IMidiInputSystemDevice
    {
        public abstract void ProcessControlChange(byte stats, byte number, byte value);
        public abstract void ProcessNoteOff(byte stats, byte note, byte velocity);
        public abstract void ProcessNoteOn(byte stats, byte note, byte velocity);
        public abstract void ProcessPitchBend(byte stats, byte value1, byte value2);
        public abstract void ProcessProgramChange(byte stats, byte value);
    }
}