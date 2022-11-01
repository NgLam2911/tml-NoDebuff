using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace NoDebuff.NDPlayer; 

public class NoDebuffPlayer : ModPlayer {

    public bool HuyShield;
    public bool PotionsEmblem;
    public bool RenCard;
    public bool WarbannerOfTheJino;
    public bool NgNinjaGear;
    public bool NoHitterGamer;

    public override void Initialize() {
        this.ResetVariable();
    }

    public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage,
        ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource, ref int cooldownCounter) {
        if (NgNinjaGear) {
            //99,99% chance to dodge an attack
            if (Main.rand.Next(10000) < 9999) {
                return false;
            }
        }

        if (NoHitterGamer) {
            damage = 9999999; //Seriously ?
        }
        return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource, ref cooldownCounter);
    }

    private void ResetVariable() {
        HuyShield = false;
        PotionsEmblem = false;
        RenCard = false;
        WarbannerOfTheJino = false;
        NgNinjaGear = false;
        NoHitterGamer = false;
    }
}