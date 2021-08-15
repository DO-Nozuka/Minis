using Dono.MidiUtilities.Runtime;
using UnityEngine.InputSystem;

namespace Minis.Runtime.Devices
{
    public partial class MidiVector3Device : InputDevice, IMidiInputSystemDevice
    {
        static MidiVector3DeviceState _state;
        public void ProcessNoteOn(byte stats, byte note, byte velocity)
        {
            // State update with a delta event
            _state.SetNoteOn(stats, note, velocity);

            // Send to additional controls
            ProcessAnyNoteOn(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOn(stats, note, velocity);
            else
                ProcessAnyBlackNoteOn(stats, note, velocity);

            InputSystem.QueueDeltaStateEvent(this, _state);
        }

        public void ProcessNoteOff(byte stats, byte note, byte velocity)
        {
            // State update with a delta event
            _state.SetNoteOff(stats, note, velocity);

            // Send to additional controls
            ProcessAnyNoteOff(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOff(stats, note, velocity);
            else
                ProcessAnyBlackNoteOff(stats, note, velocity);

            InputSystem.QueueDeltaStateEvent(this, _state);
        }

        public void ProcessControlChange(byte stats, byte number, byte value)
        {
            // State update with a delta event
            var channel = (byte)(stats & 0x0F);
            //_controlChanges[number].QueueValueChange(new Vector3(stats, number, value));
        }


        private bool IsLastPitchUp = false;
        private bool IsLastPitchDown = false;
        public void ProcessPitchBend(byte stats, byte value1, byte value2)
        {
            //var channel = (byte)(stats & 0x0F);
            var value = MidiMessage.GetPitchBendValue(value1, value2);

            if (value < 0)
            {
                ProcessPitchDown(stats, value1, value2);
                IsLastPitchDown = true;
                IsLastPitchUp = false;
            }
            else if (value > 0)
            {
                ProcessPitchUp(stats, value1, value2);
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

            //State update with a delta event
            //_pitchBend.QueueValueChange(new Vector3(stats, value1, value2));
        }

        public void ProcessProgramChange(byte stats, byte value)
        {
            //State update with a delta event
            var channel = (byte)(stats & 0x0F);
            //_programChange.QueueValueChange(new Vector3(stats, value, 0x00));
        }

        //----
        private void ProcessAnyNoteOn(byte stats, byte note, byte velocity)
        {
            //_anyNote.QueueValueChange(new Vector3(stats, note, velocity));
        }
        private void ProcessAnyNoteOff(byte stats, byte note, byte velocity)
        {
            //_anyNote.QueueValueChange(new Vector3(stats, note, velocity));
        }

        private void ProcessAnyWhiteNoteOn(byte stats, byte note, byte velocity)
        {
            //_anyWhiteNote.QueueValueChange(new Vector3(stats, note, velocity));
        }
        private void ProcessAnyWhiteNoteOff(byte stats, byte note, byte velocity)
        {
            //_anyWhiteNote.QueueValueChange(new Vector3(stats, note, velocity));
        }
        private void ProcessAnyBlackNoteOn(byte stats, byte note, byte velocity)
        {
            //_anyBlackNote.QueueValueChange(new Vector3(stats, note, velocity));
        }
        private void ProcessAnyBlackNoteOff(byte stats, byte note, byte velocity)
        {
            //_anyBlackNote.QueueValueChange(new Vector3(stats, note, velocity));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">0.0to1.0f</param>
        /// <param name="channel">0to15</param>
        private void ProcessPitchUp(byte stats, byte value1, byte value2)
        {
            // State update with a delta event
            //InputSystem.QueueDeltaStateEvent(_pitchUp, new Vector3(stats, value1, value2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">0.0to1.0f</param>
        /// <param name="channel">0to15</param>
        private void ProcessPitchDown(byte stats, byte value1, byte value2)
        {
            // State update with a delta event
            //InputSystem.QueueDeltaStateEvent(_pitchDown, new Vector3(stats, value1, value2));
        }
    }
}