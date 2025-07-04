using ai;
using HarmonyLib.Tools;
using NeoModLoader.api.attributes;
using NeoModLoader.General;
using ReflectionUtility;
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
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
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
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
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
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
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

    internal static bool Saiyan3Evo(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        //evolutionary condition
        if (a.data.getAge() >= 65 || a.data.kills > 75)
        {
            if (Randy.randomChance(0.05f))
            {
                a.addTrait("saiyan_4");
                a.data.health += 500;

            }
        }

        if (a.data.health < a.getMaxHealth() / 4)
        {
            if (Randy.randomChance(0.01f))
            {
                a.addTrait("saiyan_4");
                a.data.health += 500;
            }
        }
        return true;
    }

    internal static bool Saiyan4Evo(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        //evolutionary condition
        if (a.data.getAge() >= 85 || a.data.kills > 100)
        {
            if (Randy.randomChance(0.05f))
            {
                a.addTrait("saiyan_5");
                a.data.health += 500;

            }
        }

        if (a.data.health < a.getMaxHealth() / 6)
        {
            if (Randy.randomChance(0.01f))
            {
                a.addTrait("saiyan_5");
                a.data.health += 500;
            }
        }
        return true;
    }

    internal static bool Saiyan5Evo(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        //evolutionary condition
        if (a.data.getAge() >= 120 || a.data.kills > 400)
        {
            if (Randy.randomChance(0.05f))
            {
                a.addTrait("immune");
                a.addTrait("ultimate");
                a.data.health += 500;

            }
        }

        if (a.data.health < a.getMaxHealth() / 10)
        {
            if (Randy.randomChance(0.01f))
            {
                a.addTrait("immune");
                a.addTrait("ultimate");
                a.data.health += 500;
            }
        }
        return true;
    }

    internal static bool Fall(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        if (a != null)
        {
            AuraS(pTarget);
            a.removeTrait("saiyan_4");
            a.addTrait("bloodlust");
            a.addTrait("immune");
            a.addTrait("evil");
            if (Randy.randomChance(0.15f))
            {
                ActionLibrary.regenerationEffect(pTarget, pTile);
            }
            if (a.data.health < (a.getMaxHealth() / 4))
            {
                a.data.health += 500;
            }
            if (a.data.getAge() >= 300 && a.data.getAge() < 500)
            {
                a.removeTrait("madness");
            }
            if (a.data.getAge() >= 500)
            {
                a.die();
            }
        }
        return true;
    }

    public static bool AuraS(BaseSimObject pTarget, WorldTile pTile = null)
    {
        if (pTarget?.a == null || !pTarget.a.isAlive()) return false;
        Actor actor = pTarget.a;
        if (actor.hasTrait("saiyan_4"))
            pTarget.addStatusEffect("Aura_Red", 20f);
        if (actor.hasTrait("saiyan_blue"))
            pTarget.addStatusEffect("Aura_BlueS", 20f);
        if (actor.hasTrait("ultra_instinct"))
            pTarget.addStatusEffect("Aura_Blue", 20f);
        if (actor.hasTrait("the_fallen"))
            pTarget.addStatusEffect("Aura_Fallen", 20f);
        if (actor.hasTrait("saiyan_rose"))
            pTarget.addStatusEffect("Aura_Rose", 20f);
        if (actor.hasTrait("perfect_ultra_instinct"))
            pTarget.addStatusEffect("Aura_White", 20f);
        if (actor.hasTrait("saiyan_5"))
            pTarget.addStatusEffect("Aura_Grey", 20f);
        if (actor.hasTrait("ultimate"))
            pTarget.addStatusEffect("Aura_Black", 20f);
        if (actor.hasTrait("saiyan_true_form_5"))
            pTarget.addStatusEffect("Aura_T5", 20f);
        if (actor.hasTrait("breaking_limit"))
            pTarget.addStatusEffect("Aura_Breaking", 20f);
        return true;
    }

    public static bool Remove(BaseSimObject pTarget, WorldTile pTile = null)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        a.removeTrait("cursed");
        a.removeTrait("crippled");
        a.removeTrait("eyepatch");
        a.removeTrait("weak");
        a.removeTrait("skin_burns");
        a.removeTrait("slow");
        a.removeTrait("fat");
        a.removeTrait("madness");
        a.removeTrait("infected");
        return true;
    }

    public static bool Resist(BaseSimObject pTarget, WorldTile pTile = null)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        a.addTrait("fire_proof");
        a.addTrait("freeze_proof");
        a.addTrait("acid_proof");
        a.addTrait("poison_immune");
        a.addTrait("strong_minded");
        a.addTrait("immune");
        return true;
    }

    internal static bool Ulti(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        if (a != null)
        {
            Remove(pTarget);
            AuraS(pTarget);
            Resist(pTarget);
            if (Randy.randomChance(0.15f))
            {
                ActionLibrary.regenerationEffect(pTarget, pTile);
            }
            if (a.data.health < (a.getMaxHealth() / 4))
            {
                a.data.health += 500;
            }
        }
        return true;
    }

    internal static bool SaiyanBlueEvo(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        //evolutionary condition
        if (a.data.getAge() >= 150 || a.data.kills > 500)
        {
            if (Randy.randomChance(0.05f))
            {
                a.addTrait("saiyan_rose");
                a.data.health += 500;

            }
        }

        if (a.data.health < a.getMaxHealth() / 10)
        {
            if (Randy.randomChance(0.01f))
            {
                a.addTrait("saiyan_rose");
                a.data.health += 500;
            }
        }
        return true;
    }

    internal static bool Ultra(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        Remove(pTarget);
        Resist(pTarget);
        AuraS(pTarget);
        a.removeTrait("saiyan_blue");
        a.addTrait("immune");
        //evolutionary condition
        if (a.data.getAge() >= 150 || a.data.kills > 500)
        {
            if (Randy.randomChance(0.05f))
            {
                a.addTrait("perfect_ultra_instinct");
                a.data.health += 500;

            }
        }

        if (a.data.health < a.getMaxHealth() / 10)
        {
            if (Randy.randomChance(0.01f))
            {
                a.addTrait("perfect_ultra_instinct");
                a.data.health += 500;
            }
        }
        return true;
    }

    internal static bool Rose(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        Resist(pTarget);
        AuraS(pTarget);
        a.addTrait("immune");
        a.addTrait("bloodlust");
        a.addTrait("evil");
        if (Randy.randomChance(0.015f))
        {
            ActionLibrary.restoreHealthOnHit(pTarget, pTarget);
        }

        if (a.data.getAge() >= 300 && a.data.getAge() < 500 && a.data.kills < 100)
        {
            a.addTrait("madness");
        }
        return true;
    }
    internal static bool PerUl(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        AuraS(pTarget);
        Resist(pTarget);
        Remove(pTarget);
        a.removeTrait("ultra_instinct");
        a.addTrait("immune");
        ActionLibrary.restoreHealthOnHit(pTarget, null);
        return true;
    }


    internal static bool EvoL(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        if (a.data.getAge() >= 18)
        {
            HashSet<string> evolutionTraits = new HashSet<string>
            {
                "saiyan_legendary",
                "saiyan_true_form",
                "saiyan_true_form_4",
                "saiyan_true_form_5",
                "breaking_limit",
            };

            foreach (string traitId in evolutionTraits)
            {
                if (a.hasTrait(traitId))
                    return true;
            }

            if (a.data.nutrition >= 40)
            {
                a.addTrait("saiyan_legendary");
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

    internal static bool SaiyanLEvo(BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        Actor a = pTarget.a;
        //evolutionary condition
        if (a.data.getAge() >= 85 || a.data.kills > 100)
        {
            if (Randy.randomChance(0.05f))
            {
                a.addTrait("saiyan_true_form");
                a.data.health += 500;
            }
        }
        if (a.data.health < a.getMaxHealth() / 6)
        {
            if (Randy.randomChance(0.01f))
            {
                a.addTrait("saiyan_true_form");
                a.data.health += 500;
            }
        }
        return true;
    }

    #endregion

    #region Attack Effect
    internal static bool KiPunch(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile)
    {
        if (pTarget?.a == null || !pTarget.a.isAlive()) return false;
        if (pSelf?.a == null || !pSelf.a.isAlive()) return false;

        Actor actor = pSelf.a;

        bool has_saiyan_3 = actor.hasTrait("saiyan_3");
        bool has_saiyan_4_or_blue = actor.hasTrait("saiyan_4") || actor.hasTrait("saiyan_blue");
        bool has_true_form_4 = actor.hasTrait("saiyan_true_form_4");

        if (has_saiyan_3)
        {
            if (Randy.randomChance(0.1f))
            {
                EffectsLibrary.spawn("fx_nuke_flash", actor.current_tile);
                EffectsLibrary.spawnExplosionWave(pTile.posV3, 1f, 1f);
                World.world.applyForceOnTile(pTarget.current_tile, pByWho: pSelf);
            }
        }
        else if (has_saiyan_4_or_blue)
        {
            if (Randy.randomChance(0.5f))
            {
                EffectsLibrary.spawn("fx_nuke_flash", actor.current_tile);
                EffectsLibrary.spawnExplosionWave(pTile.posV3, 1f, 1f);
                World.world.applyForceOnTile(pTarget.current_tile, pByWho: pSelf);
                tornadoPunch(pSelf, pTarget, pTile);
            }
        }
        else if (has_true_form_4)
        {
            if (Randy.randomChance(0.7f))
            {
                EffectsLibrary.spawn("fx_nuke_flash", actor.current_tile);
                EffectsLibrary.spawnExplosionWave(pTile.posV3, 1f, 1f);
                World.world.applyForceOnTile(pTarget.current_tile, pByWho: pSelf);
                tornadoPunch(pSelf, pTarget, pTile);
                nukePunch(pSelf, pTarget, pTile);
                lightningPunch(pSelf, pTarget, pTile);
            }
        }
        else
        {
            EffectsLibrary.spawn("fx_nuke_flash", actor.current_tile);
            EffectsLibrary.spawnExplosionWave(pTile.posV3, 1f, 1f);
            World.world.applyForceOnTile(pTarget.current_tile, pByWho:pSelf);
            tornadoPunch(pSelf, pTarget, pTile);
            nukePunch(pSelf, pTarget, pTile);
            lightningPunch(pSelf, pTarget, pTile);
        }

        return true;
    }
    public static bool tornadoPunch(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        if (Randy.randomChance(0.01f))
        {
            ActionLibrary.castTornado(pSelf, pTarget, pTile);
            return true;
        }
        return false;
    }

    public static bool lightningPunch(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        if (Randy.randomChance(0.01f))
        {
            ActionLibrary.startNuke(pTarget, pTile);
            return true;
        }
        return false;
    }

    public static bool nukePunch(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
        if (Randy.randomChance(0.01f))
        {
            ActionLibrary.castLightning(pSelf, pTarget, pTile);
            return true;
        }
        return false;
    }


    #endregion



    #region Custom Function
    public static bool teleportToSpecificLocation(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile, string text = "fx_teleport_blue")
    {
        if (pTarget == null || pTarget.a == null || !pTarget.a.isAlive()) return false;
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

    internal static bool Saiyan4Death(BaseSimObject pTarget, WorldTile pTile)
    {
        if (Randy.randomChance(0.05f))
        {
            Actor a = pTarget.a;
            var act = World.world.units.createNewUnit(a.asset.id, pTile);
            ActionLibrary.castLightning(pTarget, pTarget, pTile);
            ActorTool.copyUnitToOtherUnit(a, act);
            act.kingdom = pTarget.kingdom;
            act.addTrait("saiyan_5");
            act.data.health += 500;
            return true;
        }
        return false;
    }

    internal static bool SaiyanBlueDeath(BaseSimObject pTarget, WorldTile pTile)
    {
        if (Randy.randomChance(0.05f))
        {
            Actor a = pTarget.a;
            var act = World.world.units.createNewUnit(a.asset.id, pTile);
            ActionLibrary.castLightning(pTarget, pTarget, pTile);
            ActorTool.copyUnitToOtherUnit(a, act);
            act.kingdom = pTarget.kingdom;
            act.addTrait("ultra_instinct");
            act.data.health += 500;
            return true;
        }
        return false;
    }






    #endregion
}