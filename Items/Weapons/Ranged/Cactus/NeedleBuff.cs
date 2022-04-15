
using Terraria;
using Terraria.ModLoader;

namespace GungeonMod.Items.Weapons.Ranged.Cactus
{
	public class NeedleBuff : ModBuff
	{
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Javelin");
			Description.SetDefault("Losing life");
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<GungeonNPC>().Needle = true;
		}
	}
}