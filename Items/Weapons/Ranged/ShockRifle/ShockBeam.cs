using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace GungeonMod.Items.Weapons.Ranged.ShockRifle
{
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
}
