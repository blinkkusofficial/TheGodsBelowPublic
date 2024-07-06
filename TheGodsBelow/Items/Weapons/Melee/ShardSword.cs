using CalamityMod.Items;
using CalamityMod.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGodsBelow.Items.Weapons.Melee
{
	public class ShardSword : ModItem, ILocalizedModType
	{
		public new string LocalizationCategory => "Items.Weapons.Melee";

		public override void SetDefaults()
		{
			Item.damage = 143;
			Item.DamageType = DamageClass.Melee;
			Item.width = 90;
			Item.height = 90;
			Item.useTime = 16;
			Item.useAnimation = 16;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 2.25f;
			Item.value = CalamityGlobalItem.RarityLimeBuyPrice;
			Item.rare = ItemRarityID.Lime;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<InfectedArmorPlating>(10)
				.AddIngredient<LifeAlloy>(5)
				.AddIngredient<ScoriaBar>(5)
				.AddIngredient<CoreofHavoc>(5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
    }
}