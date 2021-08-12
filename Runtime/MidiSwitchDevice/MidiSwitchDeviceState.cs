using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace Minis.Runtime.MidiSwitchDevice
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]   //Size : in Byte
    public unsafe struct MidiSwitchDeviceState : IInputStateTypeInfo
    {
        [InputControl(name = "KeyNote000", layout = "Button", bit = 0, displayName = "KeyNote000")]
        [InputControl(name = "KeyNote001", layout = "Button", bit = 1, displayName = "KeyNote001")]
        [InputControl(name = "KeyNote002", layout = "Button", bit = 2, displayName = "KeyNote002")]
        [InputControl(name = "KeyNote003", layout = "Button", bit = 3, displayName = "KeyNote003")]
        [InputControl(name = "KeyNote004", layout = "Button", bit = 4, displayName = "KeyNote004")]
        [InputControl(name = "KeyNote005", layout = "Button", bit = 5, displayName = "KeyNote005")]
        [InputControl(name = "KeyNote006", layout = "Button", bit = 6, displayName = "KeyNote006")]
        [InputControl(name = "KeyNote007", layout = "Button", bit = 7, displayName = "KeyNote007")]
        [InputControl(name = "KeyNote008", layout = "Button", bit = 8, displayName = "KeyNote008")]
        [InputControl(name = "KeyNote009", layout = "Button", bit = 9, displayName = "KeyNote009")]
        [InputControl(name = "KeyNote010", layout = "Button", bit = 10, displayName = "KeyNote010")]
        [InputControl(name = "KeyNote011", layout = "Button", bit = 11, displayName = "KeyNote011")]
        [InputControl(name = "KeyNote012", layout = "Button", bit = 12, displayName = "KeyNote012")]
        [InputControl(name = "KeyNote013", layout = "Button", bit = 13, displayName = "KeyNote013")]
        [InputControl(name = "KeyNote014", layout = "Button", bit = 14, displayName = "KeyNote014")]
        [InputControl(name = "KeyNote015", layout = "Button", bit = 15, displayName = "KeyNote015")]
        [InputControl(name = "KeyNote016", layout = "Button", bit = 16, displayName = "KeyNote016")]
        [InputControl(name = "KeyNote017", layout = "Button", bit = 17, displayName = "KeyNote017")]
        [InputControl(name = "KeyNote018", layout = "Button", bit = 18, displayName = "KeyNote018")]
        [InputControl(name = "KeyNote019", layout = "Button", bit = 19, displayName = "KeyNote019")]
        [InputControl(name = "KeyNote020", layout = "Button", bit = 20, displayName = "KeyNote020")]
        [InputControl(name = "KeyNote021", layout = "Button", bit = 21, displayName = "KeyNote021")]
        [InputControl(name = "KeyNote022", layout = "Button", bit = 22, displayName = "KeyNote022")]
        [InputControl(name = "KeyNote023", layout = "Button", bit = 23, displayName = "KeyNote023")]
        [InputControl(name = "KeyNote024", layout = "Button", bit = 24, displayName = "KeyNote024")]
        [InputControl(name = "KeyNote025", layout = "Button", bit = 25, displayName = "KeyNote025")]
        [InputControl(name = "KeyNote026", layout = "Button", bit = 26, displayName = "KeyNote026")]
        [InputControl(name = "KeyNote027", layout = "Button", bit = 27, displayName = "KeyNote027")]
        [InputControl(name = "KeyNote028", layout = "Button", bit = 28, displayName = "KeyNote028")]
        [InputControl(name = "KeyNote029", layout = "Button", bit = 29, displayName = "KeyNote029")]
        [InputControl(name = "KeyNote030", layout = "Button", bit = 30, displayName = "KeyNote030")]
        [InputControl(name = "KeyNote031", layout = "Button", bit = 31, displayName = "KeyNote031")]
        [InputControl(name = "KeyNote032", layout = "Button", bit = 32, displayName = "KeyNote032")]
        [InputControl(name = "KeyNote033", layout = "Button", bit = 33, displayName = "KeyNote033")]
        [InputControl(name = "KeyNote034", layout = "Button", bit = 34, displayName = "KeyNote034")]
        [InputControl(name = "KeyNote035", layout = "Button", bit = 35, displayName = "KeyNote035")]
        [InputControl(name = "KeyNote036", layout = "Button", bit = 36, displayName = "KeyNote036")]
        [InputControl(name = "KeyNote037", layout = "Button", bit = 37, displayName = "KeyNote037")]
        [InputControl(name = "KeyNote038", layout = "Button", bit = 38, displayName = "KeyNote038")]
        [InputControl(name = "KeyNote039", layout = "Button", bit = 39, displayName = "KeyNote039")]
        [InputControl(name = "KeyNote040", layout = "Button", bit = 40, displayName = "KeyNote040")]
        [InputControl(name = "KeyNote041", layout = "Button", bit = 41, displayName = "KeyNote041")]
        [InputControl(name = "KeyNote042", layout = "Button", bit = 42, displayName = "KeyNote042")]
        [InputControl(name = "KeyNote043", layout = "Button", bit = 43, displayName = "KeyNote043")]
        [InputControl(name = "KeyNote044", layout = "Button", bit = 44, displayName = "KeyNote044")]
        [InputControl(name = "KeyNote045", layout = "Button", bit = 45, displayName = "KeyNote045")]
        [InputControl(name = "KeyNote046", layout = "Button", bit = 46, displayName = "KeyNote046")]
        [InputControl(name = "KeyNote047", layout = "Button", bit = 47, displayName = "KeyNote047")]
        [InputControl(name = "KeyNote048", layout = "Button", bit = 48, displayName = "KeyNote048")]
        [InputControl(name = "KeyNote049", layout = "Button", bit = 49, displayName = "KeyNote049")]
        [InputControl(name = "KeyNote050", layout = "Button", bit = 50, displayName = "KeyNote050")]
        [InputControl(name = "KeyNote051", layout = "Button", bit = 51, displayName = "KeyNote051")]
        [InputControl(name = "KeyNote052", layout = "Button", bit = 52, displayName = "KeyNote052")]
        [InputControl(name = "KeyNote053", layout = "Button", bit = 53, displayName = "KeyNote053")]
        [InputControl(name = "KeyNote054", layout = "Button", bit = 54, displayName = "KeyNote054")]
        [InputControl(name = "KeyNote055", layout = "Button", bit = 55, displayName = "KeyNote055")]
        [InputControl(name = "KeyNote056", layout = "Button", bit = 56, displayName = "KeyNote056")]
        [InputControl(name = "KeyNote057", layout = "Button", bit = 57, displayName = "KeyNote057")]
        [InputControl(name = "KeyNote058", layout = "Button", bit = 58, displayName = "KeyNote058")]
        [InputControl(name = "KeyNote059", layout = "Button", bit = 59, displayName = "KeyNote059")]
        [InputControl(name = "KeyNote060", layout = "Button", bit = 60, displayName = "KeyNote060")]
        [InputControl(name = "KeyNote061", layout = "Button", bit = 61, displayName = "KeyNote061")]
        [InputControl(name = "KeyNote062", layout = "Button", bit = 62, displayName = "KeyNote062")]
        [InputControl(name = "KeyNote063", layout = "Button", bit = 63, displayName = "KeyNote063")]
        [InputControl(name = "KeyNote064", layout = "Button", bit = 64, displayName = "KeyNote064")]
        [InputControl(name = "KeyNote065", layout = "Button", bit = 65, displayName = "KeyNote065")]
        [InputControl(name = "KeyNote066", layout = "Button", bit = 66, displayName = "KeyNote066")]
        [InputControl(name = "KeyNote067", layout = "Button", bit = 67, displayName = "KeyNote067")]
        [InputControl(name = "KeyNote068", layout = "Button", bit = 68, displayName = "KeyNote068")]
        [InputControl(name = "KeyNote069", layout = "Button", bit = 69, displayName = "KeyNote069")]
        [InputControl(name = "KeyNote070", layout = "Button", bit = 70, displayName = "KeyNote070")]
        [InputControl(name = "KeyNote071", layout = "Button", bit = 71, displayName = "KeyNote071")]
        [InputControl(name = "KeyNote072", layout = "Button", bit = 72, displayName = "KeyNote072")]
        [InputControl(name = "KeyNote073", layout = "Button", bit = 73, displayName = "KeyNote073")]
        [InputControl(name = "KeyNote074", layout = "Button", bit = 74, displayName = "KeyNote074")]
        [InputControl(name = "KeyNote075", layout = "Button", bit = 75, displayName = "KeyNote075")]
        [InputControl(name = "KeyNote076", layout = "Button", bit = 76, displayName = "KeyNote076")]
        [InputControl(name = "KeyNote077", layout = "Button", bit = 77, displayName = "KeyNote077")]
        [InputControl(name = "KeyNote078", layout = "Button", bit = 78, displayName = "KeyNote078")]
        [InputControl(name = "KeyNote079", layout = "Button", bit = 79, displayName = "KeyNote079")]
        [InputControl(name = "KeyNote080", layout = "Button", bit = 80, displayName = "KeyNote080")]
        [InputControl(name = "KeyNote081", layout = "Button", bit = 81, displayName = "KeyNote081")]
        [InputControl(name = "KeyNote082", layout = "Button", bit = 82, displayName = "KeyNote082")]
        [InputControl(name = "KeyNote083", layout = "Button", bit = 83, displayName = "KeyNote083")]
        [InputControl(name = "KeyNote084", layout = "Button", bit = 84, displayName = "KeyNote084")]
        [InputControl(name = "KeyNote085", layout = "Button", bit = 85, displayName = "KeyNote085")]
        [InputControl(name = "KeyNote086", layout = "Button", bit = 86, displayName = "KeyNote086")]
        [InputControl(name = "KeyNote087", layout = "Button", bit = 87, displayName = "KeyNote087")]
        [InputControl(name = "KeyNote088", layout = "Button", bit = 88, displayName = "KeyNote088")]
        [InputControl(name = "KeyNote089", layout = "Button", bit = 89, displayName = "KeyNote089")]
        [InputControl(name = "KeyNote090", layout = "Button", bit = 90, displayName = "KeyNote090")]
        [InputControl(name = "KeyNote091", layout = "Button", bit = 91, displayName = "KeyNote091")]
        [InputControl(name = "KeyNote092", layout = "Button", bit = 92, displayName = "KeyNote092")]
        [InputControl(name = "KeyNote093", layout = "Button", bit = 93, displayName = "KeyNote093")]
        [InputControl(name = "KeyNote094", layout = "Button", bit = 94, displayName = "KeyNote094")]
        [InputControl(name = "KeyNote095", layout = "Button", bit = 95, displayName = "KeyNote095")]
        [InputControl(name = "KeyNote096", layout = "Button", bit = 96, displayName = "KeyNote096")]
        [InputControl(name = "KeyNote097", layout = "Button", bit = 97, displayName = "KeyNote097")]
        [InputControl(name = "KeyNote098", layout = "Button", bit = 98, displayName = "KeyNote098")]
        [InputControl(name = "KeyNote099", layout = "Button", bit = 99, displayName = "KeyNote099")]
        [InputControl(name = "KeyNote100", layout = "Button", bit = 100, displayName = "KeyNote100")]
        [InputControl(name = "KeyNote101", layout = "Button", bit = 101, displayName = "KeyNote101")]
        [InputControl(name = "KeyNote102", layout = "Button", bit = 102, displayName = "KeyNote102")]
        [InputControl(name = "KeyNote103", layout = "Button", bit = 103, displayName = "KeyNote103")]
        [InputControl(name = "KeyNote104", layout = "Button", bit = 104, displayName = "KeyNote104")]
        [InputControl(name = "KeyNote105", layout = "Button", bit = 105, displayName = "KeyNote105")]
        [InputControl(name = "KeyNote106", layout = "Button", bit = 106, displayName = "KeyNote106")]
        [InputControl(name = "KeyNote107", layout = "Button", bit = 107, displayName = "KeyNote107")]
        [InputControl(name = "KeyNote108", layout = "Button", bit = 108, displayName = "KeyNote108")]
        [InputControl(name = "KeyNote109", layout = "Button", bit = 109, displayName = "KeyNote109")]
        [InputControl(name = "KeyNote110", layout = "Button", bit = 110, displayName = "KeyNote110")]
        [InputControl(name = "KeyNote111", layout = "Button", bit = 111, displayName = "KeyNote111")]
        [InputControl(name = "KeyNote112", layout = "Button", bit = 112, displayName = "KeyNote112")]
        [InputControl(name = "KeyNote113", layout = "Button", bit = 113, displayName = "KeyNote113")]
        [InputControl(name = "KeyNote114", layout = "Button", bit = 114, displayName = "KeyNote114")]
        [InputControl(name = "KeyNote115", layout = "Button", bit = 115, displayName = "KeyNote115")]
        [InputControl(name = "KeyNote116", layout = "Button", bit = 116, displayName = "KeyNote116")]
        [InputControl(name = "KeyNote117", layout = "Button", bit = 117, displayName = "KeyNote117")]
        [InputControl(name = "KeyNote118", layout = "Button", bit = 118, displayName = "KeyNote118")]
        [InputControl(name = "KeyNote119", layout = "Button", bit = 119, displayName = "KeyNote119")]
        [InputControl(name = "KeyNote120", layout = "Button", bit = 120, displayName = "KeyNote120")]
        [InputControl(name = "KeyNote121", layout = "Button", bit = 121, displayName = "KeyNote121")]
        [InputControl(name = "KeyNote122", layout = "Button", bit = 122, displayName = "KeyNote122")]
        [InputControl(name = "KeyNote123", layout = "Button", bit = 123, displayName = "KeyNote123")]
        [InputControl(name = "KeyNote124", layout = "Button", bit = 124, displayName = "KeyNote124")]
        [InputControl(name = "KeyNote125", layout = "Button", bit = 125, displayName = "KeyNote125")]
        [InputControl(name = "KeyNote126", layout = "Button", bit = 126, displayName = "KeyNote126")]
        [InputControl(name = "KeyNote127", layout = "Button", bit = 127, displayName = "KeyNote127")]
        [FieldOffset(0)]
        public fixed int buttons[4];

        public FourCC format => new FourCC('M', 'I', 'D', 'K'); //MIDi Key


        public void SetNoteOn(byte note)
        {
            buttons[note >> 5] |= 0x0001 << (note & 0b00011111);
        }

        public void SetNoteOff(byte note)
        {
            buttons[note >> 5] &= ~(0x0001 << (note & 0b00011111));
        }

        public void SetNote(byte note, bool on)
        {
            if (on)
                SetNoteOn(note);
            else
                SetNoteOff(note);
        }

        public bool GetNote(byte note)
        {
            return (buttons[note >> 5] & (0x0001 << (note & 0b00011111))) != 0;
        }

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
    }
}