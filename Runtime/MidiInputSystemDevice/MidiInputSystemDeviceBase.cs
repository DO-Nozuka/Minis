using System;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiInputSystemDevice
{
    public abstract partial class MidiInputSystemDeviceBase : InputDevice, IMidiInputSystemDevice
    {
        public static MidiInputSystemDeviceBase current { get; private set; }

        // protected override void FinishSetup()
        // {
        //     base.FinishSetup();
        // }
        
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
    }
}