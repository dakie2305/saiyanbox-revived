using NeoModLoader.api.attributes;
using NeoModLoader.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SaiyanboxRevived.Content
{
    public class CustomStatusEffects
    {
        [Hotfixable]
        public static void Init()
        {
            loadCustomStatusEffects();
        }

        private static void loadCustomStatusEffects()
        {
            //Needed this material for status effects
            Material material = LibraryMaterials.instance.dict["mat_world_object_lit"];

            #region aura_blue_effect
            var auraBlueEffect = new StatusAsset()
            {
                id = "aura_blue_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_Blue", // Ensure exists
                path_icon = "ui/icons/AuraBlue"
            };

            auraBlueEffect.locale_id = $"status_title_{auraBlueEffect.id}";
            auraBlueEffect.locale_description = $"status_description_{auraBlueEffect.id}";

            auraBlueEffect.base_stats = new();
            auraBlueEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraBlueEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraBlueEffect.texture}", false);

            AssetManager.status.add(auraBlueEffect);
            addToLocale(auraBlueEffect.id, "Blue Aura", "The body is surrounded by a flickering blue energy field.");
            #endregion

            #region aura_rose_effect
            var auraRoseEffect = new StatusAsset()
            {
                id = "aura_rose_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_Rose",
                path_icon = "ui/icons/AuraRose"
            };

            auraRoseEffect.locale_id = $"status_title_{auraRoseEffect.id}";
            auraRoseEffect.locale_description = $"status_description_{auraRoseEffect.id}";

            auraRoseEffect.base_stats = new();
            auraRoseEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraRoseEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraRoseEffect.texture}", false);

            AssetManager.status.add(auraRoseEffect);
            addToLocale(auraRoseEffect.id, "Rose Aura", "A radiant pink aura of divine power.");
            #endregion

            #region aura_fallen_effect
            var auraFallenEffect = new StatusAsset()
            {
                id = "aura_fallen_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_Fallen",
                path_icon = "ui/icons/AuraFallen"
            };

            auraFallenEffect.locale_id = $"status_title_{auraFallenEffect.id}";
            auraFallenEffect.locale_description = $"status_description_{auraFallenEffect.id}";

            auraFallenEffect.base_stats = new();
            auraFallenEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraFallenEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraFallenEffect.texture}", false);

            AssetManager.status.add(auraFallenEffect);
            addToLocale(auraFallenEffect.id, "Fallen Aura", "A cursed aura of a broken warrior.");
            #endregion

            #region aura_grey_effect
            var auraGreyEffect = new StatusAsset()
            {
                id = "aura_grey_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_Grey",
                path_icon = "ui/icons/AuraGrey"
            };

            auraGreyEffect.locale_id = $"status_title_{auraGreyEffect.id}";
            auraGreyEffect.locale_description = $"status_description_{auraGreyEffect.id}";

            auraGreyEffect.base_stats = new();
            auraGreyEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraGreyEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraGreyEffect.texture}", false);

            AssetManager.status.add(auraGreyEffect);
            addToLocale(auraGreyEffect.id, "Grey Aura", "An empty aura, devoid of purpose.");
            #endregion

            #region aura_white_effect
            var auraWhiteEffect = new StatusAsset()
            {
                id = "aura_white_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_White",
                path_icon = "ui/icons/AuraWhite"
            };

            auraWhiteEffect.locale_id = $"status_title_{auraWhiteEffect.id}";
            auraWhiteEffect.locale_description = $"status_description_{auraWhiteEffect.id}";

            auraWhiteEffect.base_stats = new();
            auraWhiteEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraWhiteEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraWhiteEffect.texture}", false);

            AssetManager.status.add(auraWhiteEffect);
            addToLocale(auraWhiteEffect.id, "White Aura", "A pure aura of divine clarity.");
            #endregion

            #region aura_black_effect
            var auraBlackEffect = new StatusAsset()
            {
                id = "aura_black_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_Black",
                path_icon = "ui/icons/AuraBlack"
            };

            auraBlackEffect.locale_id = $"status_title_{auraBlackEffect.id}";
            auraBlackEffect.locale_description = $"status_description_{auraBlackEffect.id}";

            auraBlackEffect.base_stats = new();
            auraBlackEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraBlackEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraBlackEffect.texture}", false);

            AssetManager.status.add(auraBlackEffect);
            addToLocale(auraBlackEffect.id, "Black Aura", "An aura of absolute void and power.");
            #endregion

            #region aura_pink_effect
            var auraPinkEffect = new StatusAsset()
            {
                id = "aura_pink_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_Pink",
                path_icon = "ui/icons/AuraPink"
            };

            auraPinkEffect.locale_id = $"status_title_{auraPinkEffect.id}";
            auraPinkEffect.locale_description = $"status_description_{auraPinkEffect.id}";

            auraPinkEffect.base_stats = new();
            auraPinkEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraPinkEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraPinkEffect.texture}", false);

            AssetManager.status.add(auraPinkEffect);
            addToLocale(auraPinkEffect.id, "Pink Aura", "A playful aura radiating chaotic energy.");
            #endregion

            #region aura_t5_effect
            var auraT5Effect = new StatusAsset()
            {
                id = "aura_t5_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_T5",
                path_icon = "ui/icons/AuraT5"
            };

            auraT5Effect.locale_id = $"status_title_{auraT5Effect.id}";
            auraT5Effect.locale_description = $"status_description_{auraT5Effect.id}";

            auraT5Effect.base_stats = new();
            auraT5Effect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraT5Effect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraT5Effect.texture}", false);

            AssetManager.status.add(auraT5Effect);
            addToLocale(auraT5Effect.id, "T5 Aura", "An aura blazing with transcendental force.");
            #endregion

            #region aura_breaking_effect
            var auraBreakingEffect = new StatusAsset()
            {
                id = "aura_breaking_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_Breaking",
                path_icon = "ui/icons/AuraBreaking"
            };

            auraBreakingEffect.locale_id = $"status_title_{auraBreakingEffect.id}";
            auraBreakingEffect.locale_description = $"status_description_{auraBreakingEffect.id}";

            auraBreakingEffect.base_stats = new();
            auraBreakingEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraBreakingEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraBreakingEffect.texture}", false);

            AssetManager.status.add(auraBreakingEffect);
            addToLocale(auraBreakingEffect.id, "Breaking Limit Aura", "The aura of a Saiyan surpassing all limits.");
            #endregion

            #region aura_red_effect
            var auraRedEffect = new StatusAsset()
            {
                id = "aura_red_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_Red",
                path_icon = "ui/icons/AuraRed"
            };

            auraRedEffect.locale_id = $"status_title_{auraRedEffect.id}";
            auraRedEffect.locale_description = $"status_description_{auraRedEffect.id}";

            auraRedEffect.base_stats = new();
            auraRedEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraRedEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraRedEffect.texture}", false);

            AssetManager.status.add(auraRedEffect);
            addToLocale(auraRedEffect.id, "Red Aura", "An aura of ferocious, burning energy.");
            #endregion

            #region aura_blues_effect
            var auraBlueSEffect = new StatusAsset()
            {
                id = "aura_blues_effect",
                render_priority = 5,
                duration = 5f,
                animated = true,
                is_animated_in_pause = true,
                can_be_flipped = true,
                use_parent_rotation = false,
                removed_on_damage = false,
                cancel_actor_job = false,
                need_visual_render = true,
                scale = 1.0f,
                tier = StatusTier.Advanced,
                material_id = "mat_world_object_lit",
                material = material,
                texture = "Aura_BlueS",
                path_icon = "ui/icons/AuraBlueS"
            };

            auraBlueSEffect.locale_id = $"status_title_{auraBlueSEffect.id}";
            auraBlueSEffect.locale_description = $"status_description_{auraBlueSEffect.id}";

            auraBlueSEffect.base_stats = new();
            auraBlueSEffect.base_stats.set(CustomBaseStatsConstant.Scale, 0.03f);

            auraBlueSEffect.sprite_list = SpriteTextureLoader.getSpriteList($"effects/{auraBlueSEffect.texture}", false);

            AssetManager.status.add(auraBlueSEffect);
            addToLocale(auraBlueSEffect.id, "Blue Spark Aura", "A refined divine aura crackling with power.");
            #endregion


        }

        private static void addToLocale(string id, string name, string description)
        {
            LM.AddToCurrentLocale($"status_title_{id}", name);
            LM.AddToCurrentLocale($"status_description_{id}", description);
        }
    }
}
