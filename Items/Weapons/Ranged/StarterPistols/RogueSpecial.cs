using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;

namespace GungeonMod.Items.Weapons.Ranged.StarterPistols
{
   public class RogueSpecial : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rogue Special");
			Tooltip.SetDefault("Underhanded And Efficient");
		}
		public override void SetDefaults()
		{
			// Stats of the item
			item.damage = 6;
			item.useTime = 20;
			item.useAnimation = 20;
			item.knockBack = 3;
			item.value = 1000;
			item.ranged = true;
			item.crit = 6;
			// How the item works
			item.autoReuse = false;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.shoot = mod.ProjectileType("RogueProj");
			item.shootSpeed = 12.7f;
			// Other
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/LaserShot");
			item.rare = 1;
			item.scale = 1.3f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}











	}
}
