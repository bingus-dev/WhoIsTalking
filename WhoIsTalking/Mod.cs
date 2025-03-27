using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
using UnityEngine.UI;
using WhoIsTalking.Patches;

namespace WhoIsTalking
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Mod : BaseUnityPlugin
    {
        public static ConfigEntry<bool> Speaker;
        public static ConfigEntry<bool> ShowPlatform;
        Mod()
        {
            HarmonyP.ApplyPatches();
            Speaker = Config.Bind("Settings", "Speaker", true);
            ShowPlatform = Config.Bind("Settings", "ShowGamePlatform", false);
        }
    }
}
