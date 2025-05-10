using HarmonyLib;
using UnityEngine;

namespace YandEX.Patches {
    [HarmonyPatch(typeof(UpdateCheckScript))]
    [HarmonyPatch("Start")]
    internal class UpdateTextPatch {
        static void Postfix(UpdateCheckScript __instance) {
            __instance.warningLabel.text = "You are playing an [c][00ff00]Modded[-][/c] version of Yandere Simulator with BepinEX!\nBy the way, i don't support yanderedev.";
        }
    }
}
