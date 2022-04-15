using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System;

namespace GungeonMod.Items.Accessories.Passives.Broccoli
{
    public class Dodge : ModBuff
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dodge");
            Description.SetDefault("Currently Invulnerable");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.immune = true;
        }

    }
}