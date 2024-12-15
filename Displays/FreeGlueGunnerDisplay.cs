/*uusing System.Linq;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnityEngine;

namespace FreeGlueGunnerMonkey.Displays
{
    public class FreeGlueGunnerBaseDisplay : ModTowerDisplay<FreeGlueGunner>
    {
        public override string BaseDisplay => GetDisplay(TowerType.GlueGunner);

        public override bool UseForTower(int[] tiers)
        {
            return tiers.Sum() == 0;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
//#if DEBUG
    //        node.PrintInfo();
  ////          node.SaveMeshTexture();
//#endif
        }
    }

    public class FreeGlueGunnerTrueDisplay : ModTowerDisplay<FreeGlueGunner>
    {
        public override string BaseDisplay => GetDisplay(TowerType.GlueGunner);

        public override bool UseForTower(int[] tiers)
        {
            return tiers[1] == 1;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
            SetMeshTexture(node, "FreeGlueGunnerTrueBlinkingDisplay", 1);
        }
    }
}
*/