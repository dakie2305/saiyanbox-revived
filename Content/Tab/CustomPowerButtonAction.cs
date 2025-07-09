using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiyanboxRevived.Content
{
    internal class CustomPowerButtonAction
    {
        internal static bool spawnCustomSaiyanUnits(WorldTile pTile, string pPowerID)
        {
            GodPower godPower = AssetManager.powers.get(pPowerID);
            MusicBox.playSound("event:/SFX/UNIQUE/SpawnWhoosh", (float)pTile.pos.x, (float)pTile.pos.y, false, false);
            EffectsLibrary.spawn("fx_spawn", pTile, null, null, 0f, -1f, -1f, null);
            string[] actor_asset_ids = godPower.actor_asset_ids;
            string pStatsID;
            if (actor_asset_ids != null && actor_asset_ids.Length != 0)
            {
                pStatsID = godPower.actor_asset_ids.GetRandom<string>();
            }
            else
            {
                pStatsID = godPower.actor_asset_id;
            }
            Actor pActor = World.world.units.spawnNewUnitByPlayer(pStatsID, pTile, true, true, godPower.actor_spawn_height, null);
            return true;
        }
    }
}
