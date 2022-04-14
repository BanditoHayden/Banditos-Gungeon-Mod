using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using System.Threading.Tasks;
using GungeonMod.Items.Actives.DoubleVision;

namespace GungeonMod.Items.Actives.DoubleVision
{
    public class DoubleVision : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Double Vision");
            Tooltip.SetDefault("One For Each Of You!\nTemporarily doubles gun output.");
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
                player.AddBuff(ModContent.BuffType<VisionBuff>(), 600, true);
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