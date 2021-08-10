using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using Dono.MidiUtilities.Runtime;

namespace Minis
{
    //
    // Custom input device class that processes input from a MIDI channel
    //
    [InputControlLayout(stateType = typeof(MidiDeviceState), displayName = "MIDI Device")]
    public sealed class MidiDevice : InputDevice
    {
        #region Public accessors

        // MIDI channel number
        //
        // The first channel returns 0.
        public int _channel { get; private set; }

        // Get an input control object bound for a specific note.
        public MidiNoteControl GetNote(int noteNumber)
          => _notes[noteNumber];

        // Get an input control object bound for a specific control element (CC).
        public MidiCCControl GetControl(int controlNumber)
          => _controlChanges[controlNumber];

        //// Will-note-on event
        ////
        //// The input system fires this event before processing a note-on message on
        //// this device instance. It gives a target note and an input velocity as
        //// event arguments. Note that the MidiNoteControl hasn't been updated at
        //// this point.
        //public event Action<MidiNoteControl, float> onWillNoteOn
        //{
        //    // Action list lazy allocation
        //    add => (_willNoteOnActions = _willNoteOnActions ??
        //            new List<Action<MidiNoteControl, float>>()).Add(value);
        //    remove => _willNoteOnActions.Remove(value);
        //}

        //// Will-note-off event
        ////
        //// The input system fires this event before processing a note-off message
        //// on this device instance. It gives a target note as an event argument.
        //// Note that the MidiNoteControl hasn't been updated at this point.
        //public event Action<MidiNoteControl> onWillNoteOff
        //{
        //    // Action list lazy allocation
        //    add => (_willNoteOffActions = _willNoteOffActions ??
        //            new List<Action<MidiNoteControl>>()).Add(value);
        //    remove => _willNoteOffActions.Remove(value);
        //}

        //// Will-control-change event
        ////
        //// The input system fires this event before processing a CC message on this
        //// device instance. It gives a target CC object and a control value as
        //// event arguments. Note that the MidiNoteControl hasn't been updated at
        //// this point.
        //public event Action<MidiCCControl, float> onWillControlChange
        //{
        //    // Action list lazy allocation
        //    add => (_willControlChangeActions = _willControlChangeActions ??
        //            new List<Action<MidiCCControl, float>>()).Add(value);
        //    remove => _willControlChangeActions.Remove(value);
        //}

        #endregion

        #region Internal objects

        // Standard controls
        MidiNoteControl[] _notes;
        MidiCCControl[] _controlChanges;
        MidiPitchBendControl _pitchBend;
        MidiProgramChangeControl _programChange;

        // Additional controls
        MidiNoteControl _anyNote;
        MidiNoteControl _anyWhiteNote;
        MidiNoteControl _anyBlackNote;
        MidiPitchUpControl _pitchUp;
        MidiPitchDownControl _pitchDown;

        List<Action<MidiNoteControl, float>> _willNoteOnActions;
        List<Action<MidiNoteControl>> _willNoteOffActions;
        List<Action<MidiCCControl, float>> _willControlChangeActions;
        List<Action<MidiPitchBendControl, float>> _willPitchBendActions;
        List<Action<MidiPitchUpControl, float>> _willPitchUpActions;
        List<Action<MidiPitchDownControl, float>> _willPitchDownActions;
        List<Action<MidiProgramChangeControl, float>> _willProgramChangeActions;

        #endregion

        #region MIDI event receiver (invoked from MidiPort)

