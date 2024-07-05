using Terraria.ModLoader;

namespace TheGodsBelow
{
    public partial class TheGodsBelowPlayer : ModPlayer
    {
        #region Accessory
        public bool serenity = false;
        public bool phoenixsBlessing = false;

        #endregion

        #region Reset Effects
        public override void ResetEffects()
        {
            if (phoenixsBlessing)
            {
                Player.endurance += 0.05f;
                Player.GetDamage<MeleeDamageClass>() += 0.15f;
                Player.GetCritChance<MeleeDamageClass>() += 0.15f;
                Player.GetArmorPenetration<MeleeDamageClass>() += 5;
            }
            
            if (serenity)
            {
                Player.endurance += 0.68f; // For some reason 0.68 gives 48% DR
                Player.GetDamage<GenericDamageClass>() -= 0.6f;
                Player.GetCritChance<GenericDamageClass>() = 0;
            }

            phoenixsBlessing = false;
            serenity = false;
        }

        #endregion
    }
}