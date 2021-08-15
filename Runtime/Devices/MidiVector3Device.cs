using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.Devices
{
    [InputControlLayout(stateType = typeof(MidiVector3DeviceState), displayName = "MIDI Vector3 Device")]
    public partial class MidiVector3Device : InputDevice, IMidiInputSystemDevice
    {
        public static MidiVector3Device current { get; private set; }

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
