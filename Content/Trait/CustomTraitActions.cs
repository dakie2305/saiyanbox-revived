using ai;
using HarmonyLib.Tools;
using NeoModLoader.api.attributes;
using NeoModLoader.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.UI.CanvasScaler;

namespace SaiyanboxRevived.Content;

internal static class CustomTraitActions
{
    #region special effects

    internal static bool kamuiSpecialEffect(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        if (pTarget.a.data.health <= pTarget.a.getMaxHealth() / 5 && Randy.randomChance(0.3f))
        {
            ActionLibrary.teleportRandom(pTarget, pTarget, pTile);
            ActionLibrary.castBloodRain(pTarget, pTarget, pTile);
            return true;
        }
        return false;
    }

    // Young saiyan inner trait evolution logic
    public static bool Evo(BaseSimObject pTarget, WorldTile pTile = null)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;

        Actor a = pTarget.a;

        if (a.data.getAge() >= 18)
        {
            HashSet<string> evolutionTraits = new HashSet<string>
            {
                "saiyan",
                "saiyan_1",
                "saiyan_2",
                "saiyan_3",
                "saiyan_4",
                "saiyan_5",
                "ultimate",
                "the_fallen",
                "saiyan_blue",
                "saiyan_rose",
                "ultra_instinct",
                "perfect_ultra_instinct"
            };

            foreach (string traitId in evolutionTraits)
            {
                if (a.hasTrait(traitId))
                    return true;
            }

            if (a.data.nutrition >= 40)
            {
                a.addTrait("saiyan");
            }
        }

        // Prevent invalid units from evolving
        HashSet<string> blockedUnits = new HashSet<string> { "skeleton", "ghost", "tumor", "mush", "bioblob" };
        if (blockedUnits.Contains(a.asset.id))
        {
            Prevent(pTarget, pTile);
        }
        return true;
    }


    internal static bool SaiyanEvo(BaseSimObject pTarget, WorldTile pTile)
    {
        Actor a = pTarget.a;
        //evolutionary condition
        if (a.data.getAge() >= 20)
        {
            if (Randy.randomChance(0.05f))
            {
                a.addTrait("saiyan_1");

            }
        }
        if (a.data.health < a.getMaxHealth() / 3)
        {
            if (Randy.randomChance(0.1f))
            {
                a.addTrait("saiyan_1");
            }
        }
        return true;
    }

    internal static bool Saiyan1Evo(BaseSimObject pTarget, WorldTile pTile)
    {
        Actor a = pTarget.a;
        //evolutionary condition
        if (a.data.getAge() >= 30 || a.data.kills > 25)
        {
            if (Randy.randomChance(0.05f))
            {
                a.addTrait("saiyan_2");
                a.data.health += 500;

            }
        }

        if (a.data.health < a.getMaxHealth() / 3)
        {
            if (Randy.randomChance(0.01f))
            {
                a.addTrait("saiyan_2");
                a.data.health += 500;
            }
        }
        return true;
    }

    internal static bool Saiyan2Evo(BaseSimObject pTarget, WorldTile pTile)
    {
        Actor a = pTarget.a;
        //evolutionary condition
        if (a.data.getAge() >= 45 || a.data.kills > 45)
        {
            if (Randy.randomChance(0.05f))
            {
                a.addTrait("saiyan_3");
                a.data.health += 500;

            }
        }

        if (a.data.health < a.getMaxHealth() / 4)
        {
            if (Randy.randomChance(0.01f))
            {
                a.addTrait("saiyan_3");
                a.data.health += 500;
            }
        }
        return true;
    }
    #endregion

    #region Attack Effect

    #endregion



    #region Custom Function

    public static bool teleportToSpecificLocation(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile, string text = "fx_teleport_blue")
    {
        EffectsLibrary.spawnAt(text, pTile.pos, 0.1f);
        pTarget.a.cancelAllBeh();
        pTarget.a.spawnOn(pTile, 0f);
        return true;
    }


    public static bool Prevent(BaseSimObject pTarget, WorldTile pTile = null)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;

        Actor a = pTarget.a;

        // Remove advanced/unique Saiyan forms
        List<string> conflictingTraits = new List<string>
        {
            "saiyan_rose",
            "saiyan_blue",
            "saiyan_4",
            "saiyan_5",
            "saiyan_true_4",
            "saiyan_true_5",
            "ultra_instinct",
            "perfect_ultra_instinct",
            "the_fallen",
            "ultimate",
            "breaking_limit"
        };

        foreach (string traitId in conflictingTraits)
        {
            a.removeTrait(traitId);
        }
        return true;
    }






    #endregion
}