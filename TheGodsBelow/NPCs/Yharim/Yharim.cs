using Terraria.ModLoader;
using Terraria;
using Terraria.Audio;

namespace TheGodsBelow.NPCs.Yharim
{
    [AutoloadBossHead]
    public class Yharim : ModNPC, ILocalizedModType
    {
        public new string LocalizationCategory => "NPCs";

        public override void SetStaticDefaults()
        {
            NPC.lifeMax = 3141592;
            NPC.lavaImmune = true;
            NPC.noTileCollide = true;
            NPC.damage = 0;
            NPC.npcSlots = 50f;
            NPC.aiStyle = -1;
            AIType = -1;
            NPC.boss = true;

	        Music = MusicLoader.GetMusicSlot(Mod, "Music/TempYharimPhase1");
        }
    }
}
