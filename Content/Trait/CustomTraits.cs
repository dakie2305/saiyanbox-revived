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
            saiyan.action_special_effect = (WorldAction)Delegate.Combine(saiyan.action_special_effect, new WorldAction(CustomTraitActions.SaiyanEvo));
            saiyan.addOpposites(new List<string> { $"saiyan_1", $"saiyan_2", "saiyan_3", "saiyan_4", "saiyan_5" });

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
            saiyan1.base_stats.set(CustomBaseStatsConstant.Speed, 5f);
            saiyan1.action_special_effect = (WorldAction)Delegate.Combine(saiyan1.action_special_effect, new WorldAction(CustomTraitActions.Saiyan1Evo));
            saiyan1.addOpposites(new List<string> { $"saiyan", $"saiyan_2", "saiyan_3", "saiyan_4", "saiyan_5" });

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
            saiyan2.base_stats.set(CustomBaseStatsConstant.Speed, 5f);
            saiyan2.action_special_effect = (WorldAction)Delegate.Combine(saiyan2.action_special_effect, new WorldAction(CustomTraitActions.Saiyan2Evo));
            saiyan2.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_3", "saiyan_4", "saiyan_5" });

            saiyan2.unlock(true);
            AssetManager.traits.add(saiyan2);
            addToList(saiyan2);
            addToLocale(saiyan2.id, "Saiyan 2", "Second transformation of the Saiyan warrior.", "Even greater power achieved through intense combat.");
            #endregion

            #region saiyan_3
            ActorTrait saiyan3 = new ActorTrait()
            {
                id = "saiyan_3",
                path_icon = $"{PathToTraitIcon}/Saiyan3",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R3_Legendary
            };

            saiyan3.base_stats = new BaseStats();
            saiyan3.base_stats.set(CustomBaseStatsConstant.Damage, 100f);
            saiyan3.base_stats.set(CustomBaseStatsConstant.Armor, 20f);
            saiyan3.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 25f);
            saiyan3.base_stats.set(CustomBaseStatsConstant.Health, 3000f);
            saiyan3.base_stats.set(CustomBaseStatsConstant.Intelligence, 160f);
            saiyan3.base_stats.set(CustomBaseStatsConstant.Speed, 10f);
            saiyan3.base_stats.set(CustomBaseStatsConstant.Mass, 80f);

            saiyan3.action_special_effect = (WorldAction)Delegate.Combine(saiyan3.action_special_effect, new WorldAction(CustomTraitActions.Saiyan3Evo));
            saiyan3.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);
            saiyan3.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_2", "saiyan_4", "saiyan_5" });

            saiyan3.unlock(true);
            AssetManager.traits.add(saiyan3);
            addToList(saiyan3);
            addToLocale(saiyan3.id, "Saiyan 3", "Third transformation of the Saiyan warrior.", "Unleashed power through raw rage.");
            #endregion

            #region saiyan_4
            ActorTrait saiyan4 = new ActorTrait()
            {
                id = "saiyan_4",
                path_icon = $"{PathToTraitIcon}/Saiyan4",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R1_Rare
            };

            saiyan4.base_stats = new BaseStats();
            saiyan4.base_stats.set(CustomBaseStatsConstant.Damage, 250f);
            saiyan4.base_stats.set(CustomBaseStatsConstant.Armor, 25f);
            saiyan4.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 50f);
            saiyan4.base_stats.set(CustomBaseStatsConstant.Health, 4000f);
            saiyan4.base_stats.set(CustomBaseStatsConstant.Intelligence, 180f);
            saiyan4.base_stats.set(CustomBaseStatsConstant.Speed, 15f);

            saiyan4.action_special_effect = (WorldAction)Delegate.Combine(saiyan4.action_special_effect, new WorldAction(CustomTraitActions.Saiyan4Evo));
            saiyan4.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);
            saiyan4.action_death = new WorldAction(CustomTraitActions.Saiyan4Death);
            saiyan4.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_3", "saiyan_2", "saiyan_5" });

            saiyan4.unlock(true);
            AssetManager.traits.add(saiyan4);
            addToList(saiyan4);
            addToLocale(saiyan4.id, "Saiyan 4", "Fourth transformation of the Saiyan warrior.", "Ferocious primal power returns with control.");
            #endregion

            #region the_fallen
            ActorTrait theFallen = new ActorTrait()
            {
                id = "the_fallen",
                path_icon = $"{PathToTraitIcon}/Fallen",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R2_Epic
            };

            theFallen.base_stats = new BaseStats();
            theFallen.base_stats.set(CustomBaseStatsConstant.Damage, 300);
            theFallen.base_stats.set(CustomBaseStatsConstant.Armor, 30f);
            theFallen.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 50f);
            theFallen.base_stats.set(CustomBaseStatsConstant.Health, 4000f);
            theFallen.base_stats.set(CustomBaseStatsConstant.Intelligence, 100f);
            theFallen.base_stats.set(CustomBaseStatsConstant.Speed, 20f);

            theFallen.action_special_effect = (WorldAction)Delegate.Combine(theFallen.action_special_effect, new WorldAction(CustomTraitActions.Fall));
            theFallen.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);
            theFallen.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_2", "saiyan_3", "saiyan_4" });

            theFallen.unlock(true);
            AssetManager.traits.add(theFallen);
            addToList(theFallen);
            addToLocale(theFallen.id, "The Fallen", "The one who chose the path of darkness.", "Corrupted power driven by hatred.");
            #endregion

            #region saiyan_5
            ActorTrait saiyan5 = new ActorTrait()
            {
                id = "saiyan_5",
                path_icon = $"{PathToTraitIcon}/Saiyan5",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R1_Rare
            };

            saiyan5.base_stats = new BaseStats();
            saiyan5.base_stats.set(CustomBaseStatsConstant.Damage, 400f);
            saiyan5.base_stats.set(CustomBaseStatsConstant.Armor, 30f);
            saiyan5.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 75f);
            saiyan5.base_stats.set(CustomBaseStatsConstant.Health, 4000f);
            saiyan5.base_stats.set(CustomBaseStatsConstant.Intelligence, 200f);
            saiyan5.base_stats.set(CustomBaseStatsConstant.Speed, 20f);
            saiyan5.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            saiyan5.action_special_effect = (WorldAction)Delegate.Combine(saiyan5.action_special_effect, new WorldAction(CustomTraitActions.Saiyan5Evo));
            saiyan5.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);
            saiyan5.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_2", "saiyan_3", "saiyan_4", "the_fallen" });

            saiyan5.unlock(true);
            AssetManager.traits.add(saiyan5);
            addToList(saiyan5);
            addToLocale(saiyan5.id, "Saiyan 5", "The pinnacle of Saiyan evolution.", "Ultimate form achieved through transcendent mastery.");
            #endregion

            #region ultimate
            ActorTrait ultimate = new ActorTrait()
            {
                id = "ultimate",
                path_icon = $"{PathToTraitIcon}/Ultimate",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R3_Legendary
            };

            ultimate.base_stats = new BaseStats();
            ultimate.base_stats.set(CustomBaseStatsConstant.Damage, 500f);
            ultimate.base_stats.set(CustomBaseStatsConstant.Armor, 35f);
            ultimate.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 75f);
            ultimate.base_stats.set(CustomBaseStatsConstant.Health, 5000f);
            ultimate.base_stats.set(CustomBaseStatsConstant.Intelligence, 200f);
            ultimate.base_stats.set(CustomBaseStatsConstant.Speed, 25f);
            ultimate.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            ultimate.action_special_effect = (WorldAction)Delegate.Combine(ultimate.action_special_effect, new WorldAction(CustomTraitActions.Ulti));
            ultimate.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);
            ultimate.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_2", "saiyan_3", "saiyan_4", "saiyan_5", "the_fallen", "ultra_instinct", "saiyan_blue" });

            ultimate.unlock(true);
            AssetManager.traits.add(ultimate);
            addToList(ultimate);
            addToLocale(ultimate.id, "Ultimate", "Strongest bloodline of the Saiyan race.", "Unmatched strength and instinct combined.");
            #endregion

            #region saiyan_blue
            ActorTrait saiyanBlue = new ActorTrait()
            {
                id = "saiyan_blue",
                path_icon = $"{PathToTraitIcon}/SaiyanBlue",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R2_Epic
            };

            saiyanBlue.base_stats = new BaseStats();
            saiyanBlue.base_stats.set(CustomBaseStatsConstant.Damage, 450f);
            saiyanBlue.base_stats.set(CustomBaseStatsConstant.Armor, 35f);
            saiyanBlue.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 75f);
            saiyanBlue.base_stats.set(CustomBaseStatsConstant.Health, 4000f);
            saiyanBlue.base_stats.set(CustomBaseStatsConstant.Intelligence, 200f);
            saiyanBlue.base_stats.set(CustomBaseStatsConstant.Speed, 25f);
            saiyanBlue.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            saiyanBlue.action_special_effect = (WorldAction)Delegate.Combine(saiyanBlue.action_special_effect, new WorldAction(CustomTraitActions.SaiyanBlueEvo));
            saiyanBlue.action_death = new WorldAction(CustomTraitActions.SaiyanBlueDeath);
            saiyanBlue.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);
            saiyanBlue.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_2", "saiyan_3", "saiyan_4", "saiyan_5", "the_fallen", "ultra_instinct", "ultimate", });

            saiyanBlue.unlock(true);
            AssetManager.traits.add(saiyanBlue);
            addToList(saiyanBlue);
            addToLocale(saiyanBlue.id, "Saiyan Blue", "Another path of Saiyan transformation.", "God-like strength through divine training.");
            #endregion

            #region ultra_instinct
            ActorTrait ultraInstinct = new ActorTrait()
            {
                id = "ultra_instinct",
                path_icon = $"{PathToTraitIcon}/UltraInstinct",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R3_Legendary
            };

            ultraInstinct.base_stats = new BaseStats();
            ultraInstinct.base_stats.set(CustomBaseStatsConstant.Damage, 550f);
            ultraInstinct.base_stats.set(CustomBaseStatsConstant.Armor, 35f);
            ultraInstinct.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 75f);
            ultraInstinct.base_stats.set(CustomBaseStatsConstant.Health, 5000f);
            ultraInstinct.base_stats.set(CustomBaseStatsConstant.Intelligence, 200f);
            ultraInstinct.base_stats.set(CustomBaseStatsConstant.Speed, 25f);
            ultraInstinct.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            ultraInstinct.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            ultraInstinct.action_special_effect = (WorldAction)Delegate.Combine(ultraInstinct.action_special_effect, new WorldAction(CustomTraitActions.Ultra));
            ultraInstinct.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);
            ultraInstinct.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_2", "saiyan_3", "saiyan_4", "saiyan_5", "the_fallen", "ultimate", "saiyan_blue" });

            ultraInstinct.unlock(true);
            AssetManager.traits.add(ultraInstinct);
            addToList(ultraInstinct);
            addToLocale(ultraInstinct.id, "Ultra Instinct", "The god of fighting instinct.", "Instinctive movement and divine combat prowess.");
            #endregion

            #region saiyan_rose
            ActorTrait saiyanRose = new ActorTrait()
            {
                id = "saiyan_rose",
                path_icon = $"{PathToTraitIcon}/SaiyanRose",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R3_Legendary
            };

            saiyanRose.base_stats = new BaseStats();
            saiyanRose.base_stats.set(CustomBaseStatsConstant.Damage, 550f);
            saiyanRose.base_stats.set(CustomBaseStatsConstant.Armor, 35f);
            saiyanRose.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 75f);
            saiyanRose.base_stats.set(CustomBaseStatsConstant.Health, 5000f);
            saiyanRose.base_stats.set(CustomBaseStatsConstant.Intelligence, 200f);
            saiyanRose.base_stats.set(CustomBaseStatsConstant.Speed, 25f);
            saiyanRose.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            saiyanRose.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            saiyanRose.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_2", "saiyan_3", "saiyan_4", "saiyan_5", "the_fallen", "ultimate", "saiyan_blue", "ultra_instinct" });

            saiyanRose.action_special_effect = (WorldAction)Delegate.Combine(saiyanRose.action_special_effect, new WorldAction(CustomTraitActions.Rose));
            saiyanRose.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);
            
            saiyanRose.unlock(true);
            AssetManager.traits.add(saiyanRose);
            addToList(saiyanRose);
            addToLocale(saiyanRose.id, "Saiyan Rose", "The evil god among Saiyans.", "Dark divinity fused with chaos.");
            #endregion

            #region perfect_ultra_instinct
            ActorTrait perfectUltraInstinct = new ActorTrait()
            {
                id = "perfect_ultra_instinct",
                path_icon = $"{PathToTraitIcon}/Perfect",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId,
                rarity = Rarity.R3_Legendary
            };

            perfectUltraInstinct.base_stats = new BaseStats();
            perfectUltraInstinct.base_stats.set(CustomBaseStatsConstant.Damage, 750f);
            perfectUltraInstinct.base_stats.set(CustomBaseStatsConstant.Armor, 35f);
            perfectUltraInstinct.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 150f);
            perfectUltraInstinct.base_stats.set(CustomBaseStatsConstant.Health, 5500f);
            perfectUltraInstinct.base_stats.set(CustomBaseStatsConstant.Intelligence, 300f);
            perfectUltraInstinct.base_stats.set(CustomBaseStatsConstant.Speed, 25f);
            perfectUltraInstinct.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            perfectUltraInstinct.addOpposites(new List<string> { $"saiyan", $"saiyan_1", "saiyan_2", "saiyan_3", "saiyan_4", "saiyan_5", "the_fallen", "ultimate", "saiyan_blue", "ultra_instinct", "saiyan_rose" });

            perfectUltraInstinct.action_special_effect = (WorldAction)Delegate.Combine(perfectUltraInstinct.action_special_effect, new WorldAction(CustomTraitActions.PerUl));
            perfectUltraInstinct.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);

            perfectUltraInstinct.unlock(true);
            AssetManager.traits.add(perfectUltraInstinct);
            addToList(perfectUltraInstinct);
            addToLocale(perfectUltraInstinct.id, "Perfect Ultra Instinct", "The peak of divine instinct.", "No wasted movement, only victory.");
            #endregion

            #region legendary_bloodline
            ActorTrait legendaryBloodline = new ActorTrait()
            {
                id = "legendary_bloodline",
                path_icon = $"{PathToTraitIcon}/BloodlineL",
                can_be_given = true,
                rate_inherit = AlwaysChance,
                rate_birth = NoChance,
                group_id = TraitGroupId
            };

            legendaryBloodline.base_stats = new BaseStats();
            legendaryBloodline.base_stats.set(CustomBaseStatsConstant.Damage, 150f);
            legendaryBloodline.base_stats.set(CustomBaseStatsConstant.Armor, 10f);
            legendaryBloodline.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 15f);
            legendaryBloodline.base_stats.set(CustomBaseStatsConstant.Health, 6500f);
            legendaryBloodline.base_stats.set(CustomBaseStatsConstant.Intelligence, 100f);
            legendaryBloodline.base_stats.set(CustomBaseStatsConstant.Speed, 10f);
            legendaryBloodline.base_stats.set(CustomBaseStatsConstant.Lifespan, 0f);
            legendaryBloodline.addOpposites(new List<string> { "bloodline" });
            legendaryBloodline.action_special_effect = (WorldAction)Delegate.Combine(legendaryBloodline.action_special_effect, new WorldAction(CustomTraitActions.EvoL));

            legendaryBloodline.unlock(true);
            AssetManager.traits.add(legendaryBloodline);
            addToList(legendaryBloodline);
            addToLocale(legendaryBloodline.id, "Legendary Bloodline", "Bloodline of the legendary warrior.", "A rare gift of destructive potential.");
            #endregion

            #region saiyan_legendary
            ActorTrait saiyanLegendary = new ActorTrait()
            {
                id = "saiyan_legendary",
                path_icon = $"{PathToTraitIcon}/SaiyanLegendary",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId
            };

            saiyanLegendary.base_stats = new BaseStats();
            saiyanLegendary.base_stats.set(CustomBaseStatsConstant.Damage, 150f);
            saiyanLegendary.base_stats.set(CustomBaseStatsConstant.Armor, 10f);
            saiyanLegendary.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 15f);
            saiyanLegendary.base_stats.set(CustomBaseStatsConstant.Health, 6500f);
            saiyanLegendary.base_stats.set(CustomBaseStatsConstant.Intelligence, 100f);
            saiyanLegendary.base_stats.set(CustomBaseStatsConstant.Speed, 15f);
            saiyanLegendary.addOpposites(new List<string> { "saiyan_true_form", "saiyan_true_form_4", "saiyan_true_form_5", "breaking_limit" });

            saiyanLegendary.action_special_effect = (WorldAction)Delegate.Combine(saiyanLegendary.action_special_effect, new WorldAction(CustomTraitActions.SaiyanLEvo));

            saiyanLegendary.unlock(true);
            AssetManager.traits.add(saiyanLegendary);
            addToList(saiyanLegendary);
            addToLocale(saiyanLegendary.id, "Legendary Saiyan", "The birth of a myth.", "Warrior of unmatched raw power.");
            #endregion

            #region saiyan_true_form
            ActorTrait saiyanTrueForm = new ActorTrait()
            {
                id = "saiyan_true_form",
                path_icon = $"{PathToTraitIcon}/TrueForm",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId
            };

            saiyanTrueForm.base_stats = new BaseStats();
            saiyanTrueForm.base_stats.set(CustomBaseStatsConstant.Damage, 150f);
            saiyanTrueForm.base_stats.set(CustomBaseStatsConstant.Armor, 20f);
            saiyanTrueForm.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 30f);
            saiyanTrueForm.base_stats.set(CustomBaseStatsConstant.Health, 7000f);
            saiyanTrueForm.base_stats.set(CustomBaseStatsConstant.Speed, 15f);
            saiyanTrueForm.action_special_effect = (WorldAction)Delegate.Combine(saiyanTrueForm.action_special_effect, new WorldAction(CustomTraitActions.SaiyanTEvo));
            saiyanTrueForm.addOpposites(new List<string> { "saiyan_legendary", "saiyan_true_form_4", "saiyan_true_form_5", "breaking_limit" });

            saiyanTrueForm.unlock(true);
            AssetManager.traits.add(saiyanTrueForm);
            addToList(saiyanTrueForm);
            addToLocale(saiyanTrueForm.id, "Saiyan True Form", "Evolved form of legendary strength.", "Brutality without hesitation.");
            #endregion

            #region saiyan_true_form_4
            ActorTrait saiyanTrueForm4 = new ActorTrait()
            {
                id = "saiyan_true_form_4",
                path_icon = $"{PathToTraitIcon}/Broly4",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId
            };

            saiyanTrueForm4.base_stats = new BaseStats();
            saiyanTrueForm4.base_stats.set(CustomBaseStatsConstant.Damage, 200f);
            saiyanTrueForm4.base_stats.set(CustomBaseStatsConstant.Armor, 25f);
            saiyanTrueForm4.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 40f);
            saiyanTrueForm4.base_stats.set(CustomBaseStatsConstant.Health, 7000f);
            saiyanTrueForm4.base_stats.set(CustomBaseStatsConstant.Intelligence, 10f);
            saiyanTrueForm4.base_stats.set(CustomBaseStatsConstant.Speed, 25f);
            saiyanTrueForm4.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            saiyanTrueForm.addOpposites(new List<string> { "saiyan_legendary", "saiyan_true_form", "saiyan_true_form_5", "breaking_limit" });

            saiyanTrueForm4.action_death = new WorldAction(CustomTraitActions.SaiyanT4Death);
            saiyanTrueForm4.action_special_effect = (WorldAction)Delegate.Combine(saiyanTrueForm4.action_special_effect, new WorldAction(CustomTraitActions.SaiyanT4Evo));

            saiyanTrueForm4.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);

            saiyanTrueForm4.unlock(true);
            AssetManager.traits.add(saiyanTrueForm4);
            addToList(saiyanTrueForm4);
            addToLocale(saiyanTrueForm4.id, "Saiyan True Form 4", "Fourth evolution of the legendary form.", "The berserker ascended.");
            #endregion

            #region saiyan_true_form_5
            ActorTrait saiyanTrueForm5 = new ActorTrait()
            {
                id = "saiyan_true_form_5",
                path_icon = $"{PathToTraitIcon}/Broly5",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId
            };

            saiyanTrueForm5.base_stats = new BaseStats();
            saiyanTrueForm5.base_stats.set(CustomBaseStatsConstant.Damage, 200f);
            saiyanTrueForm5.base_stats.set(CustomBaseStatsConstant.Armor, 25f);
            saiyanTrueForm5.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 40f);
            saiyanTrueForm5.base_stats.set(CustomBaseStatsConstant.Health, 7200f);
            saiyanTrueForm5.base_stats.set(CustomBaseStatsConstant.Intelligence, 10f);
            saiyanTrueForm5.base_stats.set(CustomBaseStatsConstant.Speed, 25f);
            saiyanTrueForm5.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            saiyanTrueForm5.addOpposites(new List<string> { "saiyan_legendary", "saiyan_true_form", "saiyan_true_form_4", "breaking_limit" });

            saiyanTrueForm5.action_special_effect = new WorldAction(CustomTraitActions.SaiyanT5Evo);
            saiyanTrueForm5.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);

            saiyanTrueForm5.unlock(true);
            AssetManager.traits.add(saiyanTrueForm5);
            addToList(saiyanTrueForm5);
            addToLocale(saiyanTrueForm5.id, "Saiyan True Form 5", "The final phase of the warrior form.", "No limits, no mercy.");
            #endregion

            #region breaking_limit
            ActorTrait breakingLimit = new ActorTrait()
            {
                id = "breaking_limit",
                path_icon = $"{PathToTraitIcon}/Breaking",
                can_be_given = true,
                rate_inherit = NoChance,
                rate_birth = NoChance,
                group_id = TraitGroupId
            };

            breakingLimit.base_stats = new BaseStats();
            breakingLimit.base_stats.set(CustomBaseStatsConstant.Damage, 500f);
            breakingLimit.base_stats.set(CustomBaseStatsConstant.Armor, 35f);
            breakingLimit.base_stats.set(CustomBaseStatsConstant.AttackSpeed, 75f);
            breakingLimit.base_stats.set(CustomBaseStatsConstant.Health, 10000f);
            breakingLimit.base_stats.set(CustomBaseStatsConstant.Intelligence, 200f);
            breakingLimit.base_stats.set(CustomBaseStatsConstant.Speed, 50f);
            breakingLimit.base_stats.set(CustomBaseStatsConstant.Mass, 100f);
            saiyanTrueForm5.addOpposites(new List<string> { "saiyan_legendary", "saiyan_true_form", "saiyan_true_form_4", "saiyan_true_form_5" });

            breakingLimit.action_special_effect = (WorldAction)Delegate.Combine(breakingLimit.action_special_effect, new WorldAction(CustomTraitActions.Breaking));
            breakingLimit.action_attack_target = new AttackAction(CustomTraitActions.KiPunch);

            breakingLimit.unlock(true);
            AssetManager.traits.add(breakingLimit);
            addToList(breakingLimit);
            addToLocale(breakingLimit.id, "Breaking Limit", "The strongest Saiyan ever existed!", "Strength beyond the known universe.");
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
