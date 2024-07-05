using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGodsBelow.Buffs
{
    public class Tyranny : ModBuff
    {
        public override void Update(Terraria.Player player, ref int buffIndex)
        {
            player.statDefense -= player.statDefense / 2;
            player.GetDamage<GenericDamageClass>() += 0.15f;
        }
    }
}
