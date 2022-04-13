using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace GungeonMod.Items.Weapons.Ranged.JK47
{
    public class JK47 : ModItem
    {
      
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jk-47");
			Tooltip.SetDefault("Substitute\nNoodle shaped like a gun. Frightens enemies.");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 80;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.knockBack = 2;
			Item.value = 350000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 50;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = 10;
			Item.shootSpeed = 6.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/JK47shot");
			Item.rare = 2;
			Item.scale = 1.1f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
			const int NumProjectiles = 1; // The humber of projectiles that this gun will shoot.

			for (int i = 0; i < NumProjectiles; i++)
			{
				// Rotate the velocity randomly by 30 degrees at max.
				Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(50));

				// Decrease velocity randomly for nicer visuals.
				newVelocity *= 1f - Main.rand.NextFloat(0.3f);

				// Create a projectile.
				Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
			}

			return false;
		}




    }




}

