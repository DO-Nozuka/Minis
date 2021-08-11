using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace Minis.Runtime.MidiSwitchDevice
{
    public unsafe struct MidiSwitchDeviceState : IInputStateTypeInfo
    {
        private const int kSizeInBits = 128;
        internal const int kSizeInBytes = (kSizeInBits + 7) / 8;

        #region InputControls
        [InputControl(name = "KeyNote000", layout = "Key", bit = 0)]
        [InputControl(name = "KeyNote001", layout = "Key", bit = 1)]
        [InputControl(name = "KeyNote002", layout = "Key", bit = 2)]
        [InputControl(name = "KeyNote003", layout = "Key", bit = 3)]
        [InputControl(name = "KeyNote004", layout = "Key", bit = 4)]
        [InputControl(name = "KeyNote005", layout = "Key", bit = 5)]
        [InputControl(name = "KeyNote006", layout = "Key", bit = 6)]
        [InputControl(name = "KeyNote007", layout = "Key", bit = 7)]
        [InputControl(name = "KeyNote008", layout = "Key", bit = 8)]
        [InputControl(name = "KeyNote009", layout = "Key", bit = 9)]
        [InputControl(name = "KeyNote010", layout = "Key", bit = 10)]
        [InputControl(name = "KeyNote011", layout = "Key", bit = 11)]
        [InputControl(name = "KeyNote012", layout = "Key", bit = 12)]
        [InputControl(name = "KeyNote013", layout = "Key", bit = 13)]
        [InputControl(name = "KeyNote014", layout = "Key", bit = 14)]
        [InputControl(name = "KeyNote015", layout = "Key", bit = 15)]
        [InputControl(name = "KeyNote016", layout = "Key", bit = 16)]
        [InputControl(name = "KeyNote017", layout = "Key", bit = 17)]
        [InputControl(name = "KeyNote018", layout = "Key", bit = 18)]
        [InputControl(name = "KeyNote019", layout = "Key", bit = 19)]
        [InputControl(name = "KeyNote020", layout = "Key", bit = 20)]
        [InputControl(name = "KeyNote021", layout = "Key", bit = 21)]
        [InputControl(name = "KeyNote022", layout = "Key", bit = 22)]
        [InputControl(name = "KeyNote023", layout = "Key", bit = 23)]
        [InputControl(name = "KeyNote024", layout = "Key", bit = 24)]
        [InputControl(name = "KeyNote025", layout = "Key", bit = 25)]
        [InputControl(name = "KeyNote026", layout = "Key", bit = 26)]
        [InputControl(name = "KeyNote027", layout = "Key", bit = 27)]
        [InputControl(name = "KeyNote028", layout = "Key", bit = 28)]
        [InputControl(name = "KeyNote029", layout = "Key", bit = 29)]
        [InputControl(name = "KeyNote030", layout = "Key", bit = 30)]
        [InputControl(name = "KeyNote031", layout = "Key", bit = 31)]
        [InputControl(name = "KeyNote032", layout = "Key", bit = 32)]
        [InputControl(name = "KeyNote033", layout = "Key", bit = 33)]
        [InputControl(name = "KeyNote034", layout = "Key", bit = 34)]
        [InputControl(name = "KeyNote035", layout = "Key", bit = 35)]
        [InputControl(name = "KeyNote036", layout = "Key", bit = 36)]
        [InputControl(name = "KeyNote037", layout = "Key", bit = 37)]
        [InputControl(name = "KeyNote038", layout = "Key", bit = 38)]
        [InputControl(name = "KeyNote039", layout = "Key", bit = 39)]
        [InputControl(name = "KeyNote040", layout = "Key", bit = 40)]
        [InputControl(name = "KeyNote041", layout = "Key", bit = 41)]
        [InputControl(name = "KeyNote042", layout = "Key", bit = 42)]
        [InputControl(name = "KeyNote043", layout = "Key", bit = 43)]
        [InputControl(name = "KeyNote044", layout = "Key", bit = 44)]
        [InputControl(name = "KeyNote045", layout = "Key", bit = 45)]
        [InputControl(name = "KeyNote046", layout = "Key", bit = 46)]
        [InputControl(name = "KeyNote047", layout = "Key", bit = 47)]
        [InputControl(name = "KeyNote048", layout = "Key", bit = 48)]
        [InputControl(name = "KeyNote049", layout = "Key", bit = 49)]
        [InputControl(name = "KeyNote050", layout = "Key", bit = 50)]
        [InputControl(name = "KeyNote051", layout = "Key", bit = 51)]
        [InputControl(name = "KeyNote052", layout = "Key", bit = 52)]
        [InputControl(name = "KeyNote053", layout = "Key", bit = 53)]
        [InputControl(name = "KeyNote054", layout = "Key", bit = 54)]
        [InputControl(name = "KeyNote055", layout = "Key", bit = 55)]
        [InputControl(name = "KeyNote056", layout = "Key", bit = 56)]
        [InputControl(name = "KeyNote057", layout = "Key", bit = 57)]
        [InputControl(name = "KeyNote058", layout = "Key", bit = 58)]
        [InputControl(name = "KeyNote059", layout = "Key", bit = 59)]
        [InputControl(name = "KeyNote060", layout = "Key", bit = 60)]
        [InputControl(name = "KeyNote061", layout = "Key", bit = 61)]
        [InputControl(name = "KeyNote062", layout = "Key", bit = 62)]
        [InputControl(name = "KeyNote063", layout = "Key", bit = 63)]
        [InputControl(name = "KeyNote064", layout = "Key", bit = 64)]
        [InputControl(name = "KeyNote065", layout = "Key", bit = 65)]
        [InputControl(name = "KeyNote066", layout = "Key", bit = 66)]
        [InputControl(name = "KeyNote067", layout = "Key", bit = 67)]
        [InputControl(name = "KeyNote068", layout = "Key", bit = 68)]
        [InputControl(name = "KeyNote069", layout = "Key", bit = 69)]
        [InputControl(name = "KeyNote070", layout = "Key", bit = 70)]
        [InputControl(name = "KeyNote071", layout = "Key", bit = 71)]
        [InputControl(name = "KeyNote072", layout = "Key", bit = 72)]
        [InputControl(name = "KeyNote073", layout = "Key", bit = 73)]
        [InputControl(name = "KeyNote074", layout = "Key", bit = 74)]
        [InputControl(name = "KeyNote075", layout = "Key", bit = 75)]
        [InputControl(name = "KeyNote076", layout = "Key", bit = 76)]
        [InputControl(name = "KeyNote077", layout = "Key", bit = 77)]
        [InputControl(name = "KeyNote078", layout = "Key", bit = 78)]
        [InputControl(name = "KeyNote079", layout = "Key", bit = 79)]
        [InputControl(name = "KeyNote080", layout = "Key", bit = 80)]
        [InputControl(name = "KeyNote081", layout = "Key", bit = 81)]
        [InputControl(name = "KeyNote082", layout = "Key", bit = 82)]
        [InputControl(name = "KeyNote083", layout = "Key", bit = 83)]
        [InputControl(name = "KeyNote084", layout = "Key", bit = 84)]
        [InputControl(name = "KeyNote085", layout = "Key", bit = 85)]
        [InputControl(name = "KeyNote086", layout = "Key", bit = 86)]
        [InputControl(name = "KeyNote087", layout = "Key", bit = 87)]
        [InputControl(name = "KeyNote088", layout = "Key", bit = 88)]
        [InputControl(name = "KeyNote089", layout = "Key", bit = 89)]
        [InputControl(name = "KeyNote090", layout = "Key", bit = 90)]
        [InputControl(name = "KeyNote091", layout = "Key", bit = 91)]
        [InputControl(name = "KeyNote092", layout = "Key", bit = 92)]
        [InputControl(name = "KeyNote093", layout = "Key", bit = 93)]
        [InputControl(name = "KeyNote094", layout = "Key", bit = 94)]
        [InputControl(name = "KeyNote095", layout = "Key", bit = 95)]
        [InputControl(name = "KeyNote096", layout = "Key", bit = 96)]
        [InputControl(name = "KeyNote097", layout = "Key", bit = 97)]
        [InputControl(name = "KeyNote098", layout = "Key", bit = 98)]
        [InputControl(name = "KeyNote099", layout = "Key", bit = 99)]
        [InputControl(name = "KeyNote100", layout = "Key", bit = 100)]
        [InputControl(name = "KeyNote101", layout = "Key", bit = 101)]
        [InputControl(name = "KeyNote102", layout = "Key", bit = 102)]
        [InputControl(name = "KeyNote103", layout = "Key", bit = 103)]
        [InputControl(name = "KeyNote104", layout = "Key", bit = 104)]
        [InputControl(name = "KeyNote105", layout = "Key", bit = 105)]
        [InputControl(name = "KeyNote106", layout = "Key", bit = 106)]
        [InputControl(name = "KeyNote107", layout = "Key", bit = 107)]
        [InputControl(name = "KeyNote108", layout = "Key", bit = 108)]
        [InputControl(name = "KeyNote109", layout = "Key", bit = 109)]
        [InputControl(name = "KeyNote110", layout = "Key", bit = 110)]
        [InputControl(name = "KeyNote111", layout = "Key", bit = 111)]
        [InputControl(name = "KeyNote112", layout = "Key", bit = 112)]
        [InputControl(name = "KeyNote113", layout = "Key", bit = 113)]
        [InputControl(name = "KeyNote114", layout = "Key", bit = 114)]
        [InputControl(name = "KeyNote115", layout = "Key", bit = 115)]
        [InputControl(name = "KeyNote116", layout = "Key", bit = 116)]
        [InputControl(name = "KeyNote117", layout = "Key", bit = 117)]
        [InputControl(name = "KeyNote118", layout = "Key", bit = 118)]
        [InputControl(name = "KeyNote119", layout = "Key", bit = 119)]
        [InputControl(name = "KeyNote120", layout = "Key", bit = 120)]
        [InputControl(name = "KeyNote121", layout = "Key", bit = 121)]
        [InputControl(name = "KeyNote122", layout = "Key", bit = 122)]
        [InputControl(name = "KeyNote123", layout = "Key", bit = 123)]
        [InputControl(name = "KeyNote124", layout = "Key", bit = 124)]
        [InputControl(name = "KeyNote125", layout = "Key", bit = 125)]
        [InputControl(name = "KeyNote126", layout = "Key", bit = 126)]
        [InputControl(name = "KeyNote127", layout = "Key", bit = 127)]
        #endregion

        public FourCC format => new FourCC('M', 'I', 'D', 'S'); //MIDi Switch
        private fixed byte _keyNotes[kSizeInBytes];

        #region Methods
        public void NoteOn(byte key)
        {
            Set(key, true);
        }

        public void NoteOff(byte key)
        {
            Set(key, false);
        }

        private void Set(byte key, bool state)
        {
            fixed (byte* keysPtr = _keyNotes)
            {
                WriteSingleBit(keysPtr, key, state);
            }
        }

        private static void WriteSingleBit(void* ptr, uint bitOffset, bool value)
        {
            if (bitOffset < 8)
            {
                if (value)
                    *(byte*)ptr |= (byte)(1 << (int)bitOffset);
                else
                    *(byte*)ptr &= (byte)~(1 << (int)bitOffset);
            }
            else if (bitOffset < 32)
            {
                if (value)
                    *(int*)ptr |= 1 << (int)bitOffset;
                else
                    *(int*)ptr &= ~(1 << (int)bitOffset);
            }
            else
            {
                var byteOffset = bitOffset / 8;
                bitOffset %= 8;

                if (value)
                    *((byte*)ptr + byteOffset) |= (byte)(1 << (int)bitOffset);
                else
                    *((byte*)ptr + byteOffset) &= (byte)~(1 << (int)bitOffset);
            }
        }
        #endregion
    }

}