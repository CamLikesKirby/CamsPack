using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity;
using MelonLoader;
using CamsPack;
using BTD_Mod_Helper.Api.Enums;
using Il2Cpp;

[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace FreeDartMonkey;


public class FreeDartMonkey : ModTower
{

    public override string BaseTower => TowerType.DartMonkey;

    public override TowerSet TowerSet => TowerSet.Primary;
    public override int Cost => 0;
    public override int TopPathUpgrades => 0;
    public override int MiddlePathUpgrades => 1;
    public override int BottomPathUpgrades => 0;
    public override string Description => "(THIS IS A JOKE TOWER IT WILL PROBABLY NOT BE BALANCED) Free Dart Monkey try to give him his true power";
    public override bool DontAddToShop => !Settings.OpTowers == true || !Settings.JT == true;
    public override string Icon => VanillaSprites.DartMonkey000;

    public override string Portrait => VanillaSprites.DartMonkey000;

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        var attackModel = towerModel.GetAttackModel();
        var weaponModel = towerModel.GetWeapon();
        attackModel.weapons[0].projectile = Game.instance.model.GetTower(TowerType.DartMonkey).GetAttackModel().weapons[0].projectile.Duplicate();
        attackModel.weapons[0].projectile.GetDamageModel().damage = 0;
        attackModel.weapons[0].rate = 1000;
        attackModel.range = 0;
        towerModel.range = 0;
        attackModel.weapons[0].projectile.pierce = 0;
    }

    public class TheTrueFreeDartMonkey : ModUpgrade<FreeDartMonkey>
    {
        // public override string Portrait => "Don't need to override this, using the default of Pair-Portrait.png";
        // public override string Icon => "Don't need to override this, using the default of Pair-Icon.png";
        public override string Portrait => "LuigiIcon";
        public override int Path => MIDDLE;
        public override int Tier => 1;
        public override int Cost => 3000000;

        // public override string DisplayName => "Don't need to override this, the default turns it into 'Pair'"

        public override string Description => "HIS TRUE POWER!";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var weaponModel = towerModel.GetWeapon();
            attackModel.range = 9999999999999999999;
            towerModel.range = 9999999999999999999;
            attackModel.weapons[0].projectile.pierce += 999999999999999999;
            attackModel.weapons[0].projectile.maxPierce = 0;
            attackModel.weapons[0].projectile.GetDamageModel().damage = 999999999;
            towerModel.AddBehavior(new OverrideCamoDetectionModel("OverrideCamoDetectionModel", true));
            towerModel.towerSelectionMenuThemeId = "Camo";
            attackModel.weapons[0].projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
            attackModel.weapons[0].rate = 0.95f;
            towerModel.GetAttackModel().attackThroughWalls = true;
            attackModel.weapons[0].projectile.ignoreBlockers = true;
            towerModel.RemoveBehavior<TravelStraitModel>();
            weaponModel.projectile.AddBehavior(new TravelStraitModel("TravelStraitModel_Projectile", 1000, 1000));
            var projectile = attackModel.weapons[0].projectile;
            projectile.AddBehavior(new TrackTargetModel("Testname", 9999999, true, false, 144, false, 300, false, true, false));
        }

    }
}