using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
namespace GungeonMod.Items.Blanks
{
  public class Blank : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blank");
            Tooltip.SetDefault("experimental");
        }
        public override void SetDefaults()
        {
            item.height = 24;
            item.width = 24;
            item.maxStack = 10;
            item.consumable = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 15;
            item.useTime = 15;
      
            item.value = Item.buyPrice(gold: 1);

            item.noMelee = true;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/Blanksound");
            item.thrown = true;
           // item.shoot = ModContent.ProjectileType<Blankproj>();
           // item.shootSpeed = 10f;
        }
        public override bool UseItem(Player player)
        {
          for (int i = 0; i < Main.projectile.Length -1; i++)
            {
                {
                    if (!Main.projectile[i].friendly == true &&!Main.projectile[i].minion)
                    {
                        Main.projectile[i].Kill();
                    }
                }
            }
            return true;
        }

    }
}
