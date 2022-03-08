using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GungeonMod.Items.Herbs
{
 public  class PeaPod : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("peas lol");
        }
        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 18;
            item.height = 15;
            item.knockBack = 1;
            item.maxStack = 999;
            item.consumable = true;
            item.value = 80;
            item.rare = 2;
           	item.shoot = mod.ProjectileType("Pea");
            item.shootSpeed = 1f;
            item.ammo = ModContent.ItemType<PeaPod>();
        }
    }
}
