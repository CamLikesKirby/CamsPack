/*using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using MelonLoader;
using System;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using CamsPack;
using System.Collections.Generic;
using System.Linq;
using BTD_Mod_Helper.Api.Enums;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;

[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace FreeGlueGunnerMonkey;


public class FreeGlueGunner : ModTower<JokeTowers>
{

    public override string BaseTower => "GlueGunner-200";
    public override int Cost => 0;
    public override int TopPathUpgrades => 0;
    public override int MiddlePathUpgrades => 1;
    public override int BottomPathUpgrades => 0;
    public override string Description => "Free Glue Gunner Monkey try to give him his true power";
    public override bool DontAddToShop => !Settings.OpTowers == true;
    public override string Icon => VanillaSprites.GlueGunner000;

    public override string Portrait => VanillaSprites.GlueGunner000;

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        var attackModel = towerModel.GetAttackModel();
        var weaponModel = towerModel.GetWeapon();
        attackModel.weapons[0].projectile = Game.instance.model.GetTower(TowerType.GlueGunner, 2).GetAttackModel().weapons[0].projectile.Duplicate();
        attackModel.weapons[0].rate = 1000;
        attackModel.range = 0;
        towerModel.range = 0;
        attackModel.weapons[0].projectile.pierce = 0;
    }
    public override int GetTowerIndex(List<TowerDetailsModel> towerSet)
    {
        return towerSet.First(model => model.towerId == TowerType.GlueGunner).towerIndex + 1;
    }

    public class TheTrueFreeGlueGunnerMonkey : ModUpgrade<FreeGlueGunner>
    {
        // public override string Portrait => "Don't need to override this, using the default of Pair-Portrait.png";
        // public override string Icon => "Don't need to override this, using the default of Pair-Icon.png";
        public override string Portrait => "LuigiIcon";
        public override int Path => MIDDLE;
        public override int Tier => 1;
        public override int Cost => 3000000;

        // public override string DisplayName => "Don't need to override this, the default turns it into 'Pair'"

        public override string Description => "THE MOST POWERFUL GLUE EVER!!!";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            attackModel.range = 9999999999999999999;
            towerModel.range = 9999999999999999999;
            attackModel.weapons[0].projectile.pierce += 999999999999999999;
           // attackModel.weapons[0].projectile.GetDamageModel().damage = 999999999;
            towerModel.AddBehavior(new OverrideCamoDetectionModel("OverrideCamoDetectionModel", true));
            towerModel.towerSelectionMenuThemeId = "Camo";
          //  attackModel.weapons[0].projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
            attackModel.weapons[0].rate = 0.95f;
            towerModel.GetAttackModel().attackThroughWalls = true;
            attackModel.weapons[0].projectile.ignoreBlockers = true;
            towerModel.RemoveBehavior<TravelStraitModel>();
            weaponModel.projectile.AddBehavior(new TravelStraitModel("TravelStraitModel_Projectile", 1000, 1000));
            towerModel.RemoveBehavior<SlowModel>();
            weaponModel.projectile.AddBehavior(new SlowModel("SlowModel_", 0.5f, 5000, "Glue", 9999999, "GlueBasic", true, false, null, false, true, false, 6, false));
            towerModel.RemoveBehavior<DamageOverTimeModel>();
            var DamagerOT = Game.instance.model.GetTowerFromId("GlueGunner-500").GetWeapon().projectile.GetBehavior<DamageOverTimeModel>().Duplicate<DamageOverTimeModel>();
            DamagerOT.damage = 10;
            attackModel.weapons[0].projectile.AddBehavior(DamagerOT);
            var projectile = attackModel.weapons[0].projectile;
            projectile.AddBehavior(new TrackTargetModel("Testname", 9999999, true, false, 144, false, 300, false, true));
        }

    }
}

*/