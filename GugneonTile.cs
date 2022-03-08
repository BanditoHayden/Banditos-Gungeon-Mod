using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace GungeonMod
{
    public class GugneonTile : GlobalTile
    {
        public override bool CanPlace(int i, int j, int type)
        {
            if (type == TileID.ImmatureHerbs)
            {
                if (Main.tile[i, j].type == TileType<Tiles.PeaPlant>())
                {
                    return false;
                }
            }
            return base.CanPlace(i, j, type);
        }
    }
}
