using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades.SilverBullets
{
    public class SilverBullets : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Bullets");
            Tooltip.SetDefault("+50% damage against bosses, -50% against everything else");
        }

        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = 4;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<GungeonPlayer>().SilverBullets = true;
        }

    }
}