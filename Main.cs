using HarmonyLib;
using SaiyanboxRevised.Content;
using NeoModLoader.api;
using NeoModLoader.api.attributes;
using NeoModLoader.General;
using System;
using System.IO;
using System.Reflection;
using UnityEngine;
using SaiyanboxRevived.Content;

namespace SaiyanboxRevised;

public class SaiyanboxMain : BasicMod<SaiyanboxMain>, IReloadable
{
    internal static bool _reload_switch;

    // Let the method can be hotfixed when it is modified and after the mod is reloaded. You can add this attribute at runtime.
    [Hotfixable]
    public void Reload()
    {
        _reload_switch = !_reload_switch;
    }

    protected override void OnModLoad()
    {
        LogInfo("SaiyanboxMain Starting Up And Is Running!");
        CustomTraits.Init();
        CustomStatusEffects.Init();
        CustomTabsAndButtons.Init();
    }
}