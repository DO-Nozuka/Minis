using Dono.MidiUtilities.Runtime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiAxisDevice
{
    [InputControlLayout(stateType = typeof(MidiAxisDeviceState), displayName = "MIDI Axis Device")]
    public partial class MidiAxisDevice : InputDevice //TODO: It is better to share the same interface with MidiVector3Device.
    {
        public static MidiAxisDevice current { get; private set; }

        protected override void FinishSetup()
        {
            base.FinishSetup();
        }

        public override void MakeCurrent()
        {
            base.MakeCurrent();
            current = this;
        }

        protected override void OnRemoved()
        {
            if (current == this)
                current = null;
        }

//        static void RegisterLayout()
//        {
//            //���̃��\�b�h��InputAction�A�Z�b�g��BindingPath�ɔ��f�����
//            InputSystem.RegisterLayout<MidiAxisDevice>(
//                matches: new InputDeviceMatcher().WithInterface("MidiAxis")
//                );
//        }

//#if UNITY_EDITOR
//        static MidiAxisDevice()
//        {
//            RegisterLayout();
//        }
//#else
//        [RuntimeInitializeOnLoadMethod]
//        static void InitializeInPlayer()
//        {

//            //�f�o�C�X��ǉ�����ɂ͉��̃��\�b�h���Ăяo��
//            //InputSystem.AddDevice&lt;InputFromLeanTouch>();
//            //����̏ꍇ��LeanTouch���V�[�����ɒu���Ă���K�v������̂Ŏ��s����Awake����Ăяo��
//            //���̂��߂̃R���|�[�l���g��ʂɍ��K�v������̂�
//            //LeanTouchSupport.cs��ʂɍ��
//        }
//#endif

    }
}