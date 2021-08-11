namespace Minis.Runtime.MidiVector3Device
{
    public class MidiProgramChangeControl : UnityEngine.InputSystem.Controls.Vector3Control
    {
        public MidiProgramChangeControl()
        {
            m_StateBlock.format =
                UnityEngine.InputSystem.LowLevel.InputStateBlock.FormatVector3Byte;
        }
    }
}