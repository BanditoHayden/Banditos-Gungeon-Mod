using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.Passives.BionicLeg
{
    public class BionicLeg : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bionic Leg");
            Tooltip.SetDefault("+5% Movement Speed\n+5% Jump Speed\n+20 Max Life");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 1;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 20;
            player.moveSpeed += 5;
            player.jumpSpeedBoost += 5;
        }

    }
}
