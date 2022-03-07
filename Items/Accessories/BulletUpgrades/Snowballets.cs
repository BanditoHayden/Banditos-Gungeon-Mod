using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades
{
    public class Snowballets : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snow Ballets");
            Tooltip.SetDefault("+5% Ranged Damage\nBullets have a chance to get progressively larger");
        }

        public override void SetDefaults()
        {
            item.accessory = true;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
        }


        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<GungeonPlayer>().SnowBallets = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.Snowball, 100);
            recipe.AddIngredient(ItemID.MusketBall, 100);
            recipe.AddTile(TileID.IceMachine);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
