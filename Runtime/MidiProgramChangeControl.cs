namespace Minis
{
    public class MidiProgramChangeControl : UnityEngine.InputSystem.Controls.Vector3Control
    {
        public MidiProgramChangeControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatByte;
        }
    }
}