using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades
{
    public class GhostBullets : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ghost Bullets");
            Tooltip.SetDefault("All bullets have extra pierce");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 1;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<GungeonPlayer>().GhostBullets = true;
        }

    }
}
