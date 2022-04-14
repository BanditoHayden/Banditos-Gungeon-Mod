using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;

using System.Threading.Tasks;
using GungeonMod.Items.Actives.DoubleVision;

namespace GungeonMod.Items.Actives.PotionofGunFriendship
{
    public class PotionofGunFriendship : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potion of Gun Friendship");
            Tooltip.SetDefault("Temporarily increases combat ability.");
        }
        public override void SetDefaults()
        {
            // Stats of the item

            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.knockBack = 2;
            Item.value = 800;

            // How the item works
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.noMelee = true;
            Item.UseSound = SoundID.Item3;
            // Other
            Item.noUseGraphic = true;
            Item.rare = 2;

        }
        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {

            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(Item.buffType, 3600, true);
                player.AddBuff(ModContent.BuffType<GunBuff>(), 600, true);
                player.AddBuff(ModContent.BuffType<ActiveCooldown>(), 3600, true);
            }
        }
        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(ModContent.BuffType<ActiveCooldown>()))
            {
                return false;
            }
            return true;
        }

    }
}