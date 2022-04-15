using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace GungeonMod.Items.Accessories.Passives.Broccoli
{
    public class Broccoli : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broccoli");
            Tooltip.SetDefault("Makes You Strong\n+10% Damage\n+10% Movement Speed\n10% Chance to block damage");
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {

            foreach (TooltipLine line2 in tooltips)
            {
                if (line2.mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.overrideColor = new Color(Main.DiscoR = 124, Main.DiscoG = 252, Main.DiscoB = 0);
                }
            }
        }
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.value = Item.sellPrice(0, 40, 0, 0);
            Item.rare = 4;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.1f;
            player.GetDamage(DamageClass.Generic) += 0.1f;
            player.GetModPlayer<GungeonPlayer>().Dodge = true;
        }

    }
}
