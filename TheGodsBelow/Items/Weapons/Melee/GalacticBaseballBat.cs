using CalamityMod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGodsBelow.Items.Weapons.Melee
{
	public class GalacticBaseballBat : ModItem, ILocalizedModType
	{
		public new string LocalizationCategory => "Items.Weapons.Melee";

		public override void SetDefaults()
		{
			Item.damage = 480;
			Item.DamageType = DamageClass.Melee;
			Item.width = 54;
			Item.height = 54;
			Item.useTime = 12;
			Item.useAnimation = 12;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 12344;
			Item.rare = ItemRarityID.Cyan;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.scale = 1.55f;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<MeldConstruct>(12)
                .AddIngredient<GalacticaSingularity>(10)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
		}
	}
}