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
            Tooltip.SetDefault("+5% Movement Speed\n+50% Jump Speed\n+20 Max Life");
        }

        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = 4;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 20;
            player.moveSpeed += 0.05f;
            player.jumpSpeedBoost += 0.5f;
            player.autoJump = true;
            player.noFallDmg = true;
        }

    }
}