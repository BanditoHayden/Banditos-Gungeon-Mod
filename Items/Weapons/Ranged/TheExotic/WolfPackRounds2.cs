using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace GungeonMod.Items.Weapons.Ranged.TheExotic
{
    public class WolfPackRounds2 :ModProjectile
    {


        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("A rocket");
		}
		public int timer = 0;
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.RocketIII);
			aiType = ProjectileID.RocketIII;
			projectile.hostile = false;
			projectile.friendly = true;
			projectile.ranged = true;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.RocketIII;
			return true;
		}
        public override void AI()
        {
            
				projectile.velocity *= 0.99f;
				if (projectile.localAI[0] == 0f)
				{
					AdjustMagnitude(ref projectile.velocity);
					projectile.localAI[0] = 1f;
				}
				Vector2 move = Vector2.Zero;
				float distance = 200f;
				bool target = false;
				for (int k = 0; k < 200; k++)
				{
					if (Main.npc[k].active && !Main.npc[k].dontTakeDamage && !Main.npc[k].friendly && Main.npc[k].lifeMax > 5)
					{
						Vector2 newMove = Main.npc[k].Center - projectile.Center;
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
					projectile.velocity = (10 * projectile.velocity + move) / 11f;
					AdjustMagnitude(ref projectile.velocity);
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
