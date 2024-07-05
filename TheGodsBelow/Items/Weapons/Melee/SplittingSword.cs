using Terraria.ID;
using Terraria.ModLoader;
using TheGodsBelow.Projectiles.Melee;
using TheGodsBelow.Rarities;

namespace TheGodsBelow.Items.Weapons.Melee
{
    public class SplittingSword : ModItem, ILocalizedModType
    {
        // Dedicated content: Loubre
        
        public new string LocalizationCategory => "Items.Weapons.Melee";

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.Meowmere);
            Item.shoot = ModContent.ProjectileType<SplittingProjectile>();
            Item.damage *= 2; 
            Item.shootSpeed *= 3f; 
            Item.rare = ModContent.RarityType<Rainbow>();
        }

        public override void AddRecipes()
        {
            // CreateRecipe()
                // .AddIngredient(ItemID.DirtBlock, 5)
                // .Register();
        }
    }
}