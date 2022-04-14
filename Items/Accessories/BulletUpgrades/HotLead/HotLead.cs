using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using GungeonMod;
using System;
namespace GungeonMod.Items.Accessories.BulletUpgrades.HotLead
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
            player.GetModPlayer<GungeonPlayer>().HotLead = true;
        }
    }
}
