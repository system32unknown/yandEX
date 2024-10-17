using HarmonyLib;
using UnityEngine;
namespace YandEX.Patches {
    [HarmonyPatch(typeof(UpdateCheckScript))]
    [HarmonyPatch("Start")]
    internal class UpdateTextPatch {
        static void Postfix(UpdateCheckScript __instance) {
            __instance.warningLabel.text = "This is Modded version of Yandere Simulator with Bepinex!";
            __instance.warningLabel.color = Color.green;
        }
    }
}
