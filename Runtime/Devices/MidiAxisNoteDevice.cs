using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.Devices
{
    [InputControlLayout(stateType = typeof(MidiAxisNoteDeviceState), displayName = "MIDI Axis Note Device")]
    public partial class MidiAxisNoteDevice : InputDevice, IMidiInputSystemDevice
    {
        public static MidiAxisNoteDevice current { get; private set; }

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