using Dono.MidiUtilities.Runtime;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiButtonDevice
{
    [InputControlLayout(stateType = typeof(MidiButtonDeviceState), displayName = "MIDI Button Device")]
    public partial class MidiButtonDevice : InputDevice //TODO: It is better to share the same interface with MidiVector3Device.
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