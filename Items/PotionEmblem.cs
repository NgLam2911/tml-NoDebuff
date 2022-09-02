using CalamityMod;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Potions;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoDebuff.Items; 

public class PotionEmblem : ModItem{
    
    public override void SetStaticDefaults() {
        Tooltip.SetDefault("No more potion sickness...\n");
        DisplayName.SetDefault("Potions Emblem");
    }

    public override void SetDefaults() {
        Item.width = 28;
        Item.height = 28;
        Item.value = 1000000;
        Item.accessory = true;
        Item.rare = ItemRarityID.LightRed;
    }

    public override void UpdateEquip(Player player) {
        player.buffImmune[BuffID.PotionSickness] = true;
        player.buffImmune[BuffID.ManaSickness] = true;
        player.potionDelayTime = 0; //Hehe
        player.NoDebuff().PotionsEmblem = true;
    }

    public override bool CanEquipAccessory(Player player, int slot, bool modded) {
        return !player.NoDebuff().PotionsEmblem;
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.AvengerEmblem);
        recipe.AddIngredient(ModContent.ItemType<SupremeHealingPotion>(), 100);
        recipe.AddIngredient(ItemID.SuperManaPotion, 100);
        recipe.AddIngredient(ItemID.LunarBar, 100);
        recipe.AddIngredient(ModContent.ItemType<CoreofCalamity>(), 10);
        recipe.AddIngredient(ModContent.ItemType<LifeAlloy>(), 10);
        recipe.AddIngredient(ModContent.ItemType<GalacticaSingularity>(), 20);
        recipe.AddIngredient(ItemID.StoneBlock, 999);
        recipe.AddIngredient(ItemID.DirtBlock, 999);
        recipe.AddIngredient(ItemID.Wood, 999);
        recipe.AddIngredient(ItemID.LifeCrystal, 50);
        recipe.AddIngredient(ItemID.LifeFruit, 50);
        recipe.AddIngredient(ItemID.HallowedBar, 50);
        recipe.AddTile(TileID.TinkerersWorkbench);
        recipe.Register();
    }
}