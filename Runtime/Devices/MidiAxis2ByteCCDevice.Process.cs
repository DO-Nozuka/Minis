using UnityEngine.InputSystem;

namespace Minis.Runtime.Devices
{
    public partial class MidiAxis2ByteCCDevice : InputDevice, IMidiInputSystemDevice
    {
        bool _changeFrag = false;
        static MidiAxis2ByteCCDeviceState _state;
        private byte[] cc = new byte[128];

        public void Process0x9n(byte stats, byte note, byte velocity) { }
        public void Process0x8n(byte stats, byte note, byte velocity) { }
        public unsafe void Process0xBn(byte stats, byte number, byte value)
        {
            if (number >= 64)
                return;

            cc[number] = value;
            byte twoCCNum = (byte)(number % 32);
            byte msbCCNum = (byte)(number % 32);
            var lsbCCNum = number % 32 + 32;
            var axisValue = (((int)cc[msbCCNum] << 7) + cc[lsbCCNum]) / (float)0b0011_1111_1111_1111;

            _state.SetCC(twoCCNum, axisValue);
            _changeFrag = true;
        }
        public void Process0xEn(byte stats, byte value1, byte value2) { }
        public void Process0xCn(byte stats, byte value) { }
        public void ProcessOxFn(byte stats, byte data1, byte data2) { }
        public void Process0xAn(byte stats, byte data1, byte data2) { }
        public void Process0xDn(byte stats, byte data1) { }
        public void ProcessOxFn(byte stats) { }
        public void ProcessOxFn(byte stats, byte data1) { }

        public void QueueEvent()
        {
            if (_changeFrag)
                InputSystem.QueueDeltaStateEvent(this, _state);

            _changeFrag = false;
        }
    }
}