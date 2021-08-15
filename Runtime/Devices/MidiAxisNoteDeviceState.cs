using System.Runtime.InteropServices;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace Minis.Runtime.Devices
{
    [StructLayout(LayoutKind.Auto)]//, Size = 20)]   //Size : in Byte Note:16, Pitch:4, AnyNote:4 
    public unsafe struct MidiAxisNoteDeviceState : IInputStateTypeInfo
    {
        public FourCC format => new FourCC('M', 'I', 'D', 'A'); //MIDi Axis

        #region InputControls
        [InputControl(name = "AxisNote000", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote001", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote002", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote003", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote004", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote005", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote006", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote007", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote008", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote009", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote010", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote011", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote012", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote013", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote014", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote015", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote016", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote017", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote018", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote019", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote020", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote021", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote022", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote023", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote024", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote025", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote026", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote027", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote028", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote029", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote030", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote031", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote032", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote033", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote034", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote035", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote036", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote037", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote038", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote039", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote040", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote041", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote042", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote043", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote044", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote045", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote046", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote047", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote048", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote049", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote050", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote051", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote052", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote053", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote054", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote055", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote056", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote057", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote058", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote059", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote060", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote061", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote062", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote063", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote064", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote065", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote066", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote067", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote068", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote069", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote070", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote071", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote072", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote073", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote074", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote075", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote076", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote077", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote078", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote079", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote080", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote081", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote082", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote083", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote084", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote085", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote086", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote087", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote088", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote089", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote090", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote091", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote092", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote093", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote094", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote095", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote096", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote097", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote098", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote099", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote100", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote101", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote102", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote103", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote104", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote105", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote106", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote107", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote108", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote109", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote110", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote111", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote112", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote113", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote114", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote115", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote116", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote117", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote118", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote119", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote120", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote121", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote122", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote123", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote124", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote125", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote126", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        [InputControl(name = "AxisNote127", layout = "Axis", offset = InputStateBlock.AutomaticOffset)]
        #endregion
        public fixed float __axisNote[128];

        public float this[byte note]
        {
            set
            {
                SetNote(note, value);
            }
            get
            {
                return GetNote(note);
            }
        }

        public float GetNote(byte note) { return __axisNote[note]; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="note">Note Number</param>
        /// <param name="value">Velocity(NoteOff: -1.0f to 0.0f, NoteOn 0.0f to 1.0f)</param>
        public void SetNote(byte note, float value) { __axisNote[note] = value; }
    }
}