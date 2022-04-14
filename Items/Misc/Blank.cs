using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GungeonMod;
namespace GungeonMod.Items.Misc
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
            Item.height = 24;
            Item.width = 24;
            Item.maxStack = 10;
            Item.consumable = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useAnimation = 15;
            Item.useTime = 15;

            Item.value = Item.buyPrice(gold: 1);

            Item.noMelee = true;
            Item.UseSound = SoundLoader.GetLegacySoundSlot(Mod, "Sounds/Item/BlankSound");
            // item.shoot = ModContent.ProjectileType<Blankproj>();
            // item.shootSpeed = 10f;
        }
        public override bool? UseItem(Player player)
        {
            for (int i = 0; i < Main.projectile.Length - 1; i++)
            {
                {
                    if (!Main.projectile[i].friendly == true && !Main.projectile[i].minion)
                    {
                        Main.projectile[i].Kill();
                    }
                }
            }
            return true;
        }
    }
}