using Dono.MidiUtilities.Runtime;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiSwitchDevice
{
    [InputControlLayout(stateType = typeof(MidiSwitchDeviceState), displayName = "MIDI Switch Device")]
    public partial class MidiSwitchDevice : InputDevice //TODO: It is better to share the same interface with MidiVector3Device.
    {
        public ButtonControl keyNote000 { get; private set; }
        public ButtonControl keyNote001 { get; private set; }
        public ButtonControl keyNote002 { get; private set; }
        public ButtonControl keyNote003 { get; private set; }
        public ButtonControl keyNote004 { get; private set; }
        public ButtonControl keyNote005 { get; private set; }
        public ButtonControl keyNote006 { get; private set; }
        public ButtonControl keyNote007 { get; private set; }
        public ButtonControl keyNote008 { get; private set; }
        public ButtonControl keyNote009 { get; private set; }
        public ButtonControl keyNote010 { get; private set; }
        public ButtonControl keyNote011 { get; private set; }
        public ButtonControl keyNote012 { get; private set; }
        public ButtonControl keyNote013 { get; private set; }
        public ButtonControl keyNote014 { get; private set; }
        public ButtonControl keyNote015 { get; private set; }
        public ButtonControl keyNote016 { get; private set; }
        public ButtonControl keyNote017 { get; private set; }
        public ButtonControl keyNote018 { get; private set; }
        public ButtonControl keyNote019 { get; private set; }
        public ButtonControl keyNote020 { get; private set; }
        public ButtonControl keyNote021 { get; private set; }
        public ButtonControl keyNote022 { get; private set; }
        public ButtonControl keyNote023 { get; private set; }
        public ButtonControl keyNote024 { get; private set; }
        public ButtonControl keyNote025 { get; private set; }
        public ButtonControl keyNote026 { get; private set; }
        public ButtonControl keyNote027 { get; private set; }
        public ButtonControl keyNote028 { get; private set; }
        public ButtonControl keyNote029 { get; private set; }
        public ButtonControl keyNote030 { get; private set; }
        public ButtonControl keyNote031 { get; private set; }

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
            keyNote000 = GetChildControl<ButtonControl>("keyNote000");
            keyNote001 = GetChildControl<ButtonControl>("keyNote001");
            keyNote002 = GetChildControl<ButtonControl>("keyNote002");
            keyNote003 = GetChildControl<ButtonControl>("keyNote003");
            keyNote004 = GetChildControl<ButtonControl>("keyNote004");
            keyNote005 = GetChildControl<ButtonControl>("keyNote005");
            keyNote006 = GetChildControl<ButtonControl>("keyNote006");
            keyNote007 = GetChildControl<ButtonControl>("keyNote007");
            keyNote008 = GetChildControl<ButtonControl>("keyNote008");
            keyNote009 = GetChildControl<ButtonControl>("keyNote009");
            keyNote010 = GetChildControl<ButtonControl>("keyNote010");
            keyNote011 = GetChildControl<ButtonControl>("keyNote011");
            keyNote012 = GetChildControl<ButtonControl>("keyNote012");
            keyNote013 = GetChildControl<ButtonControl>("keyNote013");
            keyNote014 = GetChildControl<ButtonControl>("keyNote014");
            keyNote015 = GetChildControl<ButtonControl>("keyNote015");
            keyNote016 = GetChildControl<ButtonControl>("keyNote016");
            keyNote017 = GetChildControl<ButtonControl>("keyNote017");
            keyNote018 = GetChildControl<ButtonControl>("keyNote018");
            keyNote019 = GetChildControl<ButtonControl>("keyNote019");
            keyNote020 = GetChildControl<ButtonControl>("keyNote020");
            keyNote021 = GetChildControl<ButtonControl>("keyNote021");
            keyNote022 = GetChildControl<ButtonControl>("keyNote022");
            keyNote023 = GetChildControl<ButtonControl>("keyNote023");
            keyNote024 = GetChildControl<ButtonControl>("keyNote024");
            keyNote025 = GetChildControl<ButtonControl>("keyNote025");
            keyNote026 = GetChildControl<ButtonControl>("keyNote026");
            keyNote027 = GetChildControl<ButtonControl>("keyNote027");
            keyNote028 = GetChildControl<ButtonControl>("keyNote028");
            keyNote029 = GetChildControl<ButtonControl>("keyNote029");
            keyNote030 = GetChildControl<ButtonControl>("keyNote030");
            keyNote031 = GetChildControl<ButtonControl>("keyNote031");
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