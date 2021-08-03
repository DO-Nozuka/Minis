using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

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
        public int channel { get; private set; }

        // Get an input control object bound for a specific note.
        public MidiNoteControl GetNote(int noteNumber)
          => _notes[noteNumber];

        // Get an input control object bound for a specific control element (CC).
        public MidiCCControl GetControl(int controlNumber)
          => _controlChanges[controlNumber];

        // Will-note-on event
        //
        // The input system fires this event before processing a note-on message on
        // this device instance. It gives a target note and an input velocity as
        // event arguments. Note that the MidiNoteControl hasn't been updated at
        // this point.
        public event Action<MidiNoteControl, float> onWillNoteOn
        {
            // Action list lazy allocation
            add => (_willNoteOnActions = _willNoteOnActions ??
                    new List<Action<MidiNoteControl, float>>()).Add(value);
            remove => _willNoteOnActions.Remove(value);
        }

        // Will-note-off event
        //
        // The input system fires this event before processing a note-off message
        // on this device instance. It gives a target note as an event argument.
        // Note that the MidiNoteControl hasn't been updated at this point.
        public event Action<MidiNoteControl> onWillNoteOff
        {
            // Action list lazy allocation
            add => (_willNoteOffActions = _willNoteOffActions ??
                    new List<Action<MidiNoteControl>>()).Add(value);
            remove => _willNoteOffActions.Remove(value);
        }

        // Will-control-change event
        //
        // The input system fires this event before processing a CC message on this
        // device instance. It gives a target CC object and a control value as
        // event arguments. Note that the MidiNoteControl hasn't been updated at
        // this point.
        public event Action<MidiCCControl, float> onWillControlChange
        {
            // Action list lazy allocation
            add => (_willControlChangeActions = _willControlChangeActions ??
                    new List<Action<MidiCCControl, float>>()).Add(value);
            remove => _willControlChangeActions.Remove(value);
        }

        #endregion

        #region Internal objects


        MidiNoteControl[] _notes;
        MidiCCControl[] _controlChanges;
        MidiPitchBendControl _pitchBend;
        MidiPitchUpControl _pitchUp;
        MidiPitchDownControl _pitchDown;


        List<Action<MidiNoteControl, float>> _willNoteOnActions;
        List<Action<MidiNoteControl>> _willNoteOffActions;
        List<Action<MidiCCControl, float>> _willControlChangeActions;
        List<Action<MidiPitchBendControl, float>> _willPitchBendActions;
        List<Action<MidiPitchUpControl, float>> _willPitchUpActions;
        List<Action<MidiPitchDownControl, float>> _willPitchDownActions;

        #endregion

        #region MIDI event receiver (invoked from MidiPort)

        internal void ProcessNoteOn(byte note, byte velocity, byte channel)
        {
            // State update with a delta event        
            InputSystem.QueueDeltaStateEvent(_notes[note], new Vector2(velocity, channel));
            // Note-on event invocation (only when it exists)

            var fvelocity = velocity / 127.0f;
            if (_willNoteOnActions != null)
                foreach (var action in _willNoteOnActions)
                    action(_notes[note], fvelocity);
        }

        internal void ProcessNoteOff(byte note, byte channel)
        {
            // State update with a delta event
            InputSystem.QueueDeltaStateEvent(_notes[note], new Vector2(0f, channel));

            // Note-off event invocation (only when it exists)
            if (_willNoteOffActions != null)
                foreach (var action in _willNoteOffActions)
                    action(_notes[note]);
        }

        internal void ProcessControlChange(byte number, byte value, byte channel)
        {
            // State update with a delta event

            InputSystem.QueueDeltaStateEvent(_controlChanges[number], new Vector2(value, channel));
            // Control-change event invocation (only when it exists)
            var fvalue = value / 127.0f;
            if (_willControlChangeActions != null)
                foreach (var action in _willControlChangeActions)
                    action(_controlChanges[number], fvalue);
        }


        private bool IsLastPitchUp = false;
        private bool IsLastPitchDown = false;
        internal void ProcessPitchBend(byte value1, byte value2, byte channel)
        {
            var PitchBendValue = (value2 << 7) + value1 - 8192;

            float value;
            if (PitchBendValue < 0)
            {
                value = PitchBendValue / 8192f;
                ProcessPitchDown(-value, channel);
                IsLastPitchDown = true;
                IsLastPitchUp = false;
            }
            else if (PitchBendValue > 0)
            {
                value = PitchBendValue / 8191f;
                ProcessPitchUp(value, channel);
                IsLastPitchDown = false;
                IsLastPitchUp = true;
            }
            else
            {
                value = 0;

                if (IsLastPitchDown)
                    ProcessPitchDown(value, channel);
                else if (IsLastPitchUp)
                    ProcessPitchUp(value, channel);
            }

            //State update with a delta event
           InputSystem.QueueDeltaStateEvent(_pitchBend, new Vector2(value, channel));

            //Control-change event invocation (only when it exists)
            var fvalue = value;
            if (_willPitchBendActions != null)
                foreach (var action in _willPitchBendActions)
                    action(_pitchBend, fvalue);
    }


        Vector2 PitchUpValue = new Vector2();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">0.0to1.0f</param>
        /// <param name="channel">0to15</param>
        private void ProcessPitchUp(float value, byte channel)
        {
            PitchUpValue.x = value;
            PitchUpValue.y = channel;
            // State update with a delta event
            InputSystem.QueueDeltaStateEvent(_pitchUp, PitchUpValue);

            // Control-change event invocation (only when it exists)
            var fvalue = value;
            if (_willPitchUpActions != null)
                foreach (var action in _willPitchUpActions)
                    action(_pitchUp, fvalue);
        }

        Vector2 PitchDownValue = new Vector2();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">0.0to1.0f</param>
        /// <param name="channel">0to15</param>
        private void ProcessPitchDown(float value, byte channel)
        {
            PitchDownValue.x = value;
            PitchDownValue.y = channel;
            // State update with a delta event
            InputSystem.QueueDeltaStateEvent(_pitchDown, PitchDownValue);

            // Control-change event invocation (only when it exists)
            var fvalue = value;
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
            _pitchUp = GetChildControl<MidiPitchUpControl>("PitchUp");
            _pitchDown = GetChildControl<MidiPitchDownControl>("PitchDown");

            // MIDI channel number determination
            // Here is a dirty trick: Parse the last two characters in the product
            // name and use it as a channel number.
            var product = description.product;
            channel = int.Parse(product.Substring(product.Length - 2));
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
    }

}
