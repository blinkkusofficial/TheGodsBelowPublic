using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Social.Base;

namespace TheGodsBelow.Items.Materials
{
    public class StringofFate : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Materials";

        public override void SetDefaults()
        {
            Item.width = 8;
            Item.height = 13;
            Item.maxStack = 9999;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Cobweb, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
