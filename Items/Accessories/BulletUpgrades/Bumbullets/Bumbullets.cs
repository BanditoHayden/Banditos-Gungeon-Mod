using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades.Bumbullets
{
    public class Bumbullets : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bumbullets");
            Tooltip.SetDefault("Bumblecore\nShooting occasionally spawns additional bees.");
        }

        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = 2;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.MusketBall, 100)
            .AddCondition(Recipe.Condition.NearLava)
            .Register();
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<GungeonPlayer>().Bumble = true;
        }
    }
}
