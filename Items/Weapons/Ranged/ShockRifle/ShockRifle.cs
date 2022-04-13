using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
namespace GungeonMod.Items.Weapons.Ranged.ShockRifle
{
   public class ShockRifle : ModItem
    {
        public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("Zap\nThe Shock Rifle uses a modified battery and coil to propel electricity.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
        public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 98;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.knockBack = 4;
			Item.value = 800000;
			Item.crit = 15;
			// How the item works
			Item.DamageType = DamageClass.Ranged;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.shoot = ModContent.ProjectileType<ShockBeam>();
			Item.shootSpeed = 10.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/Zap");
			Item.rare = 8;
			Item.scale = 1.1f;
		}
		public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback) {
		Vector2 muzzleOffset = Vector2.Normalize(velocity) * 25f;
		if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0)) {
			position += muzzleOffset;
		}
	}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}

	}
}
public class ShockBeam : ModProjectile
{
	public override void SetDefaults()
	{
		Projectile.width = 4;
		Projectile.height = 4;
		// NO! projectile.aiStyle = 48;
		Projectile.friendly = true;
		Projectile.DamageType = DamageClass.Ranged;
		Projectile.extraUpdates = 10;
		Projectile.timeLeft = 200; // lowered from 300
		Projectile.penetrate = -1;
	}
	public override string Texture => "Terraria/Projectile_" + ProjectileID.ShadowBeamFriendly;

	public override void AI()
	{
		Vector2 projectilePosition = Projectile.position;

		Projectile.alpha = 255;
		// Important, changed 173 to 178!
		int dust = Dust.NewDust(projectilePosition, 1, 1, 176, 0f, 0f, 0, default(Color), 1f);
		Main.dust[dust].noGravity = true;
		Main.dust[dust].position = projectilePosition;
		Main.dust[dust].scale = (float)Main.rand.Next(70, 110) * 0.013f;
		Main.dust[dust].velocity *= 0.2f;
	}
}