using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod.Items.Weapons.Ranged.TheExotic;
using System;
using Terraria.Audio;
using Terraria.DataStructures;

namespace GungeonMod.Items.Weapons.Ranged.TheExotic
{
  public class WolfPackRounds : ModProjectile
    {
        

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rocket 1");
		}

		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.RocketI);
			AIType = ProjectileID.RocketI;
			Projectile.hostile = false;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.width = 26;
			Projectile.height = 38;
		}

		public override void Kill(int timeLeft)
		{
			Vector2 launchVelocity = new Vector2(-4, 0); // Create a velocity moving the left.
			for (int i = 0; i < 4; i++)
			{
				Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
				Projectile.NewProjectile(new EntitySource_Parent(Projectile), Projectile.Center, vel,ModContent.ProjectileType<WolfPackRounds2>(), Projectile.damage , Projectile.knockBack, Projectile.owner);
			}
		}
		public override bool OnTileCollide(Vector2 oldVelocity)
        {
			
            return base.OnTileCollide(oldVelocity);
        }
    }
	public class WolfPackRounds2 : ModProjectile
	{


		public override void SetStaticDefaults()
		{
			
			DisplayName.SetDefault("A rocket");
		}
		public int timer = 0;
		public override void SetDefaults()
		{
			Projectile.CloneDefaults(ProjectileID.RocketIII);
			AIType = ProjectileID.RocketIII;
			Projectile.hostile = false;
			Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Ranged;
			Projectile.width = 14;
			Projectile.height = 16;
		}

		public override bool PreKill(int timeLeft)
		{
			Projectile.type = ProjectileID.RocketIII;
			return true;
		}
		public override void AI()
		{
			Projectile.friendly = true;
			Projectile.velocity *= 0.99f;
			if (Projectile.localAI[0] == 0f)
			{
                AdjustMagnitude(ref Projectile.velocity);
				Projectile.localAI[0] = 1f;
			}
			Vector2 move = Vector2.Zero;
			float distance = 2000f;
			bool target = false;
			for (int k = 0; k < 200; k++)
			{
				if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 5)
				{
					Vector2 newMove = Main.npc[k].Center - Projectile.Center;
					float distanceTo = (float)Math.Sqrt(newMove.X * newMove.X + newMove.Y * newMove.Y);
					if (distanceTo < distance)
					{
						move = newMove;
						distance = distanceTo;
						target = true;
					}
				}
			}
			if (target)
			{

				AdjustMagnitude(ref move);
				Projectile.velocity = (10 * Projectile.velocity + move) / 11f;
				AdjustMagnitude(ref Projectile.velocity);
			}

		}
		private void AdjustMagnitude(ref Vector2 vector)
		{
			float magnitude = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
			if (magnitude > 6f)
			{
				vector *= 6f / magnitude;
			}
		}
		
	}
}
