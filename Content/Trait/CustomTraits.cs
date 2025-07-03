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

        private static void loadCustomLegendTraits()
        {

        }

        private static void loadCustomTrait()
        {

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
