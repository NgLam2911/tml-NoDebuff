using On.Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace NoDebuff.Buffs; 

public class BrokenArmor : ModBuff {
    public override void SetStaticDefaults() {
        DisplayName.SetDefault("Giant's Broken Armor");
        Description.SetDefault("Your armor is broken from the power of the Giant");
        Main.debuff[base.Type] = true;
        Main.pvpBuff[base.Type] = true;
        Main.buffNoSave[base.Type] = true;
    }
    
    public override void Update(Player player, ref int buffIndex) {
        player.statDefense -= 99999;
    }

    public override void Update(NPC npc, ref int buffIndex) {
        npc.defense -= 99999;
    }
}