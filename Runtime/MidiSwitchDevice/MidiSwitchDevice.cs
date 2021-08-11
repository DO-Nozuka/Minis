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
        internal void ProcessNoteOn(byte stats, byte note, byte velocity)
        {
            state.NoteOn(note);
        }


        internal void ProcessNoteOff(byte stats, byte note, byte velocity)
        {
            state.NoteOff(note);
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