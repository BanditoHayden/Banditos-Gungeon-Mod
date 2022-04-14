using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using System.Threading.Tasks;

namespace GungeonMod.Items.Actives
{
    public class ActiveCooldown : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Active Item Cooldown");
            Description.SetDefault("Cooldown!");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
        }
       
    }
}
