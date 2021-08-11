using Dono.MidiUtilities.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiVector3Device
{
    //
    // Custom input device class that processes input from a MIDI channel
    //
    [InputControlLayout(stateType = typeof(MidiDeviceState), displayName = "MIDI Device")]
    public sealed class MidiVector3Device : InputDevice
    {
        #region Public accessors

        // MIDI channel number
        //
        // The first channel returns 0.
        public int _channel { get; private set; }
        #endregion

        #region Internal objects

        // Standard controls(Vector3)
        Vector3Control[] _notes;
        Vector3Control[] _controlChanges;
        Vector3Control _pitchBend;
        Vector3Control _programChange;

        // Additional controls
        Vector3Control _anyNote;
        Vector3Control _anyWhiteNote;
        Vector3Control _anyBlackNote;
        Vector3Control _pitchUp;
        Vector3Control _pitchDown;


        #endregion

        #region MIDI event receiver (invoked from MidiPort)

        public void ProcessNoteOn(byte stats, byte note, byte velocity)
        {
            // State update with a delta event
            _notes[note].QueueValueChange(new Vector3(stats, note, velocity));

            // Send to additional controls
            ProcessAnyNoteOn(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOn(stats, note, velocity);
            else
                ProcessAnyBlackNoteOn(stats, note, velocity);
        }

        public void ProcessNoteOff(byte stats, byte note, byte velocity)
        {
            // State update with a delta event
            _notes[note].QueueValueChange(new Vector3(stats, note, velocity));

            // Send to additional controls
            ProcessAnyNoteOff(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOff(stats, note, velocity);
            else
                ProcessAnyBlackNoteOff(stats, note, velocity);
        }

        public void ProcessControlChange(byte stats, byte number, byte value)
        {
            // State update with a delta event
            var channel = (byte)(stats & 0x0F);
            _controlChanges[number].QueueValueChange(new Vector3(stats, number, value));
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
            _pitchBend.QueueValueChange(new Vector3(stats, value1, value2));
        }

        public void ProcessProgramChange(byte stats, byte value)
        {
            //State update with a delta event
            var channel = (byte)(stats & 0x0F);
            _programChange.QueueValueChange(new Vector3(stats, value, 0x00));
        }

        //----
        private void ProcessAnyNoteOn(byte stats, byte note, byte velocity)
        {
            _anyNote.QueueValueChange(new Vector3(stats, note, velocity));
        }
        private void ProcessAnyNoteOff(byte stats, byte note, byte velocity)
        {
            _anyNote.QueueValueChange(new Vector3(stats, note, velocity));
        }

        private void ProcessAnyWhiteNoteOn(byte stats, byte note, byte velocity)
        {
            _anyWhiteNote.QueueValueChange(new Vector3(stats, note, velocity));
        }
        private void ProcessAnyWhiteNoteOff(byte stats, byte note, byte velocity)
        {
            _anyWhiteNote.QueueValueChange(new Vector3(stats, note, velocity));
        }
        private void ProcessAnyBlackNoteOn(byte stats, byte note, byte velocity)
        {
            _anyBlackNote.QueueValueChange(new Vector3(stats, note, velocity));
        }
        private void ProcessAnyBlackNoteOff(byte stats, byte note, byte velocity)
        {
            _anyBlackNote.QueueValueChange(new Vector3(stats, note, velocity));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">0.0to1.0f</param>
        /// <param name="channel">0to15</param>
        private void ProcessPitchUp(byte stats, byte value1, byte value2)
        {
            // State update with a delta event
            InputSystem.QueueDeltaStateEvent(_pitchUp, new Vector3(stats, value1, value2));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">0.0to1.0f</param>
        /// <param name="channel">0to15</param>
        private void ProcessPitchDown(byte stats, byte value1, byte value2)
        {
            // State update with a delta event
            InputSystem.QueueDeltaStateEvent(_pitchDown, new Vector3(stats, value1, value2));
        }

        #endregion

        #region InputDevice implementation

        protected override void FinishSetup()
        {
            base.FinishSetup();

            // Populate the input controls.
            _notes = new Vector3Control[128];
            _controlChanges = new Vector3Control[128];

            for (var i = 0; i < 128; i++)
            {
                _notes[i] = GetChildControl<Vector3Control>("DonoNote" + i.ToString("D3"));
                _controlChanges[i] = GetChildControl<Vector3Control>("DonoControl" + i.ToString("D3"));
            }

            _pitchBend = GetChildControl<Vector3Control>("PitchBend");
            _programChange = GetChildControl<Vector3Control>("ProgramChange");

            _anyNote = GetChildControl<Vector3Control>("AnyNote");
            _anyWhiteNote = GetChildControl<Vector3Control>("AnyWhiteNote");
            _anyBlackNote = GetChildControl<Vector3Control>("AnyBlackNote");
            _pitchUp = GetChildControl<Vector3Control>("PitchUp");
            _pitchDown = GetChildControl<Vector3Control>("PitchDown");

            // MIDI channel number determination
            // Here is a dirty trick: Parse the last two characters in the product
            // name and use it as a channel number.
            var product = description.product;
            _channel = int.Parse(product.Substring(product.Length - 2));
        }

        public static MidiVector3Device current { get; private set; }

        public override void MakeCurrent()
        {
            base.MakeCurrent();
            current = this;
        }

        protected override void OnRemoved()
        {
            base.OnRemoved();
            if (current == this) current = null;
        }

        #endregion

    }

}
