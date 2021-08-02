namespace Minis
{
    public class MidiPitchBendControl : UnityEngine.InputSystem.Controls.Vector2Control
    {
        public MidiPitchBendControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatByte;
        }
    }
}