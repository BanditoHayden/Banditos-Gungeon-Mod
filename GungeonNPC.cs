using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using System;
using Terraria.Localization;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using GungeonMod.Items.Weapons.Ranged.ShockRifle;
using GungeonMod.Items.Accessories.BulletUpgrades;
using GungeonMod.Items.Accessories.Passives;
using GungeonMod.Items.Herbs;
using GungeonMod.Items.Weapons.Ranged.JK47;
using GungeonMod.Items.Weapons.Ranged.AWP;
using GungeonMod.Items.Weapons.Ranged.BigIron;
using GungeonMod.Items.Weapons.Ranged.StarterPistols;
namespace GungeonMod
{
   public class GungeonNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.MartianSaucer)
            {
                if (Main.rand.NextBool(3))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<ShockRifle>());
                }
                    
            }
            if (npc.type == NPCID.Lihzahrd)
            {
                if (Main.rand.NextBool(100))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Plus1Bullets>());
                }

            }
            if (npc.type == NPCID.LihzahrdCrawler)
            {
                if (Main.rand.NextBool(50))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<Plus1Bullets>());
                }

            }
            if (npc.type == NPCID.JungleBat)
            {
                if (Main.rand.NextBool(200))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<IrradiatedLead>());
                }

            }
            if (npc.type == NPCID.DungeonSpirit)
            {
                if (Main.rand.NextBool(100))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<GhostBullets>());
                }

            }
            if (npc.type == NPCID.PossessedArmor)
            {
                if (Main.rand.NextBool(150))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<SilverBullets>());
                }

            }
            if (npc.type == NPCID.SkeletronPrime)
            {
                if (Main.rand.NextBool(5))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<BionicLeg>());
                }

            }
            if (npc.type == NPCID.DukeFishron)
            {
                if (Main.rand.NextBool(5))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<AWP>());
                }

            }
            if (npc.type == NPCID.GraniteGolem)
            {
                if (Main.rand.NextBool(15))
                {
                    Item.NewItem(npc.getRect(), ModContent.ItemType<BigIron>());
                }

            }






        }

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Cyborg)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<RocketBullets>());
                nextSlot++; // Don't forget this line, it is essential.

            }

            if (type == NPCID.Dryad)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<PeaSeeds>());
                nextSlot++; // Don't forget this line, it is essential.

            }
            if (type == NPCID.ArmsDealer)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<BudgetRevolver>());
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<MarineSidearm>());
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<RogueSpecial>());
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<RustySidearm>());




                nextSlot++; // Don't forget this line, it is essential.

            }
            if (NPC.downedBoss3)
            {
                if (type == NPCID.ArmsDealer)
                {
                    shop.item[nextSlot].SetDefaults(ModContent.ItemType<JK47>());
                    nextSlot++; // Don't forget this line, it is essential.

                }
            }

        }

    }
}
