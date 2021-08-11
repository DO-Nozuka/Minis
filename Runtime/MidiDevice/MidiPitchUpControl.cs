namespace Minis
{
    public class MidiPitchUpControl : UnityEngine.InputSystem.Controls.Vector3Control
    {
        public MidiPitchUpControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatByte;
        }
    }
}