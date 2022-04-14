using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
namespace GungeonMod.Items.Weapons.Ranged.DragunFire
{
	public class DragunFire : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dragunfire");
			Tooltip.SetDefault("Roar\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 14;
			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.knockBack = 0;
			Item.value = 10000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 4;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.shoot = ModContent.ProjectileType<DragunFireProj>();
			Item.shootSpeed = 12.7f;
			// Other
			Item.UseSound = SoundID.Item11;
			Item.rare = 3;
			Item.scale = 1.1f;
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
