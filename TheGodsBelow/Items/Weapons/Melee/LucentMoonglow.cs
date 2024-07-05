using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityMod.Items.Materials;
using CalamityMod.Tiles.Furniture.CraftingStations;

namespace TheGodsBelow.Items.Weapons.Melee
{
    public class LucentMoonglow : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Weapons.Melee";

        public override void SetDefaults()
        {
            Item.damage = 2099;
            Item.crit = 48;
            Item.DamageType = DamageClass.Melee;
            Item.width = 90;
            Item.height = 90;
            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 9;
            Item.value = Item.sellPrice(2, 80, 0, 0);
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.scale = 1.05f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<EndothermicEnergy>(20)
                .AddIngredient<CryonicBar>(15)
                .AddIngredient<CoreofEleum>(5)
                .AddIngredient<ShadowspecBar>(5)
                .AddTile<CosmicAnvil>()
                .Register();
        }
    }
}
