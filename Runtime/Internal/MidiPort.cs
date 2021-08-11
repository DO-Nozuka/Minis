using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem;
using RtMidiDll = RtMidi.Unmanaged;
using Minis.Runtime.MidiSwitchDevice;

namespace Minis
{
    //
    // MIDI port class that manages an RtMidi input object and MIDI device
    // objects bound with each MIDI channel found in the port.
    //
    unsafe sealed class MidiPort : System.IDisposable
    {
        #region Internal objects and methods

        RtMidiDll.Wrapper* _rtmidi;
        string _portName;
        MidiDevice [] _channels = new MidiDevice[16];
        private MidiSwitchDevice _midiSwitchDevice = new MidiSwitchDevice(); 

        // Get a device object bound with a specified channel.
        // Create a new device if it doesn't exist.
        MidiDevice GetChannelDevice(int channel)
        {
            if (_channels[channel] == null)
            {
                var desc = new InputDeviceDescription {
                    interfaceName = "Minis",
                    deviceClass = "MIDI",
                    product = _portName + " Channel " + channel,
                    capabilities = "{\"channel\":" + channel + "}"
                };
                _channels[channel] = (MidiDevice)InputSystem.AddDevice(desc);
            }
            return _channels[channel];
        }

        #endregion

        #region Public methods

        public MidiPort(int portNumber, string portName)
        {
            _portName = portName;

            _rtmidi = RtMidiDll.InCreateDefault();

            if (_rtmidi == null || !_rtmidi->ok)
            {
                UnityEngine.Debug.LogWarning("Failed to create an RtMidi device object.");
                return;
            }

            RtMidiDll.OpenPort(_rtmidi, (uint)portNumber, "RtMidi Input");
        }

        ~MidiPort()
        {
            if (_rtmidi == null || !_rtmidi->ok) return;
            RtMidiDll.InFree(_rtmidi);
        }

        public void Dispose()
        {
            if (_rtmidi == null || !_rtmidi->ok) return;

            RtMidiDll.InFree(_rtmidi);
            _rtmidi = null;

            foreach (var dev in _channels)
                if (dev != null) InputSystem.RemoveDevice(dev);

            System.GC.SuppressFinalize(this);
        }

        public void ProcessMessageQueue()
        {
            if (_rtmidi == null || !_rtmidi->ok) return;

            while (true)
            {
                var size = 4ul;
                var message = stackalloc byte [(int)size];

                var stamp = RtMidiDll.InGetMessage(_rtmidi, message, ref size);
                if (size == 0) break;

                var status = message[0] >> 4;
                var channel = (byte)(message[0] & 0x0f);
                var data1 = message[1];
                var data2 = message[2];

                if (data1 > 0x7f || data2 > 0x7f) continue; // Invalid data

                var noteOn = status == 9 && data2 != 0;
                var noteOff = (status == 8) || (status == 9 && data2 == 0);

                if (noteOn && size == 3)
                {
                    GetChannelDevice(channel).ProcessNoteOn(message[0], message[1], message[2]);
                }
                else if (noteOff && size == 3)
                {
                    message[0] = (byte)(0x80 + channel);    //0x9n vel=0 => 0x8n vel=0�B
                    GetChannelDevice(channel).ProcessNoteOff(message[0], message[1], message[2]);
                }
                else if (status == 0xB && size == 3)
                {
                    GetChannelDevice(channel).ProcessControlChange(message[0], message[1], message[2]);
                }
                else if (status == 0xC && size == 2)
                {
                    GetChannelDevice(channel).ProcessProgramChange(message[0], message[1]);
                }
                else if (status == 0xE && size == 3)
                {
                    GetChannelDevice(channel).ProcessPitchBend(message[0], message[1], message[2]);
                }
            }
        }

        #endregion
    }
}
