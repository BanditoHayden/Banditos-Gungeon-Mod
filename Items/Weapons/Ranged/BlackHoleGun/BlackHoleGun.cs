using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;
namespace GungeonMod.Items.Weapons.Ranged.BlackHoleGun
{
	public class BlackHoleGun : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Hole Gun");
			Tooltip.SetDefault("Won't You Come\n");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 80;
			item.useTime = 160;
			item.useAnimation = 160;
			item.knockBack = 9;
			item.value = 550000;
			item.ranged = true;
			item.crit = 30;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			
			item.shoot = mod.ProjectileType("BlackHole");
			item.shootSpeed = 4.7f;
			// Other
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BlackHoleShot");
			item.rare = 9;
			item.scale = 1.3f;
		}
		public override bool CanUseItem(Player player)
		{
			// test
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}

	}
}
