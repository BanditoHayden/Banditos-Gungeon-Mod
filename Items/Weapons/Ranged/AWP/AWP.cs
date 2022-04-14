using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
namespace GungeonMod.Items.Weapons.Ranged.AWP
{
  public  class AWP : ModItem
    {

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("A.W.P,");
			Tooltip.SetDefault("Noob Cannon\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 357;
			Item.useTime = 40;
			Item.useAnimation = 40;
			Item.knockBack = 9;
			Item.value = 110000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 30;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.useAmmo = AmmoID.Bullet;
			Item.shoot = 10;
			Item.shootSpeed = 18.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/AWPshot");
			Item.rare = 9;
			Item.scale = 1.3f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}

	}
}
