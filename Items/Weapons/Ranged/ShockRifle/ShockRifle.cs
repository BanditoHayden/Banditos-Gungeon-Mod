
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
namespace GungeonMod.Items.Weapons.Ranged.ShockRifle
{
   public class ShockRifle : ModItem
    {
        public override void SetStaticDefaults()
        {
			Tooltip.SetDefault("Zap\nThe Shock Rifle uses a modified battery and coil to propel electricity.");
		}
        public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 98;
			item.useTime = 15;
			item.useAnimation = 20;
			item.knockBack = 4;
			item.value = 800000;
			item.ranged = true;
			item.crit = 17;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("ShockBeam");
			item.shootSpeed = 10.7f;
            // Other
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Zap");
			item.rare = 8;
			item.scale = 1.1f;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{

			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 55f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-10, 0);
		}

	}
}
