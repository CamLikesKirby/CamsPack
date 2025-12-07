using System.Linq;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Unity.Display;
using BTD_Mod_Helper.Api.Display;

namespace FreeDartMonkey.Displays
{
    public class FreeDartMonkeyBaseDisplay : ModTowerDisplay<FreeDartMonkey>
    {
        public override string BaseDisplay => GetDisplay(TowerType.DartMonkey);

        public override bool UseForTower(int[] tiers)
        {
            return tiers.Sum() == 0;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }

    public class FreeDartMonkeyTrueDisplay : ModTowerDisplay<FreeDartMonkey>
    {
        public override string BaseDisplay => GetDisplay(TowerType.DartMonkey);

        public override bool UseForTower(int[] tiers)
        {
            return tiers[1] == 1;
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, "FreeDartMonkeyTrueDisplayBlinking");
            SetMeshTexture(node, Name, 2);
        }
    }
}