using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades
{
    public class HotLead : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hot Lead");
            Tooltip.SetDefault("Bullets ignite enemies");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 1;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<GungeonPlayer>().HotLead = true;
        }

    }
}
