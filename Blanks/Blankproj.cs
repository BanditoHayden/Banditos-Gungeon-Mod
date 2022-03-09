using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using Terraria.Graphics.Effects; // Don't forget this one!


namespace GungeonMod.Items.Blanks
{
    public class Blankproj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("pleasework");
        }
        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.friendly = true;

            
            projectile.ranged = true;
            projectile.friendly = true;
           
            projectile.timeLeft = 360;

        }
        private int rippleCount = 3;
        private int rippleSize = 5;
        private int rippleSpeed = 15;
        private float distortStrength = 100f;

        public override void AI()
        {
            // ai[0] = state
            // 0 = unexploded
            // 1 = exploded

            if (projectile.timeLeft <= 180)
            {
                if (projectile.ai[0] == 0)
                {
                    projectile.ai[0] = 1; // Set state to exploded
                    projectile.alpha = 255; // Make the projectile invisible.
                    projectile.friendly = false; // Stop the bomb from hurting enemies.

                    if (Main.netMode != NetmodeID.Server && !Filters.Scene["Shockwave"].IsActive())
                    {
                        Filters.Scene.Activate("Shockwave", projectile.Center).GetShader().UseColor(rippleCount, rippleSize, rippleSpeed).UseTargetPosition(projectile.Center);
                    }
                }

                if (Main.netMode != NetmodeID.Server && Filters.Scene["Shockwave"].IsActive())
                {
                    float progress = (180f - projectile.timeLeft) / 60f;
                    Filters.Scene["Shockwave"].GetShader().UseProgress(progress).UseOpacity(distortStrength * (1 - progress / 3f));
                }
            }
        }

        public override void Kill(int timeLeft)
        {
            if (Main.netMode != NetmodeID.Server && Filters.Scene["Shockwave"].IsActive())
            {
                Filters.Scene["Shockwave"].Deactivate();
            }
        }
    }

  

}

