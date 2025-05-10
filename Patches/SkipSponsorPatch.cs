using HarmonyLib;
using UnityEngine.SceneManagement;

namespace YandEX.Patches {
    [HarmonyPatch(typeof(WelcomeScript))]
    [HarmonyPatch("Start")]
    internal class SkipSponsorPatch
    {
        static void Postfix()
        {
            SceneManager.LoadScene("NewTitleScene");
            return;
        }
    }
}
