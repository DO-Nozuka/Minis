using Dono.Midi;
using UnityEngine.InputSystem;

namespace Minis.Runtime.Devices
{
    public partial class MidiAxisPitchDevice : InputDevice, IMidiInputSystemDevice
    {
        static MidiAxisPitchDeviceState _state;

        public void Process0x8n(byte stats, byte note, byte velocity) { }
        public void Process0x9n(byte stats, byte note, byte velocity) { }
        public void Process0xAn(byte stats, byte data1, byte data2) { }
        public void Process0xBn(byte stats, byte number, byte value) { }
        public void Process0xCn(byte stats, byte value) { }
        public void Process0xDn(byte stats, byte data1) { }
        public void Process0xEn(byte stats, byte value1, byte value2)
        {
            var value = MidiUtilities.PitchByteToValue((value1, value2));
            _state.SetPitch(value);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }
        public void ProcessOxFn(byte stats) { }
        public void ProcessOxFn(byte stats, byte data1) { }
        public void ProcessOxFn(byte stats, byte data1, byte data2) { }
    }
}