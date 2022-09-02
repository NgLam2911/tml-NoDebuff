using Terraria.ModLoader;

namespace NoDebuff.NDPlayer; 

public class NoDebuffPlayer : ModPlayer {

    public bool HuyShield;
    public bool PotionsEmblem;
    public bool RenCard;
    public bool WarbannerOfTheJino;

    public override void Initialize() {
        HuyShield = false;
        PotionsEmblem = false;
        RenCard = false;
        WarbannerOfTheJino = false;
    }
}