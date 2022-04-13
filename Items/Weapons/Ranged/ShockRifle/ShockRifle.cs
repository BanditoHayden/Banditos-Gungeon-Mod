using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
namespace GungeonMod.Items.Weapons.Ranged.ShockRifle
{
   public class ShockRifle : ModItem
    {
        public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("Zap\nThe Shock Rifle uses a modified battery and coil to propel electricity.");
		}
        public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 98;
			item.useTime = 15;
			item.useAnimation = 20;
			item.knockBack = 4;
			item.value = 800000;
			item.ranged = true;
			item.crit = 17;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("ShockBeam");
			item.shootSpeed = 10.7f;
            // Other
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Zap");
			item.rare = 8;
			item.scale = 1.1f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{

			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 55f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}

	}
}
public class ShockBeam : ModProjectile
{
	public override void SetDefaults()
	{
		projectile.width = 4;
		projectile.height = 4;
		// NO! projectile.aiStyle = 48;
		projectile.friendly = true;
		projectile.ranged = true;
		projectile.extraUpdates = 10;
		projectile.timeLeft = 200; // lowered from 300
		projectile.penetrate = -1;
	}
	public override string Texture => "Terraria/Projectile_" + ProjectileID.ShadowBeamFriendly;

	public override void AI()
	{
		Vector2 projectilePosition = projectile.position;

		projectile.alpha = 255;
		// Important, changed 173 to 178!
		int dust = Dust.NewDust(projectilePosition, 1, 1, 176, 0f, 0f, 0, default(Color), 1f);
		Main.dust[dust].noGravity = true;
		Main.dust[dust].position = projectilePosition;
		Main.dust[dust].scale = (float)Main.rand.Next(70, 110) * 0.013f;
		Main.dust[dust].velocity *= 0.2f;
	}
}