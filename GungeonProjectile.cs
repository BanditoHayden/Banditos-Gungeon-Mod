using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System;
using Terraria.Localization;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using GungeonMod;
namespace GungeonMod
{
  public class GungeonProjectile : GlobalProjectile
    {
        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        public bool SnowBalletsProj = false;
        public override bool PreAI(Projectile projectile)
        {
            bool rv = true;
            Player player = Main.player[Main.myPlayer];
            GungeonPlayer modPlayer = player.GetModPlayer<GungeonPlayer>();
            if (modPlayer.SnowBallets && projectile.friendly && projectile.ranged && modPlayer.SnowBalletsCD == 0)
            {
                projectile.position = projectile.Center;
                projectile.scale *= 2f;
                projectile.width *= 2;
                projectile.height *= 2;
                projectile.Center = projectile.position;
                SnowBalletsProj = false;
                modPlayer.SnowBalletsCD = 30;

            }
            if (modPlayer.GhostBullets && projectile.friendly && projectile.ranged)
            {
                projectile.penetrate += 1;
            }
            if (modPlayer.RocketBullets && projectile.friendly && projectile.ranged)
            {
                projectile.velocity *= 1.05f;
            }












            return rv;





        }

        public override bool TileCollideStyle(Projectile projectile, ref int width, ref int height, ref bool fallThrough)
        {
            if (SnowBalletsProj)
            {
                width /= 2;
                height /= 2;
            }
            return base.TileCollideStyle(projectile, ref width, ref height, ref fallThrough);
        }
        



    }
}
