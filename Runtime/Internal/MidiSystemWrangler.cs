using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.LowLevel;
using System.Linq;
using Minis.Runtime.Devices;

namespace Minis.Runtime.Internal
{
    //
    // Wrangler class that installs/uninstalls MIDI subsystems on system events
    //
#if UNITY_EDITOR
    [UnityEditor.InitializeOnLoad]
#endif
    sealed class MidiSystemWrangler
    {
        #region Internal objects and methods

        static MidiDriver _driver;

        static void RegisterLayout()
        {
            InputSystem.RegisterLayout<MidiVector3Device>(
                matches: new InputDeviceMatcher().WithInterface("MidiVector3")
                );
            InputSystem.RegisterLayout<MidiButtonDevice>(
                matches: new InputDeviceMatcher().WithInterface("MidiButton")
                );
            InputSystem.RegisterLayout<MidiAxisNoteDevice>(
                matches: new InputDeviceMatcher().WithInterface("MidiAxisNote")
                );
            InputSystem.RegisterLayout<MidiAxis2ByteCCDevice>(
                matches: new InputDeviceMatcher().WithInterface("MidiAxis2ByteCC")
                );
            InputSystem.RegisterLayout<MidiAxisPitchDevice>(
                matches: new InputDeviceMatcher().WithInterface("MidiAxisPitch")
                );
        }

        #endregion

        #region PlayerLoopSystem implementation

        static void InsertPlayerLoopSystem()
        {
            var customSystem = new PlayerLoopSystem() {
                type = typeof(MidiSystemWrangler),
                updateDelegate = () => _driver?.Update()
            };

            var playerLoop = PlayerLoop.GetCurrentPlayerLoop();

            for (var i = 0; i < playerLoop.subSystemList.Length; i++)
            {
                ref var phase = ref playerLoop.subSystemList[i];
                if (phase.type == typeof(UnityEngine.PlayerLoop.EarlyUpdate))
                {
                    phase.subSystemList =
                        phase.subSystemList.Concat(new [] { customSystem }).ToArray();
                    break;
                }
            }

            PlayerLoop.SetPlayerLoop(playerLoop);
        }

        #endregion

        #region System initialization/finalization callback

        #if UNITY_EDITOR

        //
        // On Editor, we use InitializeOnLoad to install the subsystem. At the
        // same time, we use AssemblyReloadEvents to temporarily disable the
        // system to avoid issue #1192379.
        // #FIXME This workaround should be removed when the issue is solved.
        //

        static MidiSystemWrangler()
        {
            RegisterLayout();
            InsertPlayerLoopSystem();

            // We use not only PlayerLoopSystem but also the
            // EditorApplication.update callback because the PlayerLoop events
            // are not invoked in the edit mode.
            UnityEditor.EditorApplication.update += () => _driver?.Update();

            // Uninstall the driver on domain reload.
            UnityEditor.AssemblyReloadEvents.beforeAssemblyReload += () => {
                _driver?.Dispose();
                _driver = null;
            };

            // Reinstall the driver after domain reload.
            UnityEditor.AssemblyReloadEvents.afterAssemblyReload += () => {
                _driver = _driver ?? new MidiDriver();
            };
        }

        #else

        //
        // On Player, we use RuntimeInitializeOnLoadMethod to install the
        // subsystems. We don't do anything about finalization.
        //

        [UnityEngine.RuntimeInitializeOnLoadMethod]
        static void Initialize()
        {
            RegisterLayout();
            InsertPlayerLoopSystem();
            _driver = new MidiDriver();
        }

        #endif

        #endregion
    }
}
