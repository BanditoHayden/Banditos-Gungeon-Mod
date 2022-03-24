using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;
using System.Threading.Tasks;
using GungeonMod.Items.Actives;

namespace GungeonMod.Items.Actives.JarOfBess
{
  public class JarofBees : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jar of Bees");
            Tooltip.SetDefault("The Pain!\nThese bees have been carefully trained to hunt down enemy munitions... and destroy them.");
        }
        public override void SetDefaults()
        {
            // Stats of the item
            item.damage = 16;
            item.useTime = 15;
            item.useAnimation = 15;
            item.knockBack = 2;
            item.value = 800;
            item.crit = 4;
            // How the item works
            item.autoReuse = true;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.noMelee = true;
            item.shoot = 181;
            item.shootSpeed = 6.7f;
            item.UseSound = SoundID.Item97;
            // Other
            item.noUseGraphic = true;
            item.rare = 2;
        }
        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(ModContent.BuffType<ActiveCooldown>())) 
            {
                return false;
            }
            return true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            player.AddBuff(ModContent.BuffType<ActiveCooldown>(), 1800);
            int numberProjectiles = 10 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); 
                                                                                                                
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
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
