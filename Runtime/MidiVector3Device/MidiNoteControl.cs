namespace Minis.Runtime.MidiVector3Device
{
    //
    // Custom control class for MIDI nots
    //
    public class MidiNoteControl : UnityEngine.InputSystem.Controls.Vector3Control
    {
        public MidiNoteControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatByte;
        }
    }
}
