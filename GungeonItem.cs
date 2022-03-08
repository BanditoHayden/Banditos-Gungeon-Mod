
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using GungeonMod.Items.Herbs;
namespace GungeonMod
{
   public  class GungeonItem : GlobalItem
    {
		public override void OpenVanillaBag(string context, Player player, int arg)
		{
		
			if (context == "herbBag")
			{
				player.QuickSpawnItem(ItemType<PeaSeeds>(), Main.rand.Next(5, 13));
			}
		}		
	}
}
