using HarmonyLib;
using System.Text;
using UnityEngine;

namespace yandEX.Patches {
    [HarmonyPatch(typeof(DisclaimerScript))]
    [HarmonyPatch("Start")]
    internal class DisclaimerShit {
        static void Postfix()
        {
            foreach (UILabel label in UnityEngine.Object.FindObjectsByType<UILabel>(FindObjectsSortMode.None))
            {
                label.text = GetRNGTxt(100);
            }
        }

        // You can assign chance and includespace through public fields or function parameters
        static string GetRNGTxt(int max, bool includeSpace = false, int chance = 50)
        {
            StringBuilder tempStr = new StringBuilder();
            for (int i = 0; i < max; i++)
            {
                char c = (char)Random.Range(65, 123); // 123 is exclusive
                tempStr.Append(c);
                if (includeSpace && Random.Range(0, 100) < chance)
                    tempStr.Append("\n");
            }
            return tempStr.ToString();
        }
    }
}
