using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;

namespace GungeonMod.Items.Weapons.Ranged.BigIron
{
   public class BigIron : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Big Iron");
			Tooltip.SetDefault("Heavy");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 15;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.knockBack = 8;
			Item.value = 10000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 10;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = 10;
			Item.shootSpeed = 9.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/Magnumshot");
			Item.rare = 2;
			Item.scale = 1.1f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
			const int NumProjectiles = 3;
			for (int i = 0; i < NumProjectiles; i++)
			{
				Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(5));
				newVelocity *= 1f - Main.rand.NextFloat(0.3f);
				Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.TheUndertaker, 1)
				.AddIngredient(ItemID.IronBar, 25)
				.AddTile(TileID.Anvils)
				.Register();
		}


	}
}
