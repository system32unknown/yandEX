using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using yandEX.Patches;

namespace YandEX {
    [BepInPlugin(modGUID, "YanderEX", verNum)]
    public class ModBase : BaseUnityPlugin {
        const string modGUID = "altertoriel.yandex";
        const string verNum = "1.0.0.0";

        public static Version Version => new Version(verNum);

        internal static ModBase i;
        internal ManualLogSource mls;

        void Awake() {
            i = this;
            Harmony harmony = new Harmony(modGUID);

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("Mod Installed Successfully.");
            mls.LogInfo($"Mod Version: {verNum}");

            harmony.PatchAll(typeof(ModBase));
            harmony.PatchAll(typeof(AntiCheatBypass));
            harmony.PatchAll(typeof(UpdateTextPatch));
        }
    }
}
