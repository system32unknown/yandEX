using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using YandEX.Patches;

namespace YandEX {
    [BepInPlugin(modGUID, "YandEX", verNum)]
    public class YandereAPI : BaseUnityPlugin {
        const string modGUID = "altertoriel.yandex";
        const string verNum = "1.0.0.0";

        public static Version Version => new Version(verNum);

        internal static YandereAPI i;
        internal ManualLogSource mls;

        void Awake() {
            i = this;
            Harmony harmony = new Harmony(modGUID);

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("Mod Installed Successfully.");
            mls.LogInfo($"Mod Version: {verNum}");

            harmony.PatchAllConditionals();
        }
    }
}
