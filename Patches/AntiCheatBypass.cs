﻿using HarmonyLib;
namespace yandEX.Patches {
    [HarmonyPatch(typeof(AntiCheatScript))]
    internal class AntiCheatBypass {
        [HarmonyPatch("Update"), HarmonyPostfix]
        static void bypassAntiCheat(ref bool ___Check) {
            ___Check = false;
        }
    }
}