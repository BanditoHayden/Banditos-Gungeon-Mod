using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GungeonMod.Items.Weapons.Ranged.BlackHoleGun
{
    public class BlackHole : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("BlackHole");
           Main.projFrames[projectile.type] = 4;
        }
        public override void SetDefaults()
        {
            projectile.width = 18;
            projectile.height = 18;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.penetrate = 200;
            projectile.timeLeft = 600;
            projectile.tileCollide = true;
            projectile.scale = 1.7f;
        }
        public float pullforce = .5f;
        public float hSpeed;
        public float vSpeed;
        public float direction;
        public NPC test;
        public override void AI()
        {
            projectile.ai[0] += 1f;
            if (++projectile.frameCounter >= 5)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 4)
                {
                    projectile.frame = 0;
                }
            }
            if (projectile.spriteDirection == -1)
            {
                projectile.rotation += MathHelper.Pi;
            }

            pullforce = projectile.damage / 100f;
            for (int i = 0; i < 200; i++)
            {
                test = Main.npc[i];
                if (!test.boss && test.active && test.knockBackResist != 0f && !test.friendly)
                {
                    direction = (projectile.Center - test.Center).ToRotation();
                    hSpeed = (float)Math.Cos(direction) * pullforce;
                    vSpeed = (float)Math.Sin(direction) * pullforce;
                    test.velocity += new Vector2(hSpeed, vSpeed);
                }
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.penetrate--;
            if (projectile.penetrate <= 0)
            {
                projectile.Kill();
            }
            else
            {
                Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
                Main.PlaySound(SoundLoader.customSoundType, -1, -1, mod.GetSoundSlot(SoundType.Custom, "Sounds/Custom/BlackHoleImpact"));
                if (projectile.velocity.X != oldVelocity.X)
                {
                    projectile.velocity.X = -oldVelocity.X;
                }
                if (projectile.velocity.Y != oldVelocity.Y)
                {
                    projectile.velocity.Y = -oldVelocity.Y;
                }
            }
            return false;
        }
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            //Redraw the projectile with the color not influenced by light
            Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
            for (int k = 0; k < projectile.oldPos.Length; k++)
            {
                Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
                Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
                spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
            }
            return true;
        }
    }
}
