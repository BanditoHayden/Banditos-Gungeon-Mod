using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Threading.Tasks;

namespace GungeonMod.Items.Actives.PotionofGunFriendship
{
    public class GunBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potion of Gun Friendship");
            Description.SetDefault("+10% Attack Speed, +2 Knockback, +10% Ranged Damage");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
        }
    }
}