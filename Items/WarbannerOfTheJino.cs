using CalamityMod.Items.Accessories;
using CalamityMod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoDebuff.Items; 

public class WarbannerOfTheJino : ModItem{
    
    public override void SetStaticDefaults() {
        Tooltip.SetDefault("Give you the highest defense point and damage buff in the game ...\n25% increase to all damage");
        DisplayName.SetDefault("Warbanner of The Jino");
    }

    public override void SetDefaults() {
        Item.width = 600;
        Item.height = 800;
        Item.value = 400000;
        Item.accessory = true;
        Item.rare = ItemRarityID.LightPurple;
        Item.defense = 500;
    }

    public override void UpdateEquip(Player player) {
        player.GetDamage<GenericDamageClass>() += 0.25f;
        player.NoDebuff().WarbannerOfTheJino = true;
    }

    public override bool CanEquipAccessory(Player player, int slot, bool modded) {
        return !player.NoDebuff().WarbannerOfTheJino;
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.AvengerEmblem);
        recipe.AddIngredient(ItemID.CelestialEmblem);
        recipe.AddIngredient(ItemID.DestroyerEmblem);
        recipe.AddIngredient(ItemID.RangerEmblem);
        recipe.AddIngredient(ItemID.SorcererEmblem);
        recipe.AddIngredient(ItemID.SummonerEmblem);
        recipe.AddIngredient(ItemID.WarriorEmblem);
        recipe.AddIngredient(ModContent.ItemType<RogueEmblem>());
        recipe.AddIngredient(ItemID.AnkhShield);
        recipe.AddIngredient(ItemID.CobaltShield);
        recipe.AddIngredient(ItemID.PaladinsShield);
        recipe.AddIngredient(ItemID.ObsidianShield);
        recipe.AddIngredient(ItemID.FrozenShield);
        recipe.AddIngredient(ItemID.LunarBar, 100);
        recipe.AddIngredient(ModContent.ItemType<CoreofCalamity>(), 10);
        recipe.AddIngredient(ModContent.ItemType<LifeAlloy>(), 10);
        recipe.AddIngredient(ModContent.ItemType<GalacticaSingularity>(), 20);
        recipe.AddIngredient(ItemID.StoneBlock, 999);
        recipe.AddIngredient(ItemID.DirtBlock, 999);
        recipe.AddIngredient(ItemID.Wood, 999);
        recipe.AddTile(TileID.TinkerersWorkbench);
        recipe.Register();
    }
}