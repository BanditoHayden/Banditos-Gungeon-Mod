using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;

namespace GungeonMod.Items.Weapons.Ranged.JK47
{
    public class JK47 : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jk-47");
			Tooltip.SetDefault("Substitute\nNoodle shaped like a gun. Frightens enemies.");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 26;
			item.useTime = 25;
			item.useAnimation = 25;
			item.knockBack = 2;
			item.value = 110000;
			item.ranged = true;
			item.crit = 50;
			// How the item works
			item.autoReuse = true;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = 10;
			item.shootSpeed = 6.7f;
			// Other
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/JK47shot");
			item.rare = 2;
			item.scale = 1.1f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}




    }




}

