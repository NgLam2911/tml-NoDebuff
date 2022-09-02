using NoDebuff.NDPlayer;
using Terraria;

namespace NoDebuff; 

public static class NoDebuffUtils {

    public static NoDebuffPlayer NoDebuff(this Player player) {
        return player.GetModPlayer<NoDebuffPlayer>();
    }
}