using System.Linq;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using UnityEngine;

namespace SandMonkey.Displays
{
    public class SandMonkeyBaseDisplay : ModTowerDisplay<SandMonkey>
    {
        public override string BaseDisplay => GetDisplay(TowerType.DartMonkey);

        public override bool UseForTower(int[] tiers)
        {
            return tiers.Max() < 5;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, "SandMonkeyBlinkingDisplay");
            SetMeshTexture(node, Name, 2);
            node.RemoveBone("DartMonkeyDart");
        }
    }
}