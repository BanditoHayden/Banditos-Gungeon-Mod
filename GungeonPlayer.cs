using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;
using GungeonMod.Items.Weapons.Ranged.PeaShooter;
using GungeonMod.Items.Actives.DoubleVision;
using GungeonMod.Items.Actives.PotionofGunFriendship;

namespace GungeonMod
{
	public class GungeonPlayer : ModPlayer
	{
		public bool SnowBallets;
		public int SnowBalletsCD;
		public bool GhostBullets;
		public bool IrradiatedLead;
		public bool HotLead;
		public bool RocketBullets;
		public bool SilverBullets;
		public bool HeartSynthesizer;
		
		public override void ResetEffects()
        {
			SnowBallets = false;
			GhostBullets = false;
			RocketBullets = false;
			SilverBullets = false;
			HotLead = false;
			IrradiatedLead = false;
			HeartSynthesizer = false;
		}
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
			if (IrradiatedLead)
			{
				if (Main.rand.NextBool(10)) // 1 in 10 chance
				{
					target.AddBuff(BuffID.Poisoned, 200);
				}
			}
			if (HotLead)
			{
				if (Main.rand.NextBool(10)) // 1 in 10 chance
				{
					target.AddBuff(BuffID.OnFire, 200);
				}
			}
			if (SilverBullets && proj.CountsAsClass(DamageClass.Ranged))
			{
				if (target.boss)
				{
					damage = (int)(damage * 0.5f);
				}
				else
				{
					damage /= 2;
				}
			}
			if (Player.HasBuff(ModContent.BuffType<GunBuff>()))
			{
				knockback += 2;
			}

		}
        public override void ModifyWeaponDamage(Item item, ref StatModifier damage, ref float flat)
        {
			if (Player.HasBuff(ModContent.BuffType<GunBuff>()))
			{
				damage += 0.1f;
			}
		}
	
        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
			if (HeartSynthesizer)
			{
				if (Main.rand.Next(50) == 0)
				{
					Item.NewItem(proj.GetProjectileSource_FromThis(), target.getRect(), ItemID.Heart);
				}
			}
		}
		
        public override float UseSpeedMultiplier(Item item)
        {
			float mult = 1f;
			if (Player.HasBuff(ModContent.BuffType<VisionBuff>()))
			{
				mult += 0.5f;
			}
			if (RocketBullets && item.CountsAsClass(DamageClass.Ranged))
			{
				mult += 0.1f;
			}
			if (Player.HasBuff(ModContent.BuffType<GunBuff>()))
			{
				mult += 0.1f;
			}
			return mult;
		}

        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
			if (mediumCoreDeath)
			{
				return new[] {
					new Item(ItemID.HealingPotion),
				};
			}
			return new[] {
				new Item(ModContent.ItemType<PeaShooter>()),
			};
		}
		public override void PreUpdate()
		{
			if (SnowBallets && SnowBalletsCD > 0)
				SnowBalletsCD--;
		}

	}
}