namespace Minis.Runtime.MidiVector3Device

{
    //
    // Custom control class for MIDI controls
    //
    public class MidiCCControl : UnityEngine.InputSystem.Controls.Vector3Control
    {
        public MidiCCControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatByte;
        }
    }
}

