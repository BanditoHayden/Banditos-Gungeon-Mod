using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System;
using Terraria.Localization;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;


namespace GungeonMod
{
   public class GungeonPlayer : ModPlayer
    {
         public bool SnowBallets;
        public int SnowBalletsCD;
        public bool GhostBullets;
        public bool RocketBullets;
        public bool IrradiatedLead;
        public bool HotLead;
        public bool SilverBullets;
        public override void ResetEffects()
        {
            SnowBallets = false;
            GhostBullets = false;
            RocketBullets = false;
            IrradiatedLead = false;
            HotLead = false;
            SilverBullets = false;
        }
        public override float UseTimeMultiplier(Item item)
        {
            float mult = 1f;
            if (RocketBullets && item.ranged)
            {
                mult += 0.1f;
            }
            return mult;
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (IrradiatedLead)
            {
                target.AddBuff(BuffID.Poisoned, 200);
            }
            if (HotLead)
            {
                target.AddBuff(BuffID.OnFire, 200);
            }
           
      
        
        
        
        }
        public override void PreUpdate()
        {
            if (SnowBallets && SnowBalletsCD > 0)
                SnowBalletsCD--;
        }
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
          if (SilverBullets && proj.ranged)
            {
                if (target.boss)
                {
                    damage = (int)(damage * 1.5f);
                }
                else
                {
                    damage /= 2;
                }
            }
        }





    }
}
