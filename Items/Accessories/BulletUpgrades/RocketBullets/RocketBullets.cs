using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades.RocketBullets
{
    public class RocketBullets : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rocket Powered Bullets");
            Tooltip.SetDefault("All bullets are faster\n+5% Bullet Damage\nSlightly decreases ranged weapons use time");
        }

        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.value = Item.sellPrice(0, 15, 0, 0);
            Item.rare = 7;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<GungeonPlayer>().RocketBullets = true;
            player.bulletDamage += 0.05f;
        }

    }
}
