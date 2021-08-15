using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem;
using RtMidiDll = RtMidi.Unmanaged;
using Minis.Runtime.Devices;
using System.Collections.Generic;
using System;

namespace Minis.Runtime.Internal
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

        List<IMidiInputSystemDevice> midiDevices = new List<IMidiInputSystemDevice>();
        private MidiVector3Device __midiVector3Device;
        private MidiButtonDevice __midiSwitchDevice;
        private MidiAxisNoteDevice __midiAxisNoteDevice;
        private MidiAxis2ByteCCDevice __midiAxis2ByteCCDevice;
        private MidiAxisPitchDevice __midiAxisPitchDevice;

        private MidiVector3Device GetMidiVector3Device()
        {
            if (__midiVector3Device == null)
            {
                var desc = new InputDeviceDescription
                {
                    interfaceName = "MidiVector3",
                };
                __midiVector3Device = (MidiVector3Device)InputSystem.AddDevice(desc);
            }
            
            return __midiVector3Device;
        }

        private MidiButtonDevice GetMidiSwitchDevice()
        {
            if (__midiSwitchDevice == null)
            {
                var desc = new InputDeviceDescription
                {
                    interfaceName = "MidiButton",
                };
                __midiSwitchDevice = (MidiButtonDevice)InputSystem.AddDevice(desc);
            }

            return __midiSwitchDevice;
        }

        private MidiAxisNoteDevice GetMidiAxisDevice()
        {
            if (__midiAxisNoteDevice is null)
            {
                var desc = new InputDeviceDescription
                {
                    interfaceName = "MidiAxisNote"
                };
                __midiAxisNoteDevice = (MidiAxisNoteDevice)InputSystem.AddDevice(desc);
            }

            return __midiAxisNoteDevice;
        }
        private MidiAxis2ByteCCDevice GetMidi2ByteCCDevice()
        {
            if (__midiAxis2ByteCCDevice is null)
            {
                var desc = new InputDeviceDescription
                {
                    interfaceName = "MidiAxis2ByteCC"
                };
                __midiAxis2ByteCCDevice = (MidiAxis2ByteCCDevice)InputSystem.AddDevice(desc);
            }

            return __midiAxis2ByteCCDevice;
        } 
        private MidiAxisPitchDevice GetMidiAxisPitchDevice()
        {
            if (__midiAxisPitchDevice is null)
            {
                var desc = new InputDeviceDescription
                {
                    interfaceName = "MidiAxisPitch"
                };
                __midiAxisPitchDevice = (MidiAxisPitchDevice)InputSystem.AddDevice(desc);
            }

            return __midiAxisPitchDevice;
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

            if(__midiVector3Device is object)            
                InputSystem.RemoveDevice(__midiVector3Device);            
            if (__midiSwitchDevice is object)
                InputSystem.RemoveDevice(__midiSwitchDevice);
            if (__midiAxisNoteDevice is object)
                InputSystem.RemoveDevice(__midiAxisNoteDevice);
            if (__midiAxis2ByteCCDevice is object)
                InputSystem.RemoveDevice(__midiAxis2ByteCCDevice);
            if (__midiAxisPitchDevice is object)
                InputSystem.RemoveDevice(__midiAxisPitchDevice);

            System.GC.SuppressFinalize(this);
        }


        public void ProcessMessageQueue()
        {
            if (_rtmidi == null || !_rtmidi->ok) return;

            midiDevices.Clear();
            if (GetMidiVector3Device() is IMidiInputSystemDevice device0)
                midiDevices.Add(device0);
            if (GetMidiSwitchDevice() is IMidiInputSystemDevice device1)
                midiDevices.Add(device1);
            if (GetMidiAxisDevice() is IMidiInputSystemDevice device2)
                midiDevices.Add(device2);
            if (GetMidi2ByteCCDevice() is IMidiInputSystemDevice device3)
                midiDevices.Add(device3);
            if (GetMidiAxisPitchDevice() is IMidiInputSystemDevice device4)
                midiDevices.Add(device4);

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
                    foreach(var midiDevice in midiDevices)
                    {
                        midiDevice.ProcessNoteOn(message[0], message[1], message[2]);
                    }
                }
                else if (noteOff && size == 3)
                {
                    message[0] = (byte)(0x80 + channel);    //0x9n vel=0 => 0x8n vel=0ÅB
                    foreach (var midiDevice in midiDevices)
                    {
                        midiDevice.ProcessNoteOff(message[0], message[1], message[2]);
                    }
                }
                else if (status == 0xB && size == 3)
                {
                    foreach (var midiDevice in midiDevices)
                    {
                        midiDevice.ProcessControlChange(message[0], message[1], message[2]);
                    }
                }
                else if (status == 0xC && size == 2)
                {
                    foreach (var midiDevice in midiDevices)
                    {
                        midiDevice.ProcessProgramChange(message[0], message[1]);
                    }
                }
                else if (status == 0xE && size == 3)
                {
                    foreach (var midiDevice in midiDevices)
                    {
                        midiDevice.ProcessPitchBend(message[0], message[1], message[2]);
                    }
                }
            }
        }
        #endregion
    }
}
