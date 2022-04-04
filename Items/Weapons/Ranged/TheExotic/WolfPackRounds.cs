using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



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
			projectile.CloneDefaults(ProjectileID.RocketI);
			aiType = ProjectileID.RocketI;
			projectile.hostile = false;
			projectile.friendly = true;
			projectile.ranged = true;
		}
        public override void Kill(int timeLeft)
        {
			if (projectile.ai[1] == 0)
			{
				for (int i = 0; i < 5; i++)
				{
					// Random upward vector.
					Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
					Projectile.NewProjectile(projectile.Center, vel, mod.ProjectileType("WolfPackRounds2"), projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
				
				}
			}
		}
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
			
            return base.OnTileCollide(oldVelocity);
        }







    }
}
