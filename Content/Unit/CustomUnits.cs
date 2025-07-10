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
            jiren.use_phenotypes = true;
            jiren.unit_other = true;
            jiren.has_baby_form = false; //no baby form of course

            jiren.can_talk_with = false;
            jiren.is_humanoid = true;
            jiren.can_be_cloned = false;
            jiren.can_be_killed_by_divine_light = false;
            jiren.control_can_talk = false;
            jiren.can_have_subspecies = false;
            jiren.inspect_home = false;
            jiren.flying = false;
            jiren.disable_jump_animation = true;
            jiren.has_advanced_textures = false;
            jiren.can_be_surprised = false;
            jiren.can_turn_into_ice_one = false;
            jiren.can_turn_into_mush = false;
            jiren.can_turn_into_demon_in_age_of_chaos = false;
            jiren.can_turn_into_zombie = false;
            jiren.has_soul = true;
            jiren.actor_size = ActorSize.S13_Human;
            jiren.job = AssetLibrary<ActorAsset>.a<string>(new string[]
            {
                 "dragon_job"
            });
            jiren.shadow_texture = "unitShadow_7";
            jiren.split_ai_update = false;
            jiren.animation_speed_based_on_walk_speed = false;
            jiren.experience_given = 100;
            jiren.base_stats = new();
            jiren.base_stats.set(CustomBaseStatsConstant.Lifespan, 0f);
            jiren.base_stats.set(CustomBaseStatsConstant.Health, 50000f);
            jiren.base_stats.set(CustomBaseStatsConstant.Damage, 1250f);
            jiren.base_stats.set(CustomBaseStatsConstant.Speed, 25f);
            jiren.base_stats.set(CustomBaseStatsConstant.Armor, 80f);
            jiren.base_stats.set(CustomBaseStatsConstant.Stamina, 800f);
            jiren.base_stats.set(CustomBaseStatsConstant.Mana, 800f);
            jiren.base_stats.set(CustomBaseStatsConstant.Scale, 0.04f);


            jiren.icon = "iconJiren";
            jiren.name_taxonomic_kingdom = "animalia";
            jiren.name_taxonomic_phylum = "chordata";
            jiren.name_taxonomic_class = "mammalia";
            jiren.name_taxonomic_order = "primates";
            jiren.name_taxonomic_family = "hominidae";
            jiren.name_taxonomic_genus = "homo";
            jiren.name_taxonomic_species = "sapiens";
            jiren.collective_term = "group_kaleidoscope";
            jiren.name_locale = "Jiren";
            jiren.traits = new();
            jiren.traits.Add("Jirens Aura");
            jiren.traits.Add("Jiren");

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
