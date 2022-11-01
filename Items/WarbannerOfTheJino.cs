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
        Item.defense = 3000;
    }

    public override void UpdateAccessory(Player player, bool hideVisual) {
        player.GetDamage<GenericDamageClass>() += 0.25f;
        player.NoDebuff().WarbannerOfTheJino = true;
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.CobaltShield);
        recipe.AddIngredient(ItemID.CopperShortsword);
        recipe.AddTile(TileID.TinkerersWorkbench);
        recipe.Register();
    }
}