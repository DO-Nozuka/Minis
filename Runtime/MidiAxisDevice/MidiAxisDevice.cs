using Dono.MidiUtilities.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiAxisDevice
{
    [InputControlLayout(stateType = typeof(MidiAxisDeviceState), displayName = "MIDI Axis Device")]
    public partial class MidiAxisDevice : InputDevice
    {
        public static MidiAxisDevice current { get; private set; }

        protected override void FinishSetup()
        {
            base.FinishSetup();
        }

        public override void MakeCurrent()
        {
            base.MakeCurrent();
            current = this;
        }

        protected override void OnRemoved()
        {
            if (current == this)
                current = null;
        }
    }
}