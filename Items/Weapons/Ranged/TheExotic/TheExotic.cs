using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
			Item.damage = 100;
			Item.useTime = 50;
			Item.useAnimation = 50;
			Item.knockBack = 6;
			Item.value = 1000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 15;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			//item.useAmmo = AmmoID.Bullet;
			Item.shoot = ModContent.ProjectileType<WolfPackRounds>();
			Item.shootSpeed = 12.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/ExoticGunShot");
			Item.rare = 9;
			Item.scale = 1.3f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-22, 0);
		}
		
	}
}
