using Dono.MidiUtilities.Runtime;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiSwitchDevice
{
    [InputControlLayout(stateType = typeof(MidiSwitchDeviceState), displayName = "MIDI Switch Device")]
    public partial class MidiSwitchDevice : InputDevice //TODO: It is better to share the same interface with MidiVector3Device.
    {
        private KeyControl[] _keyNotes;
        private KeyControl _anyKeyNote;
        private KeyControl _anyWhiteKeyNote;
        private KeyControl _anyBlackKeyNote;

        private KeyControl _keyPitchUp;
        private KeyControl _keyPitchDown;
        private KeyControl _keyModulation;

        private byte modulationMSB; //CC 01H
        private byte modulationLSB; //CC 21H
        private short modulation => (short)((modulationMSB << 7) + modulationLSB);

   
        protected override void FinishSetup()
        {
            base.FinishSetup();

            // Populate the input controls.
            _keyNotes = new KeyControl[128];
            for(int i = 0; i < 128; i++)
            {
                _keyNotes[i] = GetChildControl<KeyControl>("KeyNote" + i.ToString("D3"));
            }
            _anyKeyNote = GetChildControl<KeyControl>("AnyKeyNote");
            _anyWhiteKeyNote = GetChildControl<KeyControl>("AnyWhiteKeyNote");
            _anyBlackKeyNote = GetChildControl<KeyControl>("AnyBlackKeyNote");
            _keyPitchUp = GetChildControl<KeyControl>("KeyPitchUp");
            _keyPitchDown = GetChildControl<KeyControl>("KeyPitchDown");
            _keyModulation = GetChildControl<KeyControl>("KeyModulation");
        }



        #region Current Device
        public static MidiSwitchDevice current { get; private set; }

        public override void MakeCurrent()
        {
            base.MakeCurrent();
            current = this;
        }

        protected override void OnRemoved()
        {
            base.OnRemoved();
            if (current == this) current = null;
        }
        #endregion
    }
}