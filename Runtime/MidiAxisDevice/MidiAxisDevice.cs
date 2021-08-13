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
//            //このメソッドでInputActionアセットのBindingPathに反映される
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

//            //デバイスを追加するには下のメソッドを呼び出す
//            //InputSystem.AddDevice&lt;InputFromLeanTouch>();
//            //今回の場合はLeanTouchがシーン内に置いてある必要があるので実行時にAwakeから呼び出す
//            //そのためのコンポーネントを別に作る必要があるので
//            //LeanTouchSupport.csを別に作る
//        }
//#endif

    }
}