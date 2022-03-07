using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades
{
    public class IrradiatedLead : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Irradiated Lead");
            Tooltip.SetDefault("All bullets inflict poison");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<GungeonPlayer>().IrradiatedLead = true;
        }

    }
}
