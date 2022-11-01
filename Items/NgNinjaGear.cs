using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoDebuff.Items; 

public class NgNinjaGear : ModItem{
    
    public override void SetStaticDefaults() {
        Tooltip.SetDefault("+100% attack speed\nHave 99,99% chance to dodge an incomming attack\n+50% movement speed\nReduce max health to 1 and defense to 0\nGain ability to dash\nAllow to infinite fly time");
        DisplayName.SetDefault("Ng Ninja Gear");
    }

    public override void SetDefaults() {
        Item.width = 28;
        Item.height = 28;
        Item.value = 500000;
        Item.accessory = true;
        Item.rare = ItemRarityID.LightRed;
        Item.master = true;
        Item.masterOnly = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual) {
        player.NoDebuff().NgNinjaGear = true;
        player.GetAttackSpeed<GenericDamageClass>() += 1f;
        player.dash = 1;
        player.dashType = 1;
        player.dashDelay = 0;
        player.moveSpeed += 0.5f;
        player.statLife = 1;
        player.statDefense -= 99999;
        player.rocketTimeMax += 999999999;
        player.wingTime += 999999999;
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.MasterNinjaGear);
        recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
        recipe.AddTile(TileID.TinkerersWorkbench);
        recipe.Register();
    }
}