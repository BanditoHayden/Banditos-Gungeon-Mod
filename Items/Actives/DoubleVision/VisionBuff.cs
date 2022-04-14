using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;

using System.Threading.Tasks;

namespace GungeonMod.Items.Actives.DoubleVision
{
    public class VisionBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Double Vision");
            Description.SetDefault("+50% Attack Speed");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
        }
    }
}