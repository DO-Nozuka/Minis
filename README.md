Minis: MIDI Input for New Input System
================================================================
Original => https://github.com/keijiro/Minis

Why
----------------------------------------------------------------
I need to get PitchBend and ProgramChange.

How To Install
----------------------------------------------------------------
1. Open Package Manager
2. Add package from git URL
https://github.com/DO-Nozuka/Minis.git
(You need RtMidiForUnity. https://github.com/DO-Nozuka/RtMidiForUnity)

How To Use
----------------------------------------------------------------
You can use midi device with InputSystem.

NoteXX: Vector2(velocity, channel)
    velocity = 0(NoteOff)
    velocity = 1-127(NoteOn)
    channel = 0-15

ControlChange: Vector2(value, channel)
    value = 0-127
    channel = 0-15

PitchBend: Vector2(value, channel)
    value = (-1.0)-(1.0)
    channel = 0-15

PitchUp: Vecotr2(value, channel)
    value = 0-1.0
    channnel = 0-15

PitchDown: Vector2(value, channel)
    value = 0-1.0 (caution: Not a Negative number)
    channnel = 0-15

ProgramChange: Vector2(value, channel)
    value = 0-127
    channnel = 0-15


Update
----------------------------------------------------------------
1.1.0: AddPitchBend
1.1.1: AddProgramChange
