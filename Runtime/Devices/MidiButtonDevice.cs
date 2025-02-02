using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.Devices
{
    [InputControlLayout(stateType = typeof(MidiButtonDeviceState), displayName = "MIDI Button Device")]
    public partial class MidiButtonDevice : InputDevice, IMidiInputSystemDevice
    {
        public static MidiButtonDevice current { get; private set; }

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