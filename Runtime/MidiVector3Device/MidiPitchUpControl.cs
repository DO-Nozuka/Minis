namespace Minis.Runtime.MidiVector3Device
{
    public class MidiPitchUpControl : UnityEngine.InputSystem.Controls.Vector3Control
    {
        public MidiPitchUpControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatVector3Byte;
        }
    }
}