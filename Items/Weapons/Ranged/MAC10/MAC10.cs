using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;

namespace GungeonMod.Items.Weapons.Ranged.MAC10
{
   public class MAC10 : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MAC10");
			Tooltip.SetDefault("$#!^@ Never End\nHigh rate of fire and relatively compact, making it a favorite among Gungeoneers and criminals alike.");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 34;
			item.useTime = 4;
			item.useAnimation = 16;
			item.reuseDelay = 18;
			item.knockBack = 2;
			item.value = 990000;
			item.ranged = true;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = 10;
			item.shootSpeed = 6.7f;
			// Other
			item.UseSound = SoundID.Item31;
			item.rare = 2;
			item.scale = 1.1f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			recipe.AddIngredient(ItemID.Uzi, 1);
			recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
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
	}
}
