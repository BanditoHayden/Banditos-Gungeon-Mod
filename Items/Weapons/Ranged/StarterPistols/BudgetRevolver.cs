using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
using GungeonMod.Items.Herbs;

namespace GungeonMod.Items.Weapons.Ranged.StarterPistols
{
	public class BudgetRevolver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Budget Revolver");
			Tooltip.SetDefault("Affordable Arms");
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
			item.useAmmo = AmmoID.Bullet;
			item.shoot = 10;
			item.shootSpeed = 12.7f;
			// Other
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Bpistol");
			item.rare = 1;
			item.scale = 1.3f;
			
            
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}











	}
}
