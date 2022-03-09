using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;

namespace GungeonMod.Items.Weapons.Ranged.BigIron
{
   public class BigIron : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Big Iron");
			Tooltip.SetDefault("Heavy\nThe Big Iron is a strange revolver, created by attaching additional barrels to a magnum. The barrels are not actually connected to the chamber, but they fire nonetheless.");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 14;
			item.useTime = 40;
			item.useAnimation = 40;
			item.knockBack = 8;
			item.value = 10000;
			item.ranged = true;
			item.crit = 10;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = 10;
			item.shootSpeed = 7.7f;
			// Other
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Magnumshot");
			item.rare = 2;
			item.scale = 1.1f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			int numberProjectiles = 3; 
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
																												
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return false;
		}
	

	}
}
