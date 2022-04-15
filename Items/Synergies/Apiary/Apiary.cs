using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.DataStructures;
using GungeonMod.Items.Weapons.Ranged.BeeHive;
using GungeonMod.Items.Accessories.BulletUpgrades.Bumbullets;
using GungeonMod.Items.Actives.Box;
using System.Collections.Generic;

namespace GungeonMod.Items.Weapons.Synergies.Apiary
{
	public class Apiary : ModItem
	{
		
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("[c/07EBF2:Synergized!]\n[c/07EBF2:BEES] - Damage Increased by 50%, Rate of fire decreased by 20%\n[c/07EBF2:Apiary] - Less bees, larger bees\n");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
			
			foreach (TooltipLine line2 in tooltips)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color(Main.DiscoR = 204, Main.DiscoG = 255, Main.DiscoB = 255);
				}
			}
        }
        public override void SetDefaults()
		{
			// Stats of the item
			Item.damage = 28;
			Item.useTime = 60;
			Item.useAnimation = 60;
			Item.knockBack = 0;
			Item.value = 10000;
			Item.DamageType = DamageClass.Ranged;
			Item.crit = 10;
			// How the item works
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.shoot = 566;
			Item.shootSpeed = 12.7f;
			// Other
			Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/Apiary");
			Item.rare = -1;
			 
			Item.scale = 1.1f;
		}
		public override void AddRecipes()
		{
			CreateRecipe()

			.AddIngredient(ModContent.ItemType<BeeHive>(), 1)
			.AddIngredient(ModContent.ItemType<Bumbullets>(), 1)
			.AddIngredient(ModContent.ItemType<Box>(), 1)
			.AddTile(TileID.MythrilAnvil)
			.Register();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-2, 0);
		}
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			const int NumProjectiles = 3;
			for (int i = 0; i < NumProjectiles; i++)
			{
				Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(5));
				newVelocity *= 1f - Main.rand.NextFloat(0.3f);

				Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
			}
			return false;
		}

	}
}
