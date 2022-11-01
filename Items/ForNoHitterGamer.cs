using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoDebuff.Items; 

public class ForNoHitterGamer : ModItem{
    
    public override void SetStaticDefaults() {
        Tooltip.SetDefault("You take any damage? You die.");
        DisplayName.SetDefault("For No-Hitter Gamer");
    }

    public override void SetDefaults() {
        Item.width = 28;
        Item.height = 28;
        Item.value = 500000;
        Item.accessory = true;
        Item.rare = ItemRarityID.LightRed;
    }

    public override void UpdateAccessory(Player player, bool hideVisual) {
        player.NoDebuff().NoHitterGamer = true;
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.DirtBlock);
        recipe.Register();
    }
}