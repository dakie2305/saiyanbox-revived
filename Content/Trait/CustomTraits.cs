using NeoModLoader.api.attributes;
using NeoModLoader.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiyanboxRevived.Content
{
    public static class CustomTraits
    {
        private static string TraitGroupId = $"saiyanbox_revised";
        private static string TraitGroupIdLegend = $"saiyanbox_revised_legend";

        private static string PathToTraitIcon = "ui/Icons/actor_traits/saiyanbox";


        private static int NoChance = 0;
        private static int Rare = 3;
        private static int LowChance = 15;
        private static int MediumChance = 30;
        private static int ExtraChance = 45;
        private static int HighChance = 75;
        private static int AlwaysChance = 100;

        private static List<ActorTrait> myListTraits = new();
        [Hotfixable]
        public static void Init()
        {
            loadCustomTraitGroup();
            loadCustomTrait();
            loadCustomLegendTraits();
            populateListOppositeTraits();
        }


        private static void loadCustomTraitGroup()
        {
            ActorTraitGroupAsset group = new ActorTraitGroupAsset()
            {
                id = TraitGroupId,
                name = $"trait_group_{TraitGroupId}",
                color = "#ff9500",
            };
            // Add trait group to trait group library
            AssetManager.trait_groups.add(group);
            LM.AddToCurrentLocale($"{group.name}", $"Saiyan's Kind");
        }


        private static void loadCustomLegendTraits()
        {

        }

        private static void loadCustomTrait()
        {
            #region bloodline
            ActorTrait bloodline = new ActorTrait()
            {
                id = $"bloodline",
                path_icon = $"{PathToTraitIcon}/Bloodline",
                can_be_given = true,
                rate_inherit = AlwaysChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R0_Normal
            };

            bloodline.base_stats = new BaseStats();
            bloodline.base_stats.set(CustomBaseStatsConstant.Lifespan, 0f);

            bloodline.action_special_effect = new WorldAction(CustomTraitActions.Evo);
            bloodline.addOpposites(new List<string> { $"legendary_bloodline" });

            bloodline.unlock(true);
            AssetManager.traits.add(bloodline);
            addToList(bloodline);
            addToLocale(bloodline.id, "Saiyan Bloodline", "The bloodline of the Saiyan race.", "Ancestral genetics with hidden potential.");
            #endregion

            #region saiyan
            ActorTrait saiyan = new ActorTrait()
            {
                id = $"saiyan",
                path_icon = $"{PathToTraitIcon}/Saiyan",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R2_Epic
            };

            saiyan.base_stats = new BaseStats();
            saiyan.base_stats.set(CustomBaseStatsConstant.Damage, 125f);
            saiyan.base_stats.set(CustomBaseStatsConstant.Armor, 5f);
            saiyan.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 5f);
            saiyan.base_stats.set(CustomBaseStatsConstant.Health, 1250f);
            saiyan.base_stats.set(CustomBaseStatsConstant.Intelligence, 20f);
            saiyan.base_stats.set(CustomBaseStatsConstant.Speed, 5f);

            saiyan.action_special_effect = new WorldAction(CustomTraitActions.SaiyanEvo);
            saiyan.addOpposites(new List<string> { $"saiyan_1", $"saiyan_2" });

            saiyan.unlock(true);
            AssetManager.traits.add(saiyan);
            addToList(saiyan);
            addToLocale(saiyan.id, "Saiyan", "Adult Saiyan warrior.", "Warrior race of unmatched battle instinct.");
            #endregion

            #region saiyan_1
            ActorTrait saiyan1 = new ActorTrait()
            {
                id = $"saiyan_1",
                path_icon = $"{PathToTraitIcon}/Saiyan1",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R2_Epic
            };

            saiyan1.base_stats = new BaseStats();
            saiyan1.base_stats.set(CustomBaseStatsConstant.Damage, 250f);
            saiyan1.base_stats.set(CustomBaseStatsConstant.Armor, 10f);
            saiyan1.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 5f);
            saiyan1.base_stats.set(CustomBaseStatsConstant.Health, 2500f);
            saiyan1.base_stats.set(CustomBaseStatsConstant.Intelligence, 40f);
            saiyan1.base_stats.set(CustomBaseStatsConstant.Speed, 50f);

            saiyan1.action_special_effect = new WorldAction(CustomTraitActions.Saiyan1Evo);
            saiyan1.addOpposites(new List<string> { $"saiyan", $"saiyan_2" });

            saiyan1.unlock(true);
            AssetManager.traits.add(saiyan1);
            addToList(saiyan1);
            addToLocale(saiyan1.id, "Saiyan 1", "First transformation of the Saiyan warrior.", "Ascended form of a battle-hardened Saiyan.");
            #endregion

            #region saiyan_2
            ActorTrait saiyan2 = new ActorTrait()
            {
                id = $"saiyan_2",
                path_icon = $"{PathToTraitIcon}/Saiyan2",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R2_Epic
            };

            saiyan2.base_stats = new BaseStats();
            saiyan2.base_stats.set(CustomBaseStatsConstant.Damage, 500f);
            saiyan2.base_stats.set(CustomBaseStatsConstant.Armor, 15f);
            saiyan2.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 10f);
            saiyan2.base_stats.set(CustomBaseStatsConstant.Health, 2500f);
            saiyan2.base_stats.set(CustomBaseStatsConstant.Intelligence, 100f);
            saiyan2.base_stats.set(CustomBaseStatsConstant.Speed, 50f);

            saiyan2.action_special_effect = new WorldAction(CustomTraitActions.Saiyan2Evo);
            saiyan2.addOpposites(new List<string> { $"saiyan", $"saiyan_1" });

            saiyan2.unlock(true);
            AssetManager.traits.add(saiyan2);
            addToList(saiyan2);
            addToLocale(saiyan2.id, "Saiyan 2", "Second transformation of the Saiyan warrior.", "Even greater power achieved through intense combat.");
            #endregion



        }




        private static void addToLocale(string id, string name, string description, string description_2 = "")
        {
            LM.AddToCurrentLocale($"trait_{id}", name);
            LM.AddToCurrentLocale($"trait_{id}_info", description);
            LM.AddToCurrentLocale($"trait_{id}_info_2", description_2);
        }


        private static void addToList(ActorTrait trait)
        {
            if (!myListTraits.Contains(trait))
                myListTraits.Add(trait);
        }

        /// <summary>
        /// Need to fill in list trait's opposite_traits
        /// </summary>
        private static void populateListOppositeTraits()
        {
            if (myListTraits.Any())
            {
                foreach (var trait in myListTraits)
                {
                    List<string>? curentTraitOppositeList = trait.opposite_list;
                    if (curentTraitOppositeList.Any())
                    {
                        // Ensure opposite_traits list exists
                        if (trait.opposite_traits == null)
                            trait.opposite_traits = new();
                        foreach (var opposite in trait.opposite_list)
                        {
                            var matchedTrait = myListTraits.FirstOrDefault(t => t.id == opposite);
                            if (matchedTrait != null && !trait.opposite_traits.Contains(matchedTrait))
                            {
                                trait.opposite_traits.Add(matchedTrait);
                            }
                        }
                    }

                }
            }
        }
    }
}
