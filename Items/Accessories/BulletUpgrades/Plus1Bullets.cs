using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades
{
    public class Plus1Bullets : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("+1 Bullets");
            Tooltip.SetDefault("+10% Ranged Damage");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 7;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.rangedDamage += 1;
        }

    }
}
