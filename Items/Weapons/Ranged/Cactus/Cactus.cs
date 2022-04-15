using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using GungeonMod.Items.Weapons.Ranged.Cactus;

namespace GungeonMod.Items.Weapons.Ranged.Cactus
{
	public class Cactus : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cactus");
			Tooltip.SetDefault("1000 Needles!\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 3;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.knockBack = 0;
			Item.value = 10000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 4;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.shoot = ModContent.ProjectileType<Needle>();
			Item.shootSpeed = 9.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/Cactus");
			Item.rare = 3;
			Item.scale = .7f;
		}
		public override void AddRecipes()
		{
			CreateRecipe()

			.AddIngredient(ItemID.Cactus, 50)
			.AddCondition(Recipe.Condition.InDesert)
			.Register();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}

	}
}
