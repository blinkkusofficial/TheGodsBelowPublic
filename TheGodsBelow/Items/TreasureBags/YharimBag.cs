using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using TheGodsBelow.NPCs.Yharim;
using CalamityMod.Rarities;

namespace TheGodsBelow.Items.TreasureBags
{
    public class YharimBag : ModItem, ILocalizedModType
    {
        public new string LocalizationCategory => "Items.TreasureBags";

        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 3;
            ItemID.Sets.BossBag[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.rare = ModContent.RarityType<CalamityRed>();
            Item.expert = true;
        }

        public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
        {
            itemGroup = ContentSamples.CreativeHelper.ItemGroup.BossBags;
        }

        public override bool CanRightClick() => true;

        public override Color? GetAlpha(Color lightColor) => Color.Lerp(lightColor, Color.White, 0.4f);

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            // Money
            itemLoot.Add(ItemDropRule.CoinsBasedOnNPCValue(ModContent.NPCType<Yharim>()));

            // Materials


            // Weapons
            

            // Equipment


            // Vanity

        }
    }
}
