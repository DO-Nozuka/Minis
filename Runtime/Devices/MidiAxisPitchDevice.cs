using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.Devices
{
    [InputControlLayout(stateType = typeof(MidiAxisPitchDeviceState), displayName = "Midi Axis Pitch Device")]
    public partial class MidiAxisPitchDevice : InputDevice, IMidiInputSystemDevice
    {
        public static MidiAxisPitchDevice current { get; private set; }

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