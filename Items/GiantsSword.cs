using CalamityMod;
using NoDebuff.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoDebuff.Items; 

public class GiantsSword : ModItem{
    
    public override void SetStaticDefaults() {
        Tooltip.SetDefault("Made by the giants with the ultimate power\nBreak enemy armor");
        DisplayName.SetDefault("Giant's Sword");
    }

    public override void SetDefaults() {
        Item.width = 140;
        Item.height = 140;
        Item.maxStack = 1;
        Item.value = 10000000;
        Item.rare = ItemRarityID.LightRed;
        Item.damage = 500;
        Item.knockBack = 20f;
        Item.crit = 90;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTime = 5;
        Item.useAnimation = 5;
        Item.autoReuse = true;
        Item.UseSound = SoundID.Item1;
        Item.scale = 1.8f;
        Item.DamageType = DamageClass.Melee;
        Item.useTurn = true;
    }

    public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit) {
        target.AddBuff(ModContent.BuffType<BrokenArmor>(), 1000);
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.HallowedBar, 20);
        recipe.AddIngredient(ItemID.TitaniumSword);
        recipe.AddIngredient(ItemID.TrueExcalibur);
        recipe.AddIngredient(ItemID.SoulofNight, 20);
        recipe.AddIngredient(ItemID.SoulofLight, 20);
        recipe.AddIngredient(ItemID.FragmentSolar, 5);
        recipe.AddIngredient(ItemID.FragmentVortex, 5);
        recipe.AddIngredient(ItemID.FragmentNebula, 5);
        recipe.AddIngredient(ItemID.FragmentStardust, 5);
        recipe.AddTile(TileID.LunarCraftingStation);
        recipe.Register();
    }
}