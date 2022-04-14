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
namespace GungeonMod.Items
{
    public class Class1 : GlobalProjectile
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
            bool TR = true;
            Player player = Main.player[Main.myPlayer];
            GungeonPlayer modPlayer = player.GetModPlayer<GungeonPlayer>();
            if (modPlayer.SnowBallets && projectile.friendly && modPlayer.SnowBalletsCD == 0 && projectile.CountsAsClass(DamageClass.Ranged))
            {
                projectile.position = projectile.Center;
                projectile.scale *= 2f;
                projectile.width *= 2;
            
                projectile.height *= 2;
                projectile.Center = projectile.position;
                SnowBalletsProj = false;
                modPlayer.SnowBalletsCD = 30;

            }
            if (modPlayer.GhostBullets && projectile.friendly && projectile.CountsAsClass(DamageClass.Ranged))
            {
                projectile.maxPenetrate += 1;
                projectile.tileCollide = false;
            }
        
            if (modPlayer.RocketBullets && projectile.friendly && projectile.CountsAsClass(DamageClass.Ranged))
            {
                projectile.velocity *= 1.05f;
            }
            return TR;
        }
    }
}
