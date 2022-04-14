using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;

namespace GungeonMod.Items.Weapons.Ranged.DragunFire
{
	public class DragunFireProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fire");
			Main.projFrames[Projectile.type] = 10;
		}

		public override void SetDefaults()
		{
			Projectile.width = 18;
			Projectile.height = 18;
			Projectile.penetrate = 1;
			Projectile.aiStyle = 1;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.friendly = true;
			Projectile.ignoreWater = false;
			Projectile.aiStyle = -1;
			Projectile.light = 0.5f;

		}
        public override void AI()
        {
			
			if (++Projectile.frameCounter >= 11)
			{
				Projectile.frameCounter = 0;
				if (++Projectile.frame >= 10)
				{
					Projectile.frame = 0;
				}
			}
			if (Projectile.penetrate <= 0)
			{
				Projectile.Kill();
			}
			if (Projectile.spriteDirection == -1)
			{
				Projectile.rotation += MathHelper.Pi;
			}

		}
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(BuffID.OnFire, 120);
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Projectile.penetrate--;
			return false;
		}
		public override void Kill(int timeLeft)
		{
			// This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
			Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
			SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
		}
	}
}


