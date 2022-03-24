using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;
using System.Threading.Tasks;

namespace GungeonMod.Items.Actives.DoubleVision
{
    public class VisionBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Double Vision");
            Description.SetDefault("+50% Attack Speed");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
        }
    }
}
