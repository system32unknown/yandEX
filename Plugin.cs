using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using yandEX.Patches;

namespace YandEX {
    [BepInPlugin(modGUID, modName, modVersion)]
    public class ModBase : BaseUnityPlugin {
        const string modGUID = "Altertoriel.YandEX";
        const string modName = "YanderEX";
        const string modVersion = "1.0.0.0";

        readonly Harmony harmony = new Harmony(modGUID);

        internal static ModBase i;
        internal ManualLogSource mls;

        void Awake() {
            if (i == null) i = this;

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("Mod Installed Successfully.");

            harmony.PatchAll(typeof(ModBase));
            harmony.PatchAll(typeof(AntiCheatBypass));
        }
    }
}
