using Dono.MidiUtilities.Runtime;
using UnityEngine.InputSystem;

namespace Minis.Runtime.Devices
{
    public partial class MidiAxisPitchDevice : InputDevice, IMidiInputSystemDevice
    {
        static MidiAxisPitchDeviceState _state;

        public void ProcessNoteOn(byte stats, byte note, byte velocity) {}

        public void ProcessNoteOff(byte stats, byte note, byte velocity) { }

        public void ProcessControlChange(byte stats, byte number, byte value) {}

        public void ProcessPitchBend(byte stats, byte value1, byte value2)
        {
            var value = MidiMessage.GetPitchBendValue(value1, value2);
            _state.SetPitch(value);

            InputSystem.QueueDeltaStateEvent(this, _state);
        }

        public void ProcessProgramChange(byte stats, byte value) { }
    }
}