using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace Minis.Runtime.MidiAxisDevice
{
    [StructLayout(LayoutKind.Auto)]//, Size = 20)]   //Size : in Byte Note:16, Pitch:4, AnyNote:4 
    public unsafe struct MidiAxisDeviceState : IInputStateTypeInfo
    {
        public FourCC format => new FourCC('M', 'I', 'D', 'A'); //MIDi Axis

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
        public fixed float __axisNote[128];

        //Note
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
        public void SetNote(byte note, float value) { __axisNote[note] = value; }

        ////Pitch
        //private byte _pitchUpIndex => 4;
        //private byte _pitchDownIndex => 4;
        //private uint _pitchUpBit => 0b0000_0000_0000_0000_0000_0000_0000_0001;
        //private uint _pitchDownBit => 0b0000_0000_0000_0000_0000_0000_0000_0010;
        //public bool GetPitchUp() { return GetBit(_pitchUpIndex, _pitchUpBit); }
        //public bool GetPitchDown() { return GetBit(_pitchDownIndex, _pitchDownBit); }
        //public bool GetPitch(bool up) { return up ? GetPitchUp() : GetPitchDown(); }
        //public void SetPitchOn(bool up) { SetBit1(up ? _pitchUpIndex : _pitchDownIndex, up ? _pitchUpBit : _pitchDownBit); }
        //public void SetPitchOff(bool up) { SetBit0(up ? _pitchUpIndex : _pitchDownIndex, up ? _pitchUpBit : _pitchDownBit); }
        //public void SetPitch(bool up, bool on) { if (on) SetPitchOn(up); else SetPitchOff(up); }

        ////Anynote(Change from SetNote)
        //private byte _anyNoteIndex => 4;
        //private uint _anyNoteBit => 0b0000_0000_0000_0000_0000_0000_0001_0000;  //(1 << 4)
        //private uint _anyWhiteNoteMask0 => 0b1011_0101_1010_1011_0101_1010_1011_0101;
        //private uint _anyWhiteNoteMask1 => 0b0101_1010_1011_0101_1010_1011_0101_1010;
        //private uint _anyWhiteNoteMask2 => 0b1010_1011_0101_1010_1011_0101_1010_1011;
        //private uint _anyWhiteNoteMask3 => 0b1011_0101_1010_1011_0101_1010_1011_0101;
        //public bool GetAnyNote() { return GetBit(_anyNoteIndex, _anyNoteBit); }
        //private void SetAnyNoteOn() { SetBit1(_anyNoteIndex, _anyNoteBit); }
        //private void SetAnyNoteOff() { SetBit0(_anyNoteIndex, _anyNoteBit); }
        //private void SetAnyNote(bool on) { if (on) SetAnyNoteOn(); else SetAnyNoteOff(); }
        //private void UpdateAnyNote()
        //{
        //    if (__buttons[0] != 0
        //        || __buttons[1] != 0
        //        || __buttons[2] != 0
        //        || __buttons[3] != 0)
        //        SetAnyNoteOn();
        //    else
        //        SetAnyNoteOff();

        //    if ((__buttons[0] & _anyWhiteNoteMask0) != 0
        //        || (__buttons[1] & _anyWhiteNoteMask1) != 0
        //        || (__buttons[2] & _anyWhiteNoteMask2) != 0
        //        || (__buttons[3] & _anyWhiteNoteMask3) != 0
        //        )
        //        SetAnyWhiteNoteOn();
        //    else
        //        SetAnyWhiteNoteOff();

        //    if ((__buttons[0] & ~_anyWhiteNoteMask0) != 0
        //        || (__buttons[1] & ~_anyWhiteNoteMask1) != 0
        //        || (__buttons[2] & ~_anyWhiteNoteMask2) != 0
        //        || (__buttons[3] & ~_anyWhiteNoteMask3) != 0
        //        )
        //        SetAnyBlackNoteOn();
        //    else
        //        SetAnyBlackNoteOff();
        //}

        ////AnyWhiteNote(Change from SetNote)
        //private byte _anyWhiteNoteIndex => 4;
        //private uint _anyWhiteNoteBit => 0b0000_0000_0000_0000_0000_0000_0010_0000;//(1 << 5)
        //public bool GetAnyWhiteNote() { return GetBit(_anyWhiteNoteIndex, _anyWhiteNoteBit); }
        //public void SetAnyWhiteNoteOn() { SetBit1(_anyWhiteNoteIndex, _anyWhiteNoteBit); }
        //public void SetAnyWhiteNoteOff() { SetBit0(_anyWhiteNoteIndex, _anyWhiteNoteBit); }
        //public void SetAnyWhiteNote(bool on) { if (on) SetAnyWhiteNoteOn(); else SetAnyWhiteNoteOff(); }

        ////AnyBlackNote(Change from SetNote)
        //private byte _anyBlackNoteIndex => 4;
        //private uint _anyBlackNoteBit => 0b0000_0000_0000_0000_0000_0000_0100_0000;//(1 << 6)
        //public bool GetAnyBlackNote() { return GetBit(_anyBlackNoteIndex, _anyBlackNoteBit); }
        //public void SetAnyBlackNoteOn() { SetBit1(_anyBlackNoteIndex, _anyBlackNoteBit); }
        //public void SetAnyBlackNoteOff() { SetBit0(_anyBlackNoteIndex, _anyBlackNoteBit); }
        //public void SetAnyBlackNote(bool on) { if (on) SetAnyBlackNoteOn(); else SetAnyBlackNoteOff(); }

        ////Common Methods
        //private bool GetBit(byte index, uint bit) { return (__buttons[index] & bit) != 0; }
        //private void SetBit1(byte index, uint bit) { __buttons[index] |= bit; }
        //private void SetBit0(byte index, uint bit) { __buttons[index] &= ~bit; }

    }
}