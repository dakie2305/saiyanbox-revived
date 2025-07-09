using NeoModLoader.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SaiyanboxRevived.Content
{
    internal class CustomUnits
    {
        public static void Init()
        {
            loadCustomUnits();
        }

        private static void loadCustomUnits()
        {
            var jiren = AssetManager.actor_library.clone("jiren", "$mob$");
            jiren.name_template_sets = AssetLibrary<ActorAsset>.a<string>(new string[]
                {
                "demon_set"
                });
            jiren.id = "jiren";
            jiren.kingdom_id_wild = "demon";
            jiren.kingdom_id_civilization = "miniciv_demon";
            jiren.architecture_id = "civ_demon";
            jiren.banner_id = "civ_demon";
            jiren.use_phenotypes = false;
            jiren.can_flip = false; //no flipping texture
            jiren.unit_other = true;
            jiren.has_baby_form = false; //no baby form of course

            jiren.can_talk_with = false;
            jiren.control_can_talk = false;
            jiren.can_have_subspecies = false;
            jiren.inspect_home = false;
            jiren.flying = true;
            jiren.has_advanced_textures = false;
            jiren.has_soul = true;

            jiren.base_stats = new();
            jiren.base_stats.set(CustomBaseStatsConstant.Lifespan, 30f);
            jiren.base_stats.set(CustomBaseStatsConstant.Health, 100f);
            jiren.base_stats.set(CustomBaseStatsConstant.Damage, 15f);
            jiren.base_stats.set(CustomBaseStatsConstant.Speed, 15f);
            jiren.base_stats.set(CustomBaseStatsConstant.Scale, 0.09f);

            jiren.icon = "iconButterfly";
            jiren.name_taxonomic_kingdom = "animalia";
            jiren.name_taxonomic_phylum = "arthropoda";
            jiren.name_taxonomic_class = "insecta";
            jiren.name_taxonomic_order = "lepidoptera";
            jiren.name_taxonomic_family = "nymphalidae";
            jiren.name_taxonomic_genus = "danaus";
            jiren.name_taxonomic_species = "plexippus";
            jiren.collective_term = "group_kaleidoscope";
            jiren.name_locale = "Bat";
            jiren.icon = "iconButterfly";

            jiren.animation_walk = new string[] { "walk_0", "walk_1", "walk_2", "walk_3" };
            jiren.animation_swim = new string[] { "swim_0", "swim_1", "swim_2", "swim_3", "swim_4", "swim_5" };
            jiren.animation_idle = new string[] { "idle_0", "idle_1" };

            jiren._cached_sprite = Resources.Load<Sprite>("actors/species/other/Jiren/heads_male/walk_0");
            jiren.ignored_by_infinity_coin = false;

            jiren.max_random_amount = 6;
            //jiren.action_death = (WorldAction)Delegate.Combine(jiren.action_death, new WorldAction(ActionLibrary.tryToCreatePlants));
            AssetManager.actor_library.loadShadow(jiren);
            AssetManager.actor_library.loadTexturesAndSprites(jiren);
            addToLocale($"{jiren.id}", "Jiren", "One of the strongest being in the universe!");

        }

        private static void addToLocale(string id, string name, string description)
        {
            LM.AddToCurrentLocale($"{id}", name);
            LM.AddToCurrentLocale($"{id}_description", description);
        }
    }
}
