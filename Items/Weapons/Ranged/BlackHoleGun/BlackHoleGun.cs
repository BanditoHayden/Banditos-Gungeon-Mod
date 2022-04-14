using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
			Item.damage = 80;
			Item.useTime = 160;
			Item.useAnimation = 160;
			Item.knockBack = 9;
			Item.value = 550000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 30;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;

			Item.shoot = ModContent.ProjectileType<BlackHole>();
			Item.shootSpeed = 4.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/BlackHoleShot");
			Item.rare = 9;
			Item.scale = 1.3f;
		}
		public override bool CanUseItem(Player player)
		{
			// test
			return player.ownedProjectileCounts[Item.shoot] < 1;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}

	}
}
