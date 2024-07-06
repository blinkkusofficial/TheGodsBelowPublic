using Terraria.ModLoader;

namespace TheGodsBelow.Buffs
{
    public class Fragrance : ModBuff, ILocalizedModType
    {
        public new string LocalizationCategory => "Buffs";

        public override void Update(Terraria.Player player, ref int buffIndex)
        {
            player.GetDamage<GenericDamageClass>() += 0.06f;
            player.moveSpeed += 0.08f;
            player.lifeRegen += 2;
        }
    }
}
