using Dono.Midi.Runtime;
using UnityEngine.InputSystem;

namespace Minis.Runtime.Devices
{
    public partial class MidiButtonDevice : InputDevice, IMidiInputSystemDevice
    {
        bool _changeFrag = false;
        static MidiButtonDeviceState _state;

        public void Process0x8n(byte stats, byte note, byte velocity)
        {
            _state.SetNoteOff(note);
            _changeFrag = true;
        }
        public unsafe void Process0x9n(byte stats, byte note, byte velocity)
        {
            _state.SetNoteOn(note);
            _changeFrag = true;
        }
        public void Process0xAn(byte stats, byte data1, byte data2) { }
        public void Process0xBn(byte stats, byte number, byte value) { }
        public void Process0xCn(byte stats, byte value) { }
        public void Process0xDn(byte stats, byte data1) { }

        private bool IsLastPitchUp = false;
        private bool IsLastPitchDown = false;
        public void Process0xEn(byte stats, byte value1, byte value2)
        {
            //var channel = (byte)(stats & 0x0F);
            var value = MidiUtilities.PitchByteToValue((value1, value2));

            if (value < 0)
            {
                //Down
                ProcessPitchDown(stats, value1, value2);
                IsLastPitchDown = true;
                IsLastPitchUp = false;
            }
            else if (value > 0)
            {
                //Up
                ProcessPitchUp(stats, value1, value2);
                IsLastPitchDown = false;
                IsLastPitchUp = true;
            }
            else
            {
                //Center
                if (IsLastPitchDown)
                    ProcessPitchDown(stats, value1, value2);
                else if (IsLastPitchUp)
                    ProcessPitchUp(stats, value1, value2);
            }
            _changeFrag = true;
        }
        public void ProcessOxFn(byte stats) { }
        public void ProcessOxFn(byte stats, byte data1) { }
        public void ProcessOxFn(byte stats, byte data1, byte data2) { }

        private void ProcessPitchUp(byte stats, byte value1, byte value2)
        {
            var value = MidiUtilities.PitchByteToValue((value1, value2));
            _state.SetPitch(true, value > 0);
        }
        private void ProcessPitchDown(byte stats, byte value1, byte value2)
        {
            var value = MidiUtilities.PitchByteToValue((value1, value2));
            _state.SetPitch(false, value < 0);
        }

        public void QueueEvent()
        {
            if (_changeFrag)
                InputSystem.QueueDeltaStateEvent(this, _state);

            _changeFrag = false;
        }
    }
}