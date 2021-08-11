namespace Minis.Runtime.MidiVector3Device
{
    public class MidiPitchBendControl : UnityEngine.InputSystem.Controls.Vector3Control
    {
        public MidiPitchBendControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatVector3Byte;
        }
    }
}