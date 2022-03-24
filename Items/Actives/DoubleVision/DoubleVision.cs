using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;
using System.Threading.Tasks;
using GungeonMod.Items.Actives.DoubleVision;

namespace GungeonMod.Items.Actives.DoubleVision
{
    public class DoubleVision : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Double Vision");
            Tooltip.SetDefault("One For Each Of You!\nTemporarily doubles gun output.");
        }
        public override void SetDefaults()
        {
            // Stats of the item
      
            item.useTime = 15;
            item.useAnimation = 15;
            item.knockBack = 2;
            item.value = 800;
           
            // How the item works
            item.autoReuse = true;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.noMelee = true;
            item.UseSound = SoundID.Item97;
            // Other
            item.noUseGraphic = true;
            item.rare = 2;
            
        }
        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
                player.AddBuff(ModContent.BuffType<VisionBuff>(), 420, true);
                player.AddBuff(ModContent.BuffType<ActiveCooldown>(), 3600, true);
            }
        }
        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(ModContent.BuffType<ActiveCooldown>()))
            {
                return false;
            }
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.AddIngredient(ItemID.Hive, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
