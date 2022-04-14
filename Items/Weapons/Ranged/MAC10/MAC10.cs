using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
namespace GungeonMod.Items.Weapons.Ranged.MAC10
{
   public class MAC10 : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MAC10");
			Tooltip.SetDefault("$#!^@ Never End\nHigh rate of fire and relatively compact, making it a favorite among Gungeoneers and criminals alike.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 34;
			Item.useTime = 4;
			Item.useAnimation = 16;
			Item.reuseDelay = 18;
			Item.knockBack = 2;
			Item.value = 990000;
			Item.DamageType = DamageClass.Ranged;           
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = 10;
			Item.shootSpeed = 6.7f;
			// Other
			Item.UseSound = SoundID.Item31;
			Item.rare = 7;
			Item.scale = 1.1f;
		}
		public override void AddRecipes()
		{
			CreateRecipe()

			.AddIngredient(ItemID.Uzi, 1)
			.AddIngredient(ItemID.ClockworkAssaultRifle, 1)
			.AddIngredient(ItemID.IllegalGunParts, 1)
			.AddTile(TileID.MythrilAnvil)
			.Register();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
	}
}
