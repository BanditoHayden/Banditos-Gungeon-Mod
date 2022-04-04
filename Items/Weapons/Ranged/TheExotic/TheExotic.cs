using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;
namespace GungeonMod.Items.Weapons.Ranged.TheExotic
{
	public class TheExotic : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Exotic");
			Tooltip.SetDefault("Pack of Wolves");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 120;
			item.useTime = 20;
			item.useAnimation = 20;
			item.knockBack = 6;
			item.value = 1000;
			item.ranged = true;
			item.crit = 15;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			//item.useAmmo = AmmoID.Bullet;
			item.shoot = mod.ProjectileType("WolfPackRounds");
			item.shootSpeed = 12.7f;
			// Other
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/ExoticGunShot");
			item.rare = 9;
			item.scale = 1.3f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-22, 0);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			//recipe.AddIngredient(ModContent.ItemType<PeaPod>(), 12);
			recipe.AddIngredient(ItemID.FireworksLauncher,1);
			recipe.AddIngredient(ItemID.SnowmanCannon, 1);
			recipe.AddIngredient(ItemID.RocketLauncher, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
