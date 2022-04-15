using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;

namespace GungeonMod.Items.Weapons.Ranged.VulcanCannon
{
	public class VulcanCannon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vulcan Cannon");
			Tooltip.SetDefault("Boundless Slaughter\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 9;
			Item.useTime = 4;
			Item.useAnimation = 4;
			Item.knockBack = 0;
			Item.value = 10000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 4;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = 10;
			Item.shootSpeed = 12.7f;
			// Other
			Item.UseSound = SoundID.Item11;
			Item.rare = 3;
		
			
			Item.scale = 1.1f;
		}
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
			const int NumProjectiles = 2;
			for (int i = 0; i < NumProjectiles; i++)
			{
				Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(5));
				newVelocity *= 1f - Main.rand.NextFloat(0.3f);
				
				Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
        public override bool CanConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= 0.30f;
		}

		public override void AddRecipes()
		{
			CreateRecipe()

			.AddIngredient(ItemID.Minishark, 1)
			.AddIngredient(ItemID.HellstoneBar, 10)
			.AddCondition(Recipe.Condition.NearLava)
			.Register();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}


	}
}
