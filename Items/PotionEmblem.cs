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

    public override void UpdateAccessory(Player player, bool hideVisual) {
        player.buffImmune[BuffID.PotionSickness] = true;
        player.buffImmune[BuffID.ManaSickness] = true;
        player.potionDelayTime = 0; //Hehe
        player.NoDebuff().PotionsEmblem = true;
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.LifeCrystal, 2);
        recipe.AddIngredient(ItemID.CopperBar, 10);
        recipe.AddIngredient(ItemID.HealingPotion);
        recipe.AddTile(TileID.WorkBenches);
        recipe.Register();
        
        Recipe recipe2 = CreateRecipe();
        recipe2.AddIngredient(ItemID.LifeCrystal, 2);
        recipe2.AddIngredient(ItemID.TinBar, 10);
        recipe2.AddIngredient(ItemID.HealingPotion);
        recipe2.AddTile(TileID.WorkBenches);
        recipe2.Register();
    }
}