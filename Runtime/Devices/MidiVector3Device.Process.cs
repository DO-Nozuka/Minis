using Dono.Midi.Runtime;
using UnityEngine.InputSystem;

namespace Minis.Runtime.Devices
{
    public partial class MidiVector3Device : InputDevice, IMidiInputSystemDevice
    {
        static MidiVector3DeviceState _state;
        public void Process0x9n(byte stats, byte note, byte velocity)
        {
            // State update with a delta event
            _state.SetNoteOn(stats, note, velocity);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }

        public void Process0x8n(byte stats, byte note, byte velocity)
        {
            // State update with a delta event
            _state.SetNoteOff(stats, note, velocity);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }
        public void Process0xAn(byte stats, byte data1, byte data2) 
        {
            _state.SetPP(stats, data1, data2);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }

        public void Process0xBn(byte stats, byte number, byte value)
        {
            // State update with a delta event
            _state.SetCC(stats, number, value);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }
        public void Process0xCn(byte stats, byte value)
        {
            // State update with a delta event
            _state.SetPC(stats, value);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }
        public void Process0xDn(byte stats, byte data1)
        {
            _state.SetCP(stats, data1);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }        
        public void Process0xEn(byte stats, byte value1, byte value2)
        {
            // State update with a delta event
            _state.SetPitch(stats, value1, value2);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }


        public void ProcessOxFn(byte stats)
        {
            _state.SetSysMsg(stats, 0, 0);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }
        public void ProcessOxFn(byte stats, byte data1)
        {
            _state.SetSysMsg(stats, data1, 0);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }
        public void ProcessOxFn(byte stats, byte data1, byte data2)
        {
            _state.SetSysMsg(stats, data1, data2);
            InputSystem.QueueDeltaStateEvent(this, _state);
        }
    }
}