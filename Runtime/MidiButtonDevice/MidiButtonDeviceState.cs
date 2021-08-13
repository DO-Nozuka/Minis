using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace Minis.Runtime.MidiButtonDevice
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]   //Size : in Byte Note:16, Pitch:4, AnyNote:4 
    public unsafe struct MidiButtonDeviceState : IInputStateTypeInfo
    {
        //__buttons[0]
        [InputControl(name = "BtnNote000", layout = "Button", bit = 0, displayName = "BtnNote000")]
        [InputControl(name = "BtnNote001", layout = "Button", bit = 1, displayName = "BtnNote001")]
        [InputControl(name = "BtnNote002", layout = "Button", bit = 2, displayName = "BtnNote002")]
        [InputControl(name = "BtnNote003", layout = "Button", bit = 3, displayName = "BtnNote003")]
        [InputControl(name = "BtnNote004", layout = "Button", bit = 4, displayName = "BtnNote004")]
        [InputControl(name = "BtnNote005", layout = "Button", bit = 5, displayName = "BtnNote005")]
        [InputControl(name = "BtnNote006", layout = "Button", bit = 6, displayName = "BtnNote006")]
        [InputControl(name = "BtnNote007", layout = "Button", bit = 7, displayName = "BtnNote007")]
        [InputControl(name = "BtnNote008", layout = "Button", bit = 8, displayName = "BtnNote008")]
        [InputControl(name = "BtnNote009", layout = "Button", bit = 9, displayName = "BtnNote009")]
        [InputControl(name = "BtnNote010", layout = "Button", bit = 10, displayName = "BtnNote010")]
        [InputControl(name = "BtnNote011", layout = "Button", bit = 11, displayName = "BtnNote011")]
        [InputControl(name = "BtnNote012", layout = "Button", bit = 12, displayName = "BtnNote012")]
        [InputControl(name = "BtnNote013", layout = "Button", bit = 13, displayName = "BtnNote013")]
        [InputControl(name = "BtnNote014", layout = "Button", bit = 14, displayName = "BtnNote014")]
        [InputControl(name = "BtnNote015", layout = "Button", bit = 15, displayName = "BtnNote015")]
        [InputControl(name = "BtnNote016", layout = "Button", bit = 16, displayName = "BtnNote016")]
        [InputControl(name = "BtnNote017", layout = "Button", bit = 17, displayName = "BtnNote017")]
        [InputControl(name = "BtnNote018", layout = "Button", bit = 18, displayName = "BtnNote018")]
        [InputControl(name = "BtnNote019", layout = "Button", bit = 19, displayName = "BtnNote019")]
        [InputControl(name = "BtnNote020", layout = "Button", bit = 20, displayName = "BtnNote020")]
        [InputControl(name = "BtnNote021", layout = "Button", bit = 21, displayName = "BtnNote021")]
        [InputControl(name = "BtnNote022", layout = "Button", bit = 22, displayName = "BtnNote022")]
        [InputControl(name = "BtnNote023", layout = "Button", bit = 23, displayName = "BtnNote023")]
        [InputControl(name = "BtnNote024", layout = "Button", bit = 24, displayName = "BtnNote024")]
        [InputControl(name = "BtnNote025", layout = "Button", bit = 25, displayName = "BtnNote025")]
        [InputControl(name = "BtnNote026", layout = "Button", bit = 26, displayName = "BtnNote026")]
        [InputControl(name = "BtnNote027", layout = "Button", bit = 27, displayName = "BtnNote027")]
        [InputControl(name = "BtnNote028", layout = "Button", bit = 28, displayName = "BtnNote028")]
        [InputControl(name = "BtnNote029", layout = "Button", bit = 29, displayName = "BtnNote029")]
        [InputControl(name = "BtnNote030", layout = "Button", bit = 30, displayName = "BtnNote030")]
        [InputControl(name = "BtnNote031", layout = "Button", bit = 31, displayName = "BtnNote031")]
        //__buttons[1]
        [InputControl(name = "BtnNote032", layout = "Button", bit = 32, displayName = "BtnNote032")]
        [InputControl(name = "BtnNote033", layout = "Button", bit = 33, displayName = "BtnNote033")]
        [InputControl(name = "BtnNote034", layout = "Button", bit = 34, displayName = "BtnNote034")]
        [InputControl(name = "BtnNote035", layout = "Button", bit = 35, displayName = "BtnNote035")]
        [InputControl(name = "BtnNote036", layout = "Button", bit = 36, displayName = "BtnNote036")]
        [InputControl(name = "BtnNote037", layout = "Button", bit = 37, displayName = "BtnNote037")]
        [InputControl(name = "BtnNote038", layout = "Button", bit = 38, displayName = "BtnNote038")]
        [InputControl(name = "BtnNote039", layout = "Button", bit = 39, displayName = "BtnNote039")]
        [InputControl(name = "BtnNote040", layout = "Button", bit = 40, displayName = "BtnNote040")]
        [InputControl(name = "BtnNote041", layout = "Button", bit = 41, displayName = "BtnNote041")]
        [InputControl(name = "BtnNote042", layout = "Button", bit = 42, displayName = "BtnNote042")]
        [InputControl(name = "BtnNote043", layout = "Button", bit = 43, displayName = "BtnNote043")]
        [InputControl(name = "BtnNote044", layout = "Button", bit = 44, displayName = "BtnNote044")]
        [InputControl(name = "BtnNote045", layout = "Button", bit = 45, displayName = "BtnNote045")]
        [InputControl(name = "BtnNote046", layout = "Button", bit = 46, displayName = "BtnNote046")]
        [InputControl(name = "BtnNote047", layout = "Button", bit = 47, displayName = "BtnNote047")]
        [InputControl(name = "BtnNote048", layout = "Button", bit = 48, displayName = "BtnNote048")]
        [InputControl(name = "BtnNote049", layout = "Button", bit = 49, displayName = "BtnNote049")]
        [InputControl(name = "BtnNote050", layout = "Button", bit = 50, displayName = "BtnNote050")]
        [InputControl(name = "BtnNote051", layout = "Button", bit = 51, displayName = "BtnNote051")]
        [InputControl(name = "BtnNote052", layout = "Button", bit = 52, displayName = "BtnNote052")]
        [InputControl(name = "BtnNote053", layout = "Button", bit = 53, displayName = "BtnNote053")]
        [InputControl(name = "BtnNote054", layout = "Button", bit = 54, displayName = "BtnNote054")]
        [InputControl(name = "BtnNote055", layout = "Button", bit = 55, displayName = "BtnNote055")]
        [InputControl(name = "BtnNote056", layout = "Button", bit = 56, displayName = "BtnNote056")]
        [InputControl(name = "BtnNote057", layout = "Button", bit = 57, displayName = "BtnNote057")]
        [InputControl(name = "BtnNote058", layout = "Button", bit = 58, displayName = "BtnNote058")]
        [InputControl(name = "BtnNote059", layout = "Button", bit = 59, displayName = "BtnNote059")]
        [InputControl(name = "BtnNote060", layout = "Button", bit = 60, displayName = "BtnNote060")]
        [InputControl(name = "BtnNote061", layout = "Button", bit = 61, displayName = "BtnNote061")]
        [InputControl(name = "BtnNote062", layout = "Button", bit = 62, displayName = "BtnNote062")]
        [InputControl(name = "BtnNote063", layout = "Button", bit = 63, displayName = "BtnNote063")]
        //__buttons[2]
        [InputControl(name = "BtnNote064", layout = "Button", bit = 64, displayName = "BtnNote064")]
        [InputControl(name = "BtnNote065", layout = "Button", bit = 65, displayName = "BtnNote065")]
        [InputControl(name = "BtnNote066", layout = "Button", bit = 66, displayName = "BtnNote066")]
        [InputControl(name = "BtnNote067", layout = "Button", bit = 67, displayName = "BtnNote067")]
        [InputControl(name = "BtnNote068", layout = "Button", bit = 68, displayName = "BtnNote068")]
        [InputControl(name = "BtnNote069", layout = "Button", bit = 69, displayName = "BtnNote069")]
        [InputControl(name = "BtnNote070", layout = "Button", bit = 70, displayName = "BtnNote070")]
        [InputControl(name = "BtnNote071", layout = "Button", bit = 71, displayName = "BtnNote071")]
        [InputControl(name = "BtnNote072", layout = "Button", bit = 72, displayName = "BtnNote072")]
        [InputControl(name = "BtnNote073", layout = "Button", bit = 73, displayName = "BtnNote073")]
        [InputControl(name = "BtnNote074", layout = "Button", bit = 74, displayName = "BtnNote074")]
        [InputControl(name = "BtnNote075", layout = "Button", bit = 75, displayName = "BtnNote075")]
        [InputControl(name = "BtnNote076", layout = "Button", bit = 76, displayName = "BtnNote076")]
        [InputControl(name = "BtnNote077", layout = "Button", bit = 77, displayName = "BtnNote077")]
        [InputControl(name = "BtnNote078", layout = "Button", bit = 78, displayName = "BtnNote078")]
        [InputControl(name = "BtnNote079", layout = "Button", bit = 79, displayName = "BtnNote079")]
        [InputControl(name = "BtnNote080", layout = "Button", bit = 80, displayName = "BtnNote080")]
        [InputControl(name = "BtnNote081", layout = "Button", bit = 81, displayName = "BtnNote081")]
        [InputControl(name = "BtnNote082", layout = "Button", bit = 82, displayName = "BtnNote082")]
        [InputControl(name = "BtnNote083", layout = "Button", bit = 83, displayName = "BtnNote083")]
        [InputControl(name = "BtnNote084", layout = "Button", bit = 84, displayName = "BtnNote084")]
        [InputControl(name = "BtnNote085", layout = "Button", bit = 85, displayName = "BtnNote085")]
        [InputControl(name = "BtnNote086", layout = "Button", bit = 86, displayName = "BtnNote086")]
        [InputControl(name = "BtnNote087", layout = "Button", bit = 87, displayName = "BtnNote087")]
        [InputControl(name = "BtnNote088", layout = "Button", bit = 88, displayName = "BtnNote088")]
        [InputControl(name = "BtnNote089", layout = "Button", bit = 89, displayName = "BtnNote089")]
        [InputControl(name = "BtnNote090", layout = "Button", bit = 90, displayName = "BtnNote090")]
        [InputControl(name = "BtnNote091", layout = "Button", bit = 91, displayName = "BtnNote091")]
        [InputControl(name = "BtnNote092", layout = "Button", bit = 92, displayName = "BtnNote092")]
        [InputControl(name = "BtnNote093", layout = "Button", bit = 93, displayName = "BtnNote093")]
        [InputControl(name = "BtnNote094", layout = "Button", bit = 94, displayName = "BtnNote094")]
        [InputControl(name = "BtnNote095", layout = "Button", bit = 95, displayName = "BtnNote095")]
        //__buttons[3]
        [InputControl(name = "BtnNote096", layout = "Button", bit = 96, displayName = "BtnNote096")]
        [InputControl(name = "BtnNote097", layout = "Button", bit = 97, displayName = "BtnNote097")]
        [InputControl(name = "BtnNote098", layout = "Button", bit = 98, displayName = "BtnNote098")]
        [InputControl(name = "BtnNote099", layout = "Button", bit = 99, displayName = "BtnNote099")]
        [InputControl(name = "BtnNote100", layout = "Button", bit = 100, displayName = "BtnNote100")]
        [InputControl(name = "BtnNote101", layout = "Button", bit = 101, displayName = "BtnNote101")]
        [InputControl(name = "BtnNote102", layout = "Button", bit = 102, displayName = "BtnNote102")]
        [InputControl(name = "BtnNote103", layout = "Button", bit = 103, displayName = "BtnNote103")]
        [InputControl(name = "BtnNote104", layout = "Button", bit = 104, displayName = "BtnNote104")]
        [InputControl(name = "BtnNote105", layout = "Button", bit = 105, displayName = "BtnNote105")]
        [InputControl(name = "BtnNote106", layout = "Button", bit = 106, displayName = "BtnNote106")]
        [InputControl(name = "BtnNote107", layout = "Button", bit = 107, displayName = "BtnNote107")]
        [InputControl(name = "BtnNote108", layout = "Button", bit = 108, displayName = "BtnNote108")]
        [InputControl(name = "BtnNote109", layout = "Button", bit = 109, displayName = "BtnNote109")]
        [InputControl(name = "BtnNote110", layout = "Button", bit = 110, displayName = "BtnNote110")]
        [InputControl(name = "BtnNote111", layout = "Button", bit = 111, displayName = "BtnNote111")]
        [InputControl(name = "BtnNote112", layout = "Button", bit = 112, displayName = "BtnNote112")]
        [InputControl(name = "BtnNote113", layout = "Button", bit = 113, displayName = "BtnNote113")]
        [InputControl(name = "BtnNote114", layout = "Button", bit = 114, displayName = "BtnNote114")]
        [InputControl(name = "BtnNote115", layout = "Button", bit = 115, displayName = "BtnNote115")]
        [InputControl(name = "BtnNote116", layout = "Button", bit = 116, displayName = "BtnNote116")]
        [InputControl(name = "BtnNote117", layout = "Button", bit = 117, displayName = "BtnNote117")]
        [InputControl(name = "BtnNote118", layout = "Button", bit = 118, displayName = "BtnNote118")]
        [InputControl(name = "BtnNote119", layout = "Button", bit = 119, displayName = "BtnNote119")]
        [InputControl(name = "BtnNote120", layout = "Button", bit = 120, displayName = "BtnNote120")]
        [InputControl(name = "BtnNote121", layout = "Button", bit = 121, displayName = "BtnNote121")]
        [InputControl(name = "BtnNote122", layout = "Button", bit = 122, displayName = "BtnNote122")]
        [InputControl(name = "BtnNote123", layout = "Button", bit = 123, displayName = "BtnNote123")]
        [InputControl(name = "BtnNote124", layout = "Button", bit = 124, displayName = "BtnNote124")]
        [InputControl(name = "BtnNote125", layout = "Button", bit = 125, displayName = "BtnNote125")]
        [InputControl(name = "BtnNote126", layout = "Button", bit = 126, displayName = "BtnNote126")]
        [InputControl(name = "BtnNote127", layout = "Button", bit = 127, displayName = "BtnNote127")]
        //__buttons[4]
        [InputControl(name = "BtnPitchUp",      layout = "Button", bit = 0 + 128, displayName = "BtnPitchUp")]
        [InputControl(name = "BtnPitchDown", layout = "Button", bit = 1 + 128, displayName = "BtnPitchDown")]
        //[InputControl(name = "", layout = "Button", bit = 2 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 3 + 128, displayName = "")]
        [InputControl(name = "AnyBtnNote",      layout = "Button", bit = 4 + 128, displayName = "AnyBtnNote")]
        [InputControl(name = "AnyWhiteBtnNote", layout = "Button", bit = 5 + 128, displayName = "AnyWhiteBtnNote")]
        [InputControl(name = "AnyBlackBtnNote", layout = "Button", bit = 6 + 128, displayName = "AnyBlackBtnNote")]
        //[InputControl(name = "", layout = "Button", bit = 7 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 8 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 9 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 10 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 11 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 12 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 13 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 14 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 15 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 16 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 17 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 18 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 19 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 20 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 21 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 22 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 23 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 24 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 25 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 26 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 27 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 28 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 29 + 128, displayName = "")]
        //[InputControl(name = "", layout = "Button", bit = 30 + 128, displayName = "")]
        [InputControl(name = "None", layout = "Button", bit = 31 +128, displayName = "None")]
        [FieldOffset(0)]
        public fixed uint __buttons[5];

        public FourCC format => new FourCC('M', 'I', 'D', 'K'); //MIDi Key

        //Note
        public bool this[byte note]
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

        public bool GetNote(byte note) { return GetBit((byte)(note >> 5), (uint)0x0001 << (note & 0b00011111)); }
        public void SetNoteOn(byte note) {
            SetBit1((byte)(note >> 5), (uint)0x0001 << (note & 0b00011111));
            UpdateAnyNote();
        }
        public void SetNoteOff(byte note) {
            SetBit0((byte)(note >> 5), (uint)0x0001 << (note & 0b00011111));
            UpdateAnyNote();
        }
        public void SetNote(byte note, bool on) { if (on) SetNoteOn(note); else SetNoteOff(note); }

        //Pitch
        private byte _pitchUpIndex => 4;
        private byte _pitchDownIndex => 4;
        private uint _pitchUpBit     =>  0b0000_0000_0000_0000_0000_0000_0000_0001;
        private uint _pitchDownBit   =>  0b0000_0000_0000_0000_0000_0000_0000_0010;
        public bool GetPitchUp() { return GetBit(_pitchUpIndex, _pitchUpBit); }
        public bool GetPitchDown() { return GetBit(_pitchDownIndex, _pitchDownBit); }
        public bool GetPitch(bool up) { return up ? GetPitchUp() : GetPitchDown(); }
        public void SetPitchOn(bool up) { SetBit1(up ? _pitchUpIndex : _pitchDownIndex, up ? _pitchUpBit : _pitchDownBit); }
        public void SetPitchOff(bool up) { SetBit0(up ? _pitchUpIndex : _pitchDownIndex, up ? _pitchUpBit : _pitchDownBit); }
        public void SetPitch(bool up, bool on) { if (on) SetPitchOn(up); else SetPitchOff(up); }
        
        //Anynote(Change from SetNote)
        private byte _anyNoteIndex => 4;
        private uint _anyNoteBit => 0b0000_0000_0000_0000_0000_0000_0001_0000;  //(1 << 4)
        private uint _anyWhiteNoteMask0 => 0b1011_0101_1010_1011_0101_1010_1011_0101;
        private uint _anyWhiteNoteMask1 => 0b0101_1010_1011_0101_1010_1011_0101_1010;
        private uint _anyWhiteNoteMask2 => 0b1010_1011_0101_1010_1011_0101_1010_1011;
        private uint _anyWhiteNoteMask3 => 0b1011_0101_1010_1011_0101_1010_1011_0101;
        public bool GetAnyNote() { return GetBit(_anyNoteIndex, _anyNoteBit); }
        private void SetAnyNoteOn() { SetBit1(_anyNoteIndex, _anyNoteBit); }
        private void SetAnyNoteOff() { SetBit0(_anyNoteIndex, _anyNoteBit); }
        private void SetAnyNote(bool on) { if (on) SetAnyNoteOn(); else SetAnyNoteOff(); }
        private void UpdateAnyNote()
        {
            if (__buttons[0] != 0 
                || __buttons[1] !=0
                || __buttons[2] !=0
                || __buttons[3] !=0)
                SetAnyNoteOn();
            else
                SetAnyNoteOff();

            if ((__buttons[0] & _anyWhiteNoteMask0) != 0
                || (__buttons[1] & _anyWhiteNoteMask1) != 0
                || (__buttons[2] & _anyWhiteNoteMask2) != 0
                || (__buttons[3] & _anyWhiteNoteMask3) != 0
                )
                SetAnyWhiteNoteOn();
            else
                SetAnyWhiteNoteOff();

            if ((__buttons[0] & ~_anyWhiteNoteMask0) != 0
                || (__buttons[1] & ~_anyWhiteNoteMask1) != 0
                || (__buttons[2] & ~_anyWhiteNoteMask2) != 0
                || (__buttons[3] & ~_anyWhiteNoteMask3) != 0
                )
                SetAnyBlackNoteOn();
            else
                SetAnyBlackNoteOff();
        }

        //AnyWhiteNote(Change from SetNote)
        private byte _anyWhiteNoteIndex => 4;
        private uint _anyWhiteNoteBit => 0b0000_0000_0000_0000_0000_0000_0010_0000;//(1 << 5)
        public bool GetAnyWhiteNote() { return GetBit(_anyWhiteNoteIndex, _anyWhiteNoteBit); }
        public void SetAnyWhiteNoteOn() { SetBit1(_anyWhiteNoteIndex, _anyWhiteNoteBit); }
        public void SetAnyWhiteNoteOff() { SetBit0(_anyWhiteNoteIndex, _anyWhiteNoteBit); }
        public void SetAnyWhiteNote(bool on) { if (on) SetAnyWhiteNoteOn(); else SetAnyWhiteNoteOff(); }

        //AnyBlackNote(Change from SetNote)
        private byte _anyBlackNoteIndex => 4;
        private uint _anyBlackNoteBit => 0b0000_0000_0000_0000_0000_0000_0100_0000;//(1 << 6)
        public bool GetAnyBlackNote() { return GetBit(_anyBlackNoteIndex, _anyBlackNoteBit); }
        public void SetAnyBlackNoteOn() { SetBit1(_anyBlackNoteIndex, _anyBlackNoteBit); }
        public void SetAnyBlackNoteOff() { SetBit0(_anyBlackNoteIndex, _anyBlackNoteBit); }
        public void SetAnyBlackNote(bool on) { if (on) SetAnyBlackNoteOn(); else SetAnyBlackNoteOff(); }

        //Common Methods
        private bool GetBit(byte index, uint bit) { return (__buttons[index] & bit) != 0; }
        private void SetBit1(byte index, uint bit) { __buttons[index] |= bit; }
        private void SetBit0(byte index, uint bit) { __buttons[index] &= ~bit; }
    }
}