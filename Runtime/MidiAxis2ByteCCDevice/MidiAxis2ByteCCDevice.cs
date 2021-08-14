using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiAxis2ByteCCDevice
{
    [InputControlLayout(stateType = typeof(MidiAxis2ByteCCDeviceState), displayName = "MIDI Axis 2ByteCC Device")]
    public partial class MidiAxis2ByteCCDevice : InputDevice
    {
        public static MidiAxis2ByteCCDevice current { get; private set; }

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