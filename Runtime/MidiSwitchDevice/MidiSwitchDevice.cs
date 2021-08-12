using Dono.MidiUtilities.Runtime;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiSwitchDevice
{
    [InputControlLayout(stateType = typeof(MidiSwitchDeviceState), displayName = "MIDI Switch Device")]
    public partial class MidiSwitchDevice : InputDevice //TODO: It is better to share the same interface with MidiVector3Device.
    {
        public static MidiSwitchDevice current { get; private set; }
        //private KeyControl _anyKeyNote;
        //[InputControl] private KeyControl _anyWhiteKeyNote;
        //private KeyControl _anyBlackKeyNote;

        ////private KeyControl _keyPitchUp;
        ////private KeyControl _keyPitchDown;
        ////private KeyControl _keyModulation;

        //private byte modulationMSB; //CC 01H
        //private byte modulationLSB; //CC 21H
        //private short modulation => (short)((modulationMSB << 7) + modulationLSB);


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