using CalamityMod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoDebuff.Items; 

public class RenCard : ModItem {
    
    public override void SetStaticDefaults() {
        Tooltip.SetDefault("Made you immune to most vanilla debuff in the game ...");
        DisplayName.SetDefault("Ren's Card");
    }

    public override void SetDefaults() {
        Item.width = 602;
        Item.height = 751;
        Item.value = 400000;
        Item.accessory = true;
        Item.rare = ItemRarityID.Yellow;
    }

    public override void UpdateEquip(Player player) {
        int[] debuffs = {
            BuffID.Poisoned,
            BuffID.Darkness,
            BuffID.Cursed,
            BuffID.OnFire,
            BuffID.Bleeding,
            BuffID.Confused,
            BuffID.Slow,
            BuffID.Weak,
            BuffID.Silenced,
            BuffID.BrokenArmor,
            BuffID.Horrified,
            BuffID.TheTongue,
            BuffID.CursedInferno,
            BuffID.Frostburn,
            BuffID.Chilled,
            BuffID.Frozen,
            BuffID.Ichor,
            BuffID.Venom,
            BuffID.Blackout,
            BuffID.Electrified,
            BuffID.MoonLeech, //Moon Bite
            BuffID.Rabies, //Feral Bite
            BuffID.Webbed,
            BuffID.Stoned,
            BuffID.Obstructed,
            BuffID.VortexDebuff, // Distorted
            BuffID.WitheredArmor,
            BuffID.WitheredWeapon,
            BuffID.OgreSpit, // Oozed
            BuffID.ChaosState,
            BuffID.Suffocation,
            BuffID.Burning,
            BuffID.Stinky,
            BuffID.WindPushed, // Mighty Wind
            BuffID.NoBuilding, // Creative Shock
            BuffID.Starving,
            BuffID.Hunger,
            BuffID.NeutralHunger,
            BuffID.Midas,
            BuffID.Oiled,
            BuffID.Wet,
            BuffID.Slimed,
            BuffID.TentacleSpike,
            BuffID.GelBalloonBuff,
            BuffID.ShadowFlame,
            BuffID.BetsysCurse,
            BuffID.BoneJavelin, // Penetrated
            BuffID.Daybreak,
            BuffID.StardustMinionBleed, // Celled
            BuffID.DryadsWardDebuff, // Dryad's Bane
            BuffID.Dazed, // Unobtainable debuff
            BuffID.SugarRush // Unobtainable debuff
        };
        foreach (var debuff in debuffs) {
            player.buffImmune[debuff] = true;
        }

        player.NoDebuff().RenCard = true;
    }

    public override bool CanEquipAccessory(Player player, int slot, bool modded) {
        return !player.NoDebuff().RenCard;
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.AnkhShield);
        recipe.AddIngredient(ItemID.CobaltShield);
        recipe.AddIngredient(ItemID.PaladinsShield);
        recipe.AddIngredient(ItemID.ObsidianShield);
        recipe.AddIngredient(ItemID.FrozenShield);
        recipe.AddIngredient(ItemID.HallowedBar, 50);
        recipe.AddIngredient(ItemID.LunarBar, 50);
        recipe.AddIngredient(ModContent.ItemType<CoreofCalamity>(), 10);
        recipe.AddIngredient(ModContent.ItemType<LifeAlloy>(), 10);
        recipe.AddIngredient(ModContent.ItemType<GalacticaSingularity>(), 20);
        recipe.AddTile(TileID.TinkerersWorkbench);
        recipe.Register();
    }


}