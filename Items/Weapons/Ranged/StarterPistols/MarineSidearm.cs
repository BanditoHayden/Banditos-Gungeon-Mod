using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GungeonMod.Items.Weapons.Ranged.StarterPistols
{
	public class MarineSidearm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Marine Sidearm");
			Tooltip.SetDefault("Still works, mostly.");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 12;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.knockBack = 3;
			Item.value = 1000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 6;
			// How the item works
			Item.autoReuse = false;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = 10;
			Item.shootSpeed = 12.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/Apistols");
			Item.rare = 1;
			Item.scale = 1.3f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.IronBar, 12)
			.AddTile(TileID.Anvils)
			.Register();
		}










	}
}
