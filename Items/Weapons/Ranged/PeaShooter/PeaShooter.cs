using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
namespace GungeonMod.Items.Weapons.Ranged.PeaShooter
{
	public class PeaShooter : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Baby's First Gun\nTraditionally given to Gungeoneers when they first arrive at the Gungeon. It is incredibly weak..");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
		public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 7;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.knockBack = 2;
			Item.value = 800;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 4;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.shoot = ModContent.ProjectileType<Pea>();
			Item.shootSpeed = 6.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/PeaShot");
			Item.rare = 2;
			Item.scale = 1.1f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}

	}
}