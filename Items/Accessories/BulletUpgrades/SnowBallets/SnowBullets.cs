using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades.SnowBallets
{
    public class SnowBullets : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Snow Ballets");
            Tooltip.SetDefault("+5% Bullet Damage\nBullets have a chance to get progressively larger");
        }
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.value = Item.sellPrice(0, 1, 0, 0);
            Item.rare = 2;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.bulletDamage += 0.05f;
            player.GetModPlayer<GungeonPlayer>().SnowBallets = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.Snowball, 100)
            .AddIngredient(ItemID.MusketBall, 100)
            .AddTile(TileID.IceMachine)
            .Register();
        }


    }
}
