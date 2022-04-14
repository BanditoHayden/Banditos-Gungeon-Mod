using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using System.Threading.Tasks;
using GungeonMod.Items.Actives;
using Terraria.DataStructures;

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
            Item.damage = 32;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.knockBack = 2;
            Item.value = 800;
            Item.crit = 4;
            // How the item works
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.noMelee = true;
            Item.shoot = 181;
            Item.shootSpeed = 6.7f;
            Item.UseSound = SoundID.Item97;
            // Other
            Item.noUseGraphic = true;
            Item.rare = 2;
        }
        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(ModContent.BuffType<ActiveCooldown>()))
            {
                return false;
            }
            return true;
        }
       
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            player.AddBuff(ModContent.BuffType<ActiveCooldown>(), 1800);
            const int NumProjectiles = 10;
            for (int i = 0; i < NumProjectiles; i++)
            {
                Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(5));
                newVelocity *= 1f - Main.rand.NextFloat(0.3f);
                Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            CreateRecipe()

            .AddIngredient(ItemID.Bottle, 1)
            .AddIngredient(ItemID.Hive, 10)
            .AddTile(TileID.WorkBenches)
            .Register();
        }
    }
}