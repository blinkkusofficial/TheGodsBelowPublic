using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheGodsBelow.Rarities
{
    // it's only used for a few items and is purely decorative
    public class Rainbow : ModRarity
    {
        public override Color RarityColor => new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB);
    }
}
