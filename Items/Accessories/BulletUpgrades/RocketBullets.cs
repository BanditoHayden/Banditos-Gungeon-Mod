using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades
{
    public class RocketBullets : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rocket Powered Bullets");
            Tooltip.SetDefault("All bullets are faster\n+5% Ranged Damage\nSlightly decreases ranged weapons use time");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 1;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<GungeonPlayer>().RocketBullets = true;
            player.rangedDamage += 0.5f;
        }

    }
}
