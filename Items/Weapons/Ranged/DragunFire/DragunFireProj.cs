using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using Microsoft.Xna.Framework.Graphics;

namespace GungeonMod.Items.Weapons.Ranged.DragunFire
{
	public class DragunFireProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fire");
			Main.projFrames[projectile.type] = 10;
		}

		public override void SetDefaults()
		{
			projectile.width = 18;
			projectile.height = 18;
			projectile.penetrate = 1;
			projectile.aiStyle = 1;
			projectile.ranged = true;
			projectile.friendly = true;
			projectile.ignoreWater = false;
			projectile.aiStyle = -1;
			projectile.light = 0.5f;

		}
        public override void AI()
        {
			
			if (++projectile.frameCounter >= 11)
			{
				projectile.frameCounter = 0;
				if (++projectile.frame >= 10)
				{
					projectile.frame = 0;
				}
			}
			if (projectile.penetrate <= 0)
			{
				projectile.Kill();
			}
			if (projectile.spriteDirection == -1)
			{
				projectile.rotation += MathHelper.Pi;
			}

		}
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			projectile.penetrate--;
			Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/FlameImpact"));
		
			return false;
		}
		public override void Kill(int timeLeft)
		{
			// This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
		}
	}
}


