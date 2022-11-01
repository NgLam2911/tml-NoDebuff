using CalamityMod.Buffs.DamageOverTime;
using CalamityMod.Buffs.StatDebuffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoDebuff.Items; 

public class RingOfNoDebuff : ModItem{
    
    public override void SetStaticDefaults() {
        Tooltip.SetDefault("Everything about NoDebuff.\n+40% damage\nImmune to most debuff in the game include Calamity");
        DisplayName.SetDefault("Ring of NoDebuff");
    }

    public override void SetDefaults() {
        Item.width = 28;
        Item.height = 28;
        Item.value = 400000;
        Item.accessory = true;
        Item.rare = ItemRarityID.LightPurple;
        Item.defense = 500;
    }

    public override void UpdateAccessory(Player player, bool hideVisual) {
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
            BuffID.SugarRush, // Unobtainable debuff
            BuffID.PotionSickness,
            BuffID.ManaSickness,
            ModContent.BuffType<ArmorCrunch>(),
            ModContent.BuffType<AstralInfectionDebuff>(),
            ModContent.BuffType<BrimstoneFlames>(),
            ModContent.BuffType<BurningBlood>(),
            ModContent.BuffType<CrushDepth>(),
            ModContent.BuffType<Dragonfire>(),
            ModContent.BuffType<DoGExtremeGravity>(),
            ModContent.BuffType<FishAlert>(),
            ModContent.BuffType<GlacialState>(),
            ModContent.BuffType<GodSlayerInferno>(),
            ModContent.BuffType<HolyFlames>(),
            ModContent.BuffType<HolyInferno>(),
            ModContent.BuffType<IcarusFolly>(),
            ModContent.BuffType<Irradiated>(),
            ModContent.BuffType<Nightwither>(),
            ModContent.BuffType<Plague>(),
            ModContent.BuffType<SulphuricPoisoning>(),
            ModContent.BuffType<VulnerabilityHex>(),
            ModContent.BuffType<Warped>(),
            ModContent.BuffType<WeakPetrification>(),
            ModContent.BuffType<WhisperingDeath>(),
            ModContent.BuffType<WeakBrimstoneFlames>(),
            ModContent.BuffType<SearingLava>(),
            ModContent.BuffType<WitherDebuff>()
        };
        foreach (var debuff in debuffs) {
            player.buffImmune[debuff] = true;
        }
        
        player.noFallDmg = true;
        player.noKnockback = true;
        player.lavaImmune = true;
        player.immuneNoBlink = true;
        player.potionDelayTime = 0;
        player.GetDamage<GenericDamageClass>() += 0.40f;
    }

    public override void AddRecipes() {
        Recipe recipe = CreateRecipe();
        recipe.AddIngredient(ModContent.ItemType<HuyShield>());
        recipe.AddIngredient(ModContent.ItemType<RenCard>());
        recipe.AddIngredient(ModContent.ItemType<WarbannerOfTheJino>());
        recipe.AddIngredient(ModContent.ItemType<PotionEmblem>());
        recipe.AddTile(TileID.TinkerersWorkbench);
        recipe.Register();
    }
}