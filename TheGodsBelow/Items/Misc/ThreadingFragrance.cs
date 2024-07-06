using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheGodsBelow.Items.Materials;
using TheGodsBelow.Rarities;

namespace TheGodsBelow.Items.Misc
{
    public class ThreadingFragrance : ModItem, ILocalizedModType
	{
        public new string LocalizationCategory => "Items.Misc";

        public override void SetDefaults()
		{
			Item.buffType = ModContent.BuffType<Buffs.Fragrance>();
			Item.buffTime = 900;
            Item.width = 29;
			Item.height = 25;
			Item.useTime = 36;
			Item.useAnimation = 36;
			Item.useStyle = ItemUseStyleID.Guitar;
			Item.holdStyle = ItemHoldStyleID.HoldGuitar;
			Item.knockBack = 2.25f;
			Item.value = 0;
			Item.rare = ModContent.RarityType<HeavenlyBlue>();
			Item.UseSound = SoundID.GuitarG;
			Item.autoReuse = true;
		}

        public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.SwiftnessPotion, 20)
				.AddIngredient(ItemID.Wood, 30)
				.AddIngredient<StringofFate>(5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}