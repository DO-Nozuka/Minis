namespace Minis.Runtime.MidiVector3Device
{
    public class MidiPitchDownControl : UnityEngine.InputSystem.Controls.Vector3Control
    {
        public MidiPitchDownControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatVector3Byte;
        }
    }
}