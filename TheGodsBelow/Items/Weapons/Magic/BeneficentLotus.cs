using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGodsBelow.Items.Weapons.Magic
{
    public class BeneficentLotus : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.Weapons.Magic";

        public override void SetDefaults()
        {
            Item.damage = 62;
            Item.DamageType = DamageClass.Magic;
            Item.width = 32;
            Item.height = 32;
            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.RaiseLamp;
            Item.knockBack = 6;
            Item.value = Item.sellPrice(silver: 75);
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.mana = 10;
            Item.shoot = ProjectileID.DD2PhoenixBowShot;
            Item.shootSpeed = 17.5f;
            Item.scale = 0.5f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.WaterBolt, 1)
                .AddIngredient(ItemID.LightShard, 2)
                .AddIngredient(ItemID.DarkShard, 2)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}