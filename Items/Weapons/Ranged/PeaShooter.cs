using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
namespace GungeonMod.Items.Weapons.Ranged.PeaShooter
{
	public class PeaShooter : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Baby's First Gun\nTraditionally given to Gungeoneers when they first arrive at the Gungeon. It is incredibly weak..");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 8;
			item.useTime = 15;
			item.useAnimation = 15;
			item.knockBack = 2;
			item.value = 800;
			item.ranged = true;
			item.crit = 4;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("Pea");
			item.shootSpeed = 6.7f;
			// Other
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/PeaShot");
			item.rare = 8;
			item.scale = 1.1f;
		}
		
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}

	}
}