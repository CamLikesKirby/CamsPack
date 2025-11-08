using MelonLoader;
using BTD_Mod_Helper;
using CamsPack;
using Il2CppAssets.Scripts.Models.Towers;
using PathsPlusPlus;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Data;
using BTD_Mod_Helper.Api.ModOptions;
using BTD_Mod_Helper.Api.Towers;
using System.Collections.Generic;
[assembly: MelonInfo(typeof(CamsPack.CamsPack), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CamsPack;

public class CamsPack : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<CamsPack>("CamsPack loaded! Why are you reading this?");

    }
}

public class Settings : ModSettings
{
    private static readonly ModSettingCategory TowerCategorys = new("Tower Categorys")
    {
        collapsed = true
    };
    private static readonly ModSettingCategory TowerType = new("Tower Types")
    {
        collapsed = true
    };
    private static readonly ModSettingCategory Misc = new("Misc")
    {
        collapsed = true
    }; 
    public static readonly ModSettingBool CT = new(true)
    {
        category = TowerCategorys,
        displayName = "Cams Towers",
        description = "If you want the category or not (RESTART GAME TO APPLY)",
        requiresRestart = true,
        button = true,
    };
    public static readonly ModSettingBool JT = new(true)
    {
        category = TowerCategorys,
        displayName = "Joke Towers",
        description = "If you want the category or not (RESTART GAME TO APPLY)",
        requiresRestart = true,
        button = true,
    };
    public static readonly ModSettingBool KT = new(true)
    {
        category = TowerCategorys,
        displayName = "Kirby Towers",
        description = "If you want the category or not (RESTART GAME TO APPLY)",
        requiresRestart = true,
        button = true,
    };
    public static readonly ModSettingBool OST = new(true)
    {
        category = TowerCategorys,
        displayName = "Object Show Towers",
        description = "If you want the category or not (RESTART GAME TO APPLY)",
        requiresRestart = true,
        button = true,
    };
    public static readonly ModSettingBool YT = new(true)
    {
        category = TowerCategorys,
        displayName = "Youtuber Towers",
        description = "If you want the category or not (RESTART GAME TO APPLY)",
        requiresRestart = true,
        button = true,
    };
    public static readonly ModSettingBool OpTowers = new(true)
    {
        category = TowerType,
        displayName = "Op Towers",
        description = "If you want OP Towers or not (RESTART GAME TO APPLY)",
        requiresRestart = true,
        button = true,
    };
    public static readonly ModSettingBool UselessTowers = new(true)
    {
        category = TowerType,
        displayName = "Useless Towers",
        description = "If you want useless towers or not(RESTART GAME TO APPLY)",
        requiresRestart = true,
        button = true,
    };
    public static readonly ModSettingBool UnfinshedTowers = new(true)
    {
        category = TowerType,
        displayName = "Unfinshed Towers",
        description = "If you want unfinshed towers towers or not (RESTART GAME TO APPLY)",
        requiresRestart = true,
        button = true,
    };
}

public class BananaGunPath : PathPlusPlus
{
    public override string Tower => TowerType.BananaFarm;
    public override int UpgradeCount => 5;
}

public class SabrePath : PathPlusPlus
{
    public override string Tower => TowerType.BananaFarm;
    public override int UpgradeCount => 5;
}

public class TGForthPath : PathPlusPlus
{
    public override string Tower => TowerID<TGMonkey.ThanksgivingMonkey>(0, 0, 0);
    public override int UpgradeCount => 6;
}