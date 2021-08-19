using UnityEngine.InputSystem;

namespace Minis.Runtime.Devices
{
    public partial class MidiAxis2ByteCCDevice : InputDevice, IMidiInputSystemDevice
    {
        static MidiAxis2ByteCCDeviceState _state;
        private byte[] cc = new byte[128];

        public void ProcessNoteOn(byte stats, byte note, byte velocity)
        {
            //// Send to additional controls
            //ProcessAnyNoteOn(stats, note, velocity);
            //if (MidiMessage.IsWhiteNote(note))
            //    ProcessAnyWhiteNoteOn(stats, note, velocity);
            //else
            //    ProcessAnyBlackNoteOn(stats, note, velocity);

            //InputSystem.QueueDeltaStateEvent(this, _state);
        }


        public void ProcessNoteOff(byte stats, byte note, byte velocity)
        {
            //// Send to additional controls
            //ProcessAnyNoteOff(stats, note, velocity);
            //if (MidiMessage.IsWhiteNote(note))
            //    ProcessAnyWhiteNoteOff(stats, note, velocity);
            //else
            //    ProcessAnyBlackNoteOff(stats, note, velocity);

            //InputSystem.QueueDeltaStateEvent(this, _state);
        }

        public unsafe void ProcessControlChange(byte stats, byte number, byte value)
        {
            if (number >= 64)
                return;

            cc[number] = value;
            byte twoCCNum = (byte)(number % 32);
            byte msbCCNum = (byte)(number % 32);
            var lsbCCNum = number % 32 + 32;
            var axisValue = (((int)cc[msbCCNum] << 7) + cc[lsbCCNum]) / (float)0b0011_1111_1111_1111;

            _state.SetCC(twoCCNum, axisValue);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }

        //private bool IsLastPitchUp = false;
        //private bool IsLastPitchDown = false;
        public void ProcessPitchBend(byte stats, byte value1, byte value2)
        {
            //var value = MidiMessage.GetPitchBendValue(value1, value2);

            //if (value < 0)
            //{
            //    //Down
            //    ProcessPitchDown(stats, value1, value2);
            //    IsLastPitchDown = true;
            //    IsLastPitchUp = false;
            //}
            //else if (value > 0)
            //{
            //    //Up
            //    ProcessPitchUp(stats, value1, value2);
            //    IsLastPitchDown = false;
            //    IsLastPitchUp = true;
            //}
            //else
            //{
            //    //Center
            //    if (IsLastPitchDown)
            //        ProcessPitchDown(stats, value1, value2);
            //    else if (IsLastPitchUp)
            //        ProcessPitchUp(stats, value1, value2);
            //}


            //InputSystem.QueueDeltaStateEvent(this, _state);
        }

        public void ProcessProgramChange(byte stats, byte value)
        {
            //InputSystem.QueueDeltaStateEvent(this, _state);
        }

        //---- Sub Process(not use QueueEvent) ----
        private void ProcessAnyNoteOn(byte stats, byte note, byte velocity)
        {
        }
        private void ProcessAnyNoteOff(byte stats, byte note, byte velocity)
        {
        }

        private void ProcessAnyWhiteNoteOn(byte stats, byte note, byte velocity)
        {
        }
        private void ProcessAnyWhiteNoteOff(byte stats, byte note, byte velocity)
        {
        }

        private void ProcessAnyBlackNoteOn(byte stats, byte note, byte velocity)
        {
        }
        private void ProcessAnyBlackNoteOff(byte stats, byte note, byte velocity)
        {
        }

        private void ProcessPitchUp(byte stats, byte value1, byte value2)
        {
        }

        private void ProcessPitchDown(byte stats, byte value1, byte value2)
        {
        }

        private void ProcessModulation(short modulationValue)
        {
        }
    }
}