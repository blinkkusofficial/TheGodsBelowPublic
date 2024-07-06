using CalamityMod.Items;
using CalamityMod.Items.Accessories;
using CalamityMod.Items.Materials;
using CalamityMod.Rarities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGodsBelow.Items.Accessories
{
    public class PhoenixsBlessing : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Accessories";

        public override void SetDefaults()
        {
            Item.width = 38;
            Item.height = 40;
            Item.accessory = true;
            Item.value = CalamityGlobalItem.RarityVioletBuyPrice;
            Item.rare = ModContent.RarityType<Violet>();
        }

        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            var modPlayer = Main.LocalPlayer.GetModPlayer<TheGodsBelowPlayer>();
            modPlayer.phoenixsBlessing = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<BadgeofBravery>()
                .AddIngredient<YharonSoulFragment>(40)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}
