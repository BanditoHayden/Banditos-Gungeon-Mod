using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;

namespace GungeonMod.Items.Weapons.Ranged.DragunFire
{
	public class DragunFire : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragunfire");
			Tooltip.SetDefault("Roar\n");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 14;
			item.useTime = 8;
			item.useAnimation = 8;
			item.knockBack = 0;
			item.value = 10000;
			item.ranged = true;
			item.crit = 4;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("DragunFireProj");
			item.shootSpeed = 12.7f;
			// Other
			item.UseSound = SoundID.Item11;
			item.rare = 3;
			item.scale = 1.1f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
		

	}
}
