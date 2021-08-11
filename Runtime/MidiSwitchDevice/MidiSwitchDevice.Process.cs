using Dono.MidiUtilities.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiSwitchDevice
{
    public partial class MidiSwitchDevice : InputDevice //TODO: It is better to share the same interface with MidiVector3Device.
    {
        #region MIDI event receiver (invoked from MidiPort)
        public void ProcessNoteOn(byte stats, byte note, byte velocity)
        {
            _keyNotes[note].QueueValueChange(1.0f);

            // Send to additional controls
            ProcessAnyNoteOn(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOn(stats, note, velocity);
            else
                ProcessAnyBlackNoteOn(stats, note, velocity);
        }


        public void ProcessNoteOff(byte stats, byte note, byte velocity)
        {
            _keyNotes[note].QueueValueChange(0.0f);

            // Send to additional controls
            ProcessAnyNoteOff(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOff(stats, note, velocity);
            else
                ProcessAnyBlackNoteOff(stats, note, velocity);
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
        }

        private bool IsLastPitchUp = false;
        private bool IsLastPitchDown = false;
        public void ProcessPitchBend(byte stats, byte value1, byte value2)
        {
            //var channel = (byte)(stats & 0x0F);
            var value = MidiMessage.GetPitchBendValue(value1, value2);

            if (value < 0)
            {
                IsLastPitchDown = true;
                IsLastPitchUp = false;
            }
            else if (value > 0)
            {
                IsLastPitchDown = false;
                IsLastPitchUp = true;
            }
            else
            {
                if (IsLastPitchDown)
                    ProcessPitchDown(stats, value1, value2);
                else if (IsLastPitchUp)
                    ProcessPitchUp(stats, value1, value2);
            }
        }

        public void ProcessProgramChange(byte stats, byte value) { }

        //----
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
            //var value = MidiMessage.GetPitchBendValue(value1, value2);
            //_keyPitchUp.QueueValueChange(value > 0 ? 1.0f : 0.0f);
        }

        private void ProcessPitchDown(byte stats, byte value1, byte value2)
        {
            //var value = MidiMessage.GetPitchBendValue(value1, value2);
            //_keyPitchDown.QueueValueChange(value < 0 ? 1.0f : 0.0f);
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