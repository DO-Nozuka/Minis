namespace Minis.Runtime.Devices
{
    public interface IMidiInputSystemDevice //TODO: It is better to share the same interface with MidiVector3Device.
    {
        public void ProcessNoteOn(byte stats, byte note, byte velocity);
        public void ProcessNoteOff(byte stats, byte note, byte velocity);
        public void ProcessControlChange(byte stats, byte number, byte value);
        public void ProcessPitchBend(byte stats, byte value1, byte value2);
        public void ProcessProgramChange(byte stats, byte value);
    }
}