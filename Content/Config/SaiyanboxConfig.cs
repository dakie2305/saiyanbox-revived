using SaiyanboxRevived;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiyanboxRevived.Content
{
    public class SaiyanboxConfig
    {
        public static bool EnableAutoFavorite { get; set; } = false;
        public static bool UnlockLegendTraits { get; set; } = false;

        public static void UnlockLegendTraitsSwitchConfigCallBack(bool pCurrentValue)
        {
            UnlockLegendTraits = pCurrentValue;
            SaiyanboxMain.LogInfo($"Set unlock legend traits to '{UnlockLegendTraits}'");
        }
        public static void AutoFavoriteEnableSwitchConfigCallBack(bool pCurrentValue)
        {
            EnableAutoFavorite = pCurrentValue;
            SaiyanboxMain.LogInfo($"Set Enable Auto Favorite unit to '{EnableAutoFavorite}'");
        }
    }
}
