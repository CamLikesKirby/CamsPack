using BTD_Mod_Helper.Api.Display;
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
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using CamsPack;
using BTD_Mod_Helper.Api.ModOptions;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;
using BTD_Mod_Helper;

[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace SandMonkey;


public class SandMonkey : ModTower
{
    public override TowerSet TowerSet => TowerSet.Primary;
    public override string BaseTower => TowerType.DartMonkey;
    public override int Cost => 895;
    public override int TopPathUpgrades => 0;
    public override int MiddlePathUpgrades => 0;
    public override int BottomPathUpgrades => 0;
    public override bool DontAddToShop => !Settings.UnfinshedTowers == true || !Settings.CT == true;
    public override string Description => "Makes Sand to Stun and Slow the Bloons Down. Sanded bloons are immune to sharp damage (UNFINSHED)";



    public override string Icon => "SandMonkeyIcon";
    public override string Portrait => "SandMonkeyIcon";

    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        var attackModel = towerModel.GetAttackModel();
       
        attackModel.weapons[0].projectile = Game.instance.model.GetTower(TowerType.DartMonkey).GetAttackModel().weapons[0].projectile.Duplicate();
        attackModel.range = 40;
        towerModel.range = 40;
        attackModel.weapons[0].rate = 1.5f;
        var weaponModel = towerModel.GetWeapon();
        weaponModel.projectile.AddBehavior(new SlowModel("SlowModel_", 0.0f, 1, "Stun:Weak", 9999999, "Stun", true, false, null, false, false, false, 0, false));
    }

   /* public override bool IsValidCrosspath(int[] tiers)
    {
        if (!Settings.Crosspath)
        {
            return false;
        }
        return ModHelper.HasMod("UltimateCrosspathing") || base.IsValidCrosspath(tiers);
    } */
    
}



