using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace Minis.Runtime.MidiAxis2ByteCCDevice
{
    [StructLayout(LayoutKind.Auto)]
    public unsafe struct MidiAxis2ByteCCDeviceState : IInputStateTypeInfo
    {
        public FourCC format => new FourCC('M', 'A', '2', 'C'); //MIDi Axis 2 CC

        [InputControl(name = "Axis2ByteCC000", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC001", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC002", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC003", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC004", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC005", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC006", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC007", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC008", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC009", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC010", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC011", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC012", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC013", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC014", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC015", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC016", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC017", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC018", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC019", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC020", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC021", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC022", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC023", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC024", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC025", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC026", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC027", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC028", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC029", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC030", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "Axis2ByteCC031", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        public fixed float __axis2ByteCC[32];

        //private byte this[byte note]
        //{
        //    set
        //    {
        //        SetCC(note, value);
        //    }
        //    get
        //    {
        //        return GetCC(note);
        //    }
        //}

        public float GetCC(byte cc) { return __axis2ByteCC[cc % 32]; }
        /// <summary>
        /// </summary>
        /// <param name="cc">Note Number</param>
        /// <param name="value">in byte</param>
        public void SetCC(byte cc, float value) { __axis2ByteCC[cc % 32] = value; }

    }
}