using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiSwitchDevice
{
    [InputControlLayout(stateType = typeof(MidiSwitchDeviceState), displayName = "MIDI Switch Device")]
    public class MidiSwitchDevice : InputDevice
    {
        MidiSwitchDeviceState state = new MidiSwitchDeviceState();
        KeyControl[] _notes;
        public void ProcessNoteOn(byte stats, byte note, byte velocity)
        {
            _notes[note].QueueValueChange(1.0f);
        }


        public void ProcessNoteOff(byte stats, byte note, byte velocity)
        {
            _notes[note].QueueValueChange(0.0f);
        }

        protected override void FinishSetup()
        {
            base.FinishSetup();

            // Populate the input controls.
            _notes = new KeyControl[128];
            for(int i = 0; i < 128; i++)
            {
                _notes[i] = GetChildControl<KeyControl>("KeyNote" + i.ToString("D3"));
            }
        }



        #region Current Device
        public static MidiSwitchDevice current { get; private set; }

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