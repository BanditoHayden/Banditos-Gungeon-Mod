
using GungeonMod.Items.Accessories.BulletUpgrades.Plus1Bullets;
using GungeonMod.Items.Weapons.Ranged.BlackHoleGun;
using GungeonMod.Items.Accessories.Passives.BionicLeg;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using GungeonMod.Items.Actives.PotionofGunFriendship;

namespace GungeonMod
{
    public class GungeonItem : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            float spawnChance = Main.rand.NextFloat();
            switch (arg)
            {
                case ItemID.MoonLordBossBag:
                    if (spawnChance < 0.67f)
                    {
                        player.QuickSpawnItem(player.GetItemSource_OpenItem(ItemID.MoonLordBossBag),ModContent.ItemType<BlackHoleGun>());
                    }
                    break;
                case ItemID.GolemBossBag:
                    if (spawnChance < 0.67f)
                    {
                        player.QuickSpawnItem(player.GetItemSource_OpenItem(ItemID.MoonLordBossBag), ModContent.ItemType<Plus1Bullets>());
                    }
                    break;
                case ItemID.SkeletronPrimeBossBag:
                    if (spawnChance < 0.67f)
                    {
                        player.QuickSpawnItem(player.GetItemSource_OpenItem(ItemID.MoonLordBossBag), ModContent.ItemType<BionicLeg>());
                    }
                    break;
                case ItemID.WallOfFleshBossBag:
                    if (spawnChance < 0.67f)
                    {
                        player.QuickSpawnItem(player.GetItemSource_OpenItem(ItemID.MoonLordBossBag), ModContent.ItemType<PotionofGunFriendship>());
                    }
                    break;
            }
        }
    }
}
