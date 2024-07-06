using CalamityMod.Items;
using CalamityMod.Items.Materials;
using CalamityMod.Rarities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGodsBelow.Items.Accessories
{
    public class Serenity : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Accessories";

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 30;
            Item.accessory = true;
            Item.rare = ModContent.RarityType<Turquoise>();
            Item.value = CalamityGlobalItem.RarityTurquoiseBuyPrice;
        }

        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            var modPlayer = Main.LocalPlayer.GetModPlayer<TheGodsBelowPlayer>();
            modPlayer.serenity = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<UelibloomBar>(15)
                .AddIngredient<BloodstoneCore>(10)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}
