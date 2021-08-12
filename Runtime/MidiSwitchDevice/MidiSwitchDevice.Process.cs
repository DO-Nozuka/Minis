using Dono.MidiUtilities.Runtime;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

namespace Minis.Runtime.MidiSwitchDevice
{
    public partial class MidiSwitchDevice : InputDevice //TODO: It is better to share the same interface with MidiVector3Device.
    {
        static MidiSwitchDeviceState _switchState;

        #region MIDI event receiver (invoked from MidiPort)
        //---- Main Process(use QueueEvent) ----
        public unsafe void ProcessNoteOn(byte stats, byte note, byte velocity)
        {
            _switchState.SetNoteOn(note);

            // Send to additional controls
            ProcessAnyNoteOn(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOn(stats, note, velocity);
            else
                ProcessAnyBlackNoteOn(stats, note, velocity);

            InputSystem.QueueDeltaStateEvent(this, _switchState);
        }


        public void ProcessNoteOff(byte stats, byte note, byte velocity)
        {
            _switchState.SetNoteOff(note);

            // Send to additional controls
            ProcessAnyNoteOff(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOff(stats, note, velocity);
            else
                ProcessAnyBlackNoteOff(stats, note, velocity);

            InputSystem.QueueDeltaStateEvent(this, _switchState);
        }

        public void ProcessControlChange(byte stats, byte number, byte value)
        {
            //switch (number)
            //{
            //    case 0x01:  //Modulation MSB
            //        modulationMSB = value;
            //        ProcessModulation(modulation);
            //        break;
            //    case 0x21:  //Modulation LSB
            //        modulationLSB = value;
            //        ProcessModulation(modulation);
            //        break;
            //    default:
            //        break;
            //}
            InputSystem.QueueDeltaStateEvent(this, _switchState);
        }

        private bool IsLastPitchUp = false;
        private bool IsLastPitchDown = false;
        public void ProcessPitchBend(byte stats, byte value1, byte value2)
        {
            //var channel = (byte)(stats & 0x0F);
            var value = MidiMessage.GetPitchBendValue(value1, value2);

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


            InputSystem.QueueDeltaStateEvent(this, _switchState);
        }

        public void ProcessProgramChange(byte stats, byte value)
        {

            InputSystem.QueueDeltaStateEvent(this, _switchState);
        }

        //---- Sub Process(not use QueueEvent) ----
        private void ProcessAnyNoteOn(byte stats, byte note, byte velocity)
        {
            //_anyKeyNote.QueueValueChange(1.0f);
        }
        private void ProcessAnyNoteOff(byte stats, byte note, byte velocity)
        {
            //_anyKeyNote.QueueValueChange(0.0f);
        }

        private void ProcessAnyWhiteNoteOn(byte stats, byte note, byte velocity)
        {
            //_anyWhiteKeyNote.QueueValueChange(1.0f);
        }
        private void ProcessAnyWhiteNoteOff(byte stats, byte note, byte velocity)
        {
            //_anyWhiteKeyNote.QueueValueChange(0.0f);
        }

        private void ProcessAnyBlackNoteOn(byte stats, byte note, byte velocity)
        {
            //_anyBlackKeyNote.QueueValueChange(1.0f);
        }
        private void ProcessAnyBlackNoteOff(byte stats, byte note, byte velocity)
        {
            //_anyBlackKeyNote.QueueValueChange(0.0f);
        }

        private void ProcessPitchUp(byte stats, byte value1, byte value2)
        {
            var value = MidiMessage.GetPitchBendValue(value1, value2);
            _switchState.SetPitch(true, value > 0);
        }

        private void ProcessPitchDown(byte stats, byte value1, byte value2)
        {
            var value = MidiMessage.GetPitchBendValue(value1, value2);
            _switchState.SetPitch(false, value < 0);
        }

        private void ProcessModulation(short modulationValue)
        {
            //if (modulation == 0)
            //    _keyModulation.QueueValueChange(0.0f);
            //else
            //    _keyModulation.QueueValueChange(1.0f);
        }

        #endregion
    }
}