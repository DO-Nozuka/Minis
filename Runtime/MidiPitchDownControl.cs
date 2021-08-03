namespace Minis
{
    public class MidiPitchDownControl : UnityEngine.InputSystem.Controls.Vector2Control
    {
        public MidiPitchDownControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatByte;

            
        }
    }
}