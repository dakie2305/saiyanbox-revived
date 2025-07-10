using ModDeclaration;
using NeoModLoader.api.attributes;
using NeoModLoader.General;
using NeoModLoader.General.UI.Tab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SaiyanboxRevived.Content
{
    public static class CustomTabsAndButtons
    {
        private static string PathToIcon = "ui/Icons/actor_traits/saiyanbox";
        private static List<GodPower> myGodPowerList = new();
        private static PowersTab _customTab;
        public static void Init()
        {
            createCustomTab();
            createCustomButtons();
            repopulateActorAsset();
        }

        private static void createCustomTab()
        {
            _customTab = TabManager.CreateTab(
                "saiyanbox_revived_tab",
                "saiyanbox_revived_tab",
                "saiyanbox_revived_tab_description",
                SpriteTextureLoader.getSprite($"{PathToIcon}/Bloodline"));
        }

        private static void createCustomButtons()
        {
            GodPower spawnJiren = AssetManager.powers.clone("spawn_unit_jiren", "$template_spawn_actor$");
            spawnJiren.name = "Jiren";
            spawnJiren.rank = PowerRank.Rank4_awesome;
            spawnJiren.actor_asset_id = "jiren";
            spawnJiren.path_icon = "god_powers/jiren";
            AddButton(spawnJiren);
            addToLocale(spawnJiren.id, spawnJiren.name, "Spawning Jiren into this world!");
        }


        private static void AddButton(GodPower power)
        {
            //AssetManager.powers.add(power);
            myGodPowerList.Add(power);
            PowerButtonCreator.AddButtonToTab(PowerButtonCreator.CreateGodPowerButton(power.id, SpriteTextureLoader.getSprite("ui/Icons/" + power.path_icon)), _customTab);
        }

        /// <summary>
        /// This is similar to link asset function
        /// </summary>
        private static void repopulateActorAsset()
        {
            foreach (var godPower in myGodPowerList)
            {
                if (godPower.actor_asset_id != null)
                {
                    ActorAsset actorAsset = AssetManager.actor_library.get(godPower.actor_asset_id);
                    if (actorAsset.power_id == null)
                    {
                        actorAsset.power_id = godPower.id;
                    }
                }
                string[] actor_asset_ids = godPower.actor_asset_ids;
                if (actor_asset_ids != null && actor_asset_ids.Length != 0)
                {
                    foreach (string pID in godPower.actor_asset_ids)
                    {
                        ActorAsset actorAsset2 = AssetManager.actor_library.get(pID);
                        if (actorAsset2.power_id == null)
                        {
                            actorAsset2.power_id = godPower.id;
                        }
                    }
                }
            }
        }

        private static void addToLocale(string id, string name, string description)
        {
            LM.AddToCurrentLocale($"{id}", name);
            LM.AddToCurrentLocale($"{id}_description", description);
        }


    }
}
