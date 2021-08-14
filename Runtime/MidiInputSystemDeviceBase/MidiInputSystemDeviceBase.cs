using System;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;

namespace Minis.Runtime.MidiInputSystemDevice
{
    public abstract partial class MidiInputSystemDevice : InputDevice, IMidiInputSystemDevice
    {
        public static MidiInputSystemDevice current { get; private set; }

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