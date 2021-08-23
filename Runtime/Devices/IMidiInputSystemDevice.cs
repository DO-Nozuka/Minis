namespace Minis.Runtime.Devices
{
    public interface IMidiInputSystemDevice //TODO: It is better to share the same interface with MidiVector3Device.
    {
        public void Process0x8n(byte stats, byte data1, byte data2);
        public void Process0x9n(byte stats, byte data1, byte data2);
        public void Process0xAn(byte stats, byte data1, byte data2);
        public void Process0xBn(byte stats, byte data1, byte data2);
        public void Process0xCn(byte stats, byte data1);
        public void Process0xDn(byte stats, byte data1);
        public void Process0xEn(byte stats, byte data1, byte data2);
        public void ProcessOxFn(byte stats);
        public void ProcessOxFn(byte stats, byte data1);
        public void ProcessOxFn(byte stats, byte data1, byte data2);
    }
}