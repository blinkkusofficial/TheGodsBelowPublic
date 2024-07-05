using TheGodsBelow.Rarities;
using Terraria.ModLoader;
using Terraria;

namespace TheGodsBelow.Items.Misc
{
    public class TyrantsJournalIII : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Misc";

        public override void SetDefaults()
        {
            Item.rare = ModContent.RarityType<Log>();
        }
    }
}