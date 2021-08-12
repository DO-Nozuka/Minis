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
Recommend: Action Type = Pass Through

NoteOn: Vector3(stats, note, velocity)
    //velocity = 0(NoteOff)
    velocity = 1-127(NoteOn)
    channel = 0-15
    
NoteOff: Vector3(stats, note, velocity)
    velocity = 0-127
    channel = 0-15

ControlChange: Vector3(stats, number, value)
    value = 0-127
    channel = 0-15

PitchBend: Vector3(stats, value1, value2)
    value = (-1.0)-(1.0)
    channel = 0-15
    
ProgramChange: Vector3(stats, value, 0)
    value = 0-127
    channnel = 0-15
    
--------
AnyNoteOn: Vector3(stats, value1, value2)
    velocity = 0(NoteOff)
    velocity = 1-127(NoteOn)
    channel = 0-15
    
AnyNoteOff: Vector3(stats, value1, value2)
    velocity = 0(NoteOff)
    velocity = 1-127(NoteOn)
    channel = 0-15
    
AnyWhiteNoteOn: Vector3(stats, value1, value2)
    velocity = 0(NoteOff)
    velocity = 1-127(NoteOn)
    channel = 0-15
    
AnyWhiteNoteOff: Vector3(stats, value1, value2)
    velocity = 0(NoteOff)
    velocity = 1-127(NoteOn)
    channel = 0-15
    
AnyBlackNoteOn: Vector3(stats, value1, value2)
    velocity = 0(NoteOff)
    velocity = 1-127(NoteOn)
    channel = 0-15
    
AnyBlackNoteOff: Vector3(stats, value1, value2)
    velocity = 0(NoteOff)
    velocity = 1-127(NoteOn)
    channel = 0-15

PitchUp: Vector3(stats, value1, value2)
    value = 0-1.0
    channnel = 0-15

PitchDown: Vector3(stats, value1, value2)
    value = 0-1.0 (caution: Not a Negative number)
    channnel = 0-15
--------

----------------------------------------------------------------
Update
----------------------------------------------------------------
1.1.0: AddPitchBend
1.1.1: AddProgramChange
1.1.2: Vector2 => Vector3
1.1.3: Add Button Type