        internal void ProcessNoteOn(byte stats, byte note, byte velocity)
        {
            // State update with a delta event
            _notes[note].QueueValueChange(new Vector3(stats, note, velocity));

            // Send to additional controls
            ProcessAnyNoteOn(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOn(stats, note, velocity);
            else
                ProcessAnyBlackNoteOn(stats, note, velocity);
            
            // Note-on event invocation (only when it exists)
            var fvelocity = velocity / 127.0f;
            if (_willNoteOnActions != null)
                foreach (var action in _willNoteOnActions)
                    action(_notes[note], fvelocity);
        }

        internal void ProcessNoteOff(byte stats, byte note, byte velocity)
        {
            // State update with a delta event
            _notes[note].QueueValueChange(new Vector3(stats, note, velocity));

            // Send to additional controls
            ProcessAnyNoteOff(stats, note, velocity);
            if (MidiMessage.IsWhiteNote(note))
                ProcessAnyWhiteNoteOff(stats, note, velocity);
            else
                ProcessAnyBlackNoteOff(stats, note, velocity);

            // Note-off event invocation (only when it exists)
            if (_willNoteOffActions != null)
                foreach (var action in _willNoteOffActions)
                    action(_notes[note]);
        }

        internal void ProcessControlChange(byte stats, byte number, byte value)
        {
            // State update with a delta event
            var channel = (byte)(stats & 0x0F);
            _controlChanges[number].QueueValueChange(new Vector3(stats, number, value));
            // Control-change event invocation (only when it exists)
            var fvalue = value / 127.0f;
            if (_willControlChangeActions != null)
                foreach (var action in _willControlChangeActions)
                    action(_controlChanges[number], fvalue);
        }


        private bool IsLastPitchUp = false;
        private bool IsLastPitchDown = false;
        internal void ProcessPitchBend(byte stats, byte value1, byte value2)
        {
            //var channel = (byte)(stats & 0x0F);
            var value = GetPitchBendValue(value1, value2);

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
                value = 0;

                if (IsLastPitchDown)
                    ProcessPitchDown(stats, value1, value2);
                else if (IsLastPitchUp)
                    ProcessPitchUp(stats, value1, value2);
            }

            //State update with a delta event
            _pitchBend.QueueValueChange(new Vector3(stats, value1, value2));

            //Control-change event invocation (only when it exists)
            var fvalue = value;
            if (_willPitchBendActions != null)
                foreach (var action in _willPitchBendActions)
                    action(_pitchBend, fvalue);
        }

        internal void ProcessProgramChange(byte stats, byte value)
        {
            //State update with a delta event
            var channel = (byte)(stats & 0x0F);
            _programChange.QueueValueChange(new Vector3(stats, value, 0x00));

            //Control-change event invocation (only when it exists)
            var fvalue = value / 127f;
            if (_willProgramChangeActions != null)
                foreach (var action in _willProgramChangeActions)
                    action(_programChange, fvalue);
        }

        //----
        private void ProcessAnyNoteOn(byte stats, byte note, byte velocity)
        {
            InputSystem.QueueDeltaStateEvent(_anyNote, new Vector3(stats, note, velocity));
        }
        private void ProcessAnyNoteOff(byte stats, byte note, byte velocity)
        {
            InputSystem.QueueDeltaStateEvent(_anyNote, new Vector3(stats, note, velocity));
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">0.0to1.0f</param>
        /// <param name="channel">0to15</param>
        private void ProcessPitchUp(byte stats, byte value1, byte value2)
        {
            // State update with a delta event
            InputSystem.QueueDeltaStateEvent(_pitchUp, new Vector3(stats, value1, value2));

            // Control-change event invocation (only when it exists)
            var fvalue = GetPitchBendRate(value1, value2);
            if (_willPitchUpActions != null)
                foreach (var action in _willPitchUpActions)
                    action(_pitchUp, fvalue);
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

            // Control-change event invocation (only when it exists)
            var fvalue = GetPitchBendRate(value1, value2);
            if (_willPitchDownActions != null)
                foreach (var action in _willPitchDownActions)
                    action(_pitchDown, fvalue);
        }

        #endregion

        #region InputDevice implementation

        protected override void FinishSetup()
        {
            base.FinishSetup();

            // Populate the input controls.
            _notes = new MidiNoteControl[128];
            _controlChanges = new MidiCCControl[128];

            for (var i = 0; i < 128; i++)
            {
                _notes[i] = GetChildControl<MidiNoteControl>("DonoNote" + i.ToString("D3"));
                _controlChanges[i] = GetChildControl<MidiCCControl>("DonoControl" + i.ToString("D3"));
            }
            _pitchBend = GetChildControl<MidiPitchBendControl>("PitchBend");
            _programChange = GetChildControl<MidiProgramChangeControl>("ProgramChange");

            _anyNote = GetChildControl<MidiNoteControl>("AnyNote");
            _anyWhiteNote = GetChildControl<MidiNoteControl>("AnyWhiteNote");
            _anyBlackNote = GetChildControl<MidiNoteControl>("AnyBlackNote");
            _pitchUp = GetChildControl<MidiPitchUpControl>("PitchUp");
            _pitchDown = GetChildControl<MidiPitchDownControl>("PitchDown");

            // MIDI channel number determination
            // Here is a dirty trick: Parse the last two characters in the product
            // name and use it as a channel number.
            var product = description.product;
            _channel = int.Parse(product.Substring(product.Length - 2));
        }

        public static MidiDevice current { get; private set; }

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

        #region static function
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns></returns>
        public int GetPitchBendValue(byte value1, byte value2) => (value2 << 7) + value1 - 8192;
        public float GetPitchBendRate(byte value1, byte value2)
        {
            var value = GetPitchBendValue(value1, value2);
            return value > 0 ? value / 8191f : value / 8192f;
        }
        #endregion
    }

}
