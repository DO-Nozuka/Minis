Minis: MIDI Input for New Input System
================================================================
Original => https://github.com/keijiro/Minis

Why
----------------------------------------------------------------
I need to get PitchBend, ProgramChange and more functions.

How To Install
----------------------------------------------------------------
1. Open Package Manager
2. Add package from git URL
https://github.com/DO-Nozuka/Minis.git
(You need RtMidiForUnity. https://github.com/DO-Nozuka/RtMidiForUnity)

How To Use
----------------------------------------------------------------
You can use midi device with InputSystem.
Some functions are not yet implemented!
Some functions are not yet implemented!!
Some functions are not yet implemented!!!

Recommend: Action Type = Pass Through

 Vector3
----------------
Raw midi message will be stored.

* Vec3NoteOff: Vector3(stats, data1, data2)
    * 0x8n Note Off.
* Vec3NoteOn: Vector3(stats, data1, data2)
    * 0x9n Note On.
    * Velocity(data2) is not zero.
* Vec3PP: Vector3(stats, data1, data2)
    * 0xAn Polyphonic key Presure.
* Vec3CC: Vector3(stats, data1, data2)
    * 0xBn Control Change.
* Vec3PC: Vector3(stats, data1, data2)
    * 0xCn Program Change.
* Vec3CP: Vector3(stats, data1, data2)
    * 0xDn Channel Pressure.
* Vec3Pitch: Vector3(stats, data1, data2)
    * 0xEn Pitch Bend Change.
* Vec3SysMsg: Vector3(stats, data1, data2)
    * 0xFn Only for data length 3 or less
* Vec3AnyNote: Vector3(stats, data1, data2)
    * NoteOn and NoteOff
* Vec3AnyMsg: Vector3(stats, data1, data2)
    * It can get all midi message.
    * Only for data length 3 or less.

 Axis
----------------
* AxisNoteXXX: Axis(Velocity)
    * XXX: Note Number
    * Velocity:   NoteOn127 => 1.0f, NoteOff127 => -1.0f
* AxisPitchUp: Axis(PitchUp)
    * PitchUp => 0.0f～1.0f
* AxisPitchDown: Axis(PitchDown)
    * PitchDown => 0.0f～1.0f
* AxisPitch: Axis(Pitch)
    * Pitch => -1.0f～1.0f
 Button
----------------
* BtnNoteXXX: Axis(On/Off)
    * XXX: Note Number
    * On/Off: On => 1.0f, Off => 0.0f
* BtnPitchUp: Axis(On/Off)
    * On/Off: On => 1.0f, Off => 0.0f
* BtnPitchDown: Axis(On/Off)
    * On/Off: On => 1.0f, Off => 0.0f
* AnyBtnNote: Axis(On/Off)
    * On/Off: On => 1.0f, Off => 0.0f
* AnyWhiteBtnNote: Axis(On/Off)
    * On/Off: On => 1.0f, Off => 0.0f
* AnyBlackBtnNote: Axis(On/Off)
    * On/Off: On => 1.0f, Off => 0.0f

 Integer
----------------
    * ControlChange to be implemented.
  
Update
----------------------------------------------------------------
1.1.0: AddPitchBend  
1.1.1: AddProgramChange  
1.1.2: Vector2 => Vector3  
1.1.3: Add Button Type  
1.3.0: Add Axis, Major changes to the specifications for MidiVector3Device.  