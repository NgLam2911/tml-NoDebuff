using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ItemRarityID = Terraria.ID.ItemRarityID;
using CalamityMod.Buffs.DamageOverTime;
using CalamityMod.Buffs.StatDebuffs;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Placeables;

namespace NoDebuff.Items; 

public class HuyShield : ModItem {
    
    public override void SetStaticDefaults() {
        Tooltip.SetDefault("The ultimate accessory that make player immune to most Calamity debuffs from the enemies.\nInclude some vanilla debuffs...");
        DisplayName.SetDefault("Huy's Shield");
    }

    public override void SetDefaults() {
        Item.width = 150;
        Item.height = 158;
        Item.value = 500000;
        Item.accessory = true;
        Item.rare = ItemRarityID.LightPurple;
        Item.defense = 100;
    }

    public override void UpdateAccessory(Player player, bool hideVisual) {
        player.NoDebuff().HuyShield = true;
        player.noFallDmg = true;
        player.noKnockback = true;
        player.lavaImmune = true;
        player.immuneNoBlink = true;
        // Calamity Debuffs
        // Abyssal Flames - Removed
        player.buffImmune[ModContent.BuffType<ArmorCrunch>()] = true;
        player.buffImmune[ModContent.BuffType<AstralInfectionDebuff>()] = true;
        player.buffImmune[ModContent.BuffType<BrimstoneFlames>()] = true;
        player.buffImmune[ModContent.BuffType<BurningBlood>()] = true;
        player.buffImmune[ModContent.BuffType<CrushDepth>()] = true;
        player.buffImmune[ModContent.BuffType<Dragonfire>()] = true;
        player.buffImmune[ModContent.BuffType<DoGExtremeGravity>()] = true;
        player.buffImmune[ModContent.BuffType<FishAlert>()] = true;
        player.buffImmune[ModContent.BuffType<GlacialState>()] = true;
        player.buffImmune[ModContent.BuffType<GodSlayerInferno>()] = true;
        player.buffImmune[ModContent.BuffType<HolyFlames>()] = true;
        player.buffImmune[ModContent.BuffType<HolyInferno>()] = true;
        player.buffImmune[ModContent.BuffType<IcarusFolly>()] = true;
        player.buffImmune[ModContent.BuffType<Irradiated>()] = true;
        player.buffImmune[ModContent.BuffType<Nightwither>()] = true;
        player.buffImmune[ModContent.BuffType<Plague>()] = true;
        player.buffImmune[ModContent.BuffType<SulphuricPoisoning>()] = true;
        player.buffImmune[ModContent.BuffType<VulnerabilityHex>()] = true;
        player.buffImmune[ModContent.BuffType<Warped>()] = true;
        player.buffImmune[ModContent.BuffType<WeakPetrification>()] = true;
        player.buffImmune[ModContent.BuffType<WhisperingDeath>()] = true;
        //Calamity Environments
        player.buffImmune[ModContent.BuffType<WeakBrimstoneFlames>()] = true;
        player.buffImmune[ModContent.BuffType<SearingLava>()] = true;
        player.buffImmune[ModContent.BuffType<WitherDebuff>()] = true;
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ItemID.AnkhShield);
        recipe.AddIngredient(ItemID.HallowedBar, 10);
        recipe.AddIngredient(ItemID.LunarBar, 5);
        recipe.AddIngredient(ModContent.ItemType<UelibloomBar>(), 5);
        recipe.AddIngredient(ModContent.ItemType<AstralBar>(), 5);
        recipe.AddIngredient(ModContent.ItemType<CoreofCalamity>());
        recipe.AddIngredient(ModContent.ItemType<LifeAlloy>());
        recipe.AddIngredient(ModContent.ItemType<GalacticaSingularity>());
        recipe.AddTile(TileID.TinkerersWorkbench);
        recipe.Register();
    }
}