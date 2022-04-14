using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;

namespace GungeonMod.Items.Accessories.BulletUpgrades.GhostBullets
{
    public class GhostBullets : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ghost Bullets");
            Tooltip.SetDefault("All bullets have extra pierce and go through walls");
        }
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = 7;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
           
            player.GetModPlayer<GungeonPlayer>().GhostBullets = true;
        }
        


    }
}
