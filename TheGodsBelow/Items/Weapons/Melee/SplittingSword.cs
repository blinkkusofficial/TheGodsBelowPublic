using CalamityMod.Items;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Weapons.Melee;
using CalamityMod.Rarities;
using CalamityMod.Tiles.Furniture.CraftingStations;
using Terraria.ID;
using Terraria.ModLoader;
using TheGodsBelow.Projectiles.Melee;

namespace TheGodsBelow.Items.Weapons.Melee
{
    public class SplittingSword : ModItem, ILocalizedModType
    {
        // Dedicated content: Loubre
        
        public new string LocalizationCategory => "Items.Weapons.Melee";

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Meowmere);
            Item.crit = 4;
            Item.shoot = ModContent.ProjectileType<SplittingProjectile>();
            Item.damage = 1400;
            Item.shootSpeed = 25f;
            Item.value = CalamityGlobalItem.RarityHotPinkBuyPrice;
            Item.rare = ModContent.RarityType<HotPink>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<TerrorBlade>()
                .AddIngredient<Necroplasm>(10)
                .AddIngredient<ShadowspecBar>(5)
                .AddTile<DraedonsForge>()
                .Register();
        }
    }
}