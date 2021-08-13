using Dono.MidiUtilities.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiVector3Device
{
    [InputControlLayout(stateType = typeof(MidiVector3DeviceState), displayName = "MIDI Vector3 Device")]
    public partial class MidiVector3Device : InputDevice
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
