
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;

namespace GungeonMod.Items.Weapons.Ranged.PeaShooter
{
	public class Pea : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pea");
			ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			Projectile.width = 7;
			Projectile.height = 7;
			Projectile.penetrate = 1;
			Projectile.aiStyle = 1;
			AIType = ProjectileID.WoodenArrowFriendly;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.friendly = true;
		}
		

		public override void Kill(int timeLeft)
		{
			// This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
			Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
			SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
		}
	}
}


