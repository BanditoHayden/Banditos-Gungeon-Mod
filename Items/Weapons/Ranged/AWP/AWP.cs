using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;
namespace GungeonMod.Items.Weapons.Ranged.AWP
{
  public  class AWP : ModItem
    {

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("A.W.P,");
			Tooltip.SetDefault("Noob Cannon\nAn extremely powerful rifle. Banned in some sectors, its ease of use caused it to be the weapon of choice for thousands of unskilled marksmen.");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 357;
			item.useTime = 40;
			item.useAnimation = 40;
			item.knockBack = 9;
			item.value = 110000;
			item.ranged = true;
			item.crit = 30;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = 10;
			item.shootSpeed = 18.7f;
			// Other
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/AWPshot");
			item.rare = 2;
			item.scale = 1.3f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}

	}
}
