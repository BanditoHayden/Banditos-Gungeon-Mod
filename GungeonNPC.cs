using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using GungeonMod.Items.Weapons.Ranged.ShockRifle;
using GungeonMod.Items.Weapons.Ranged.AWP;
using GungeonMod.Items.Weapons.Ranged.JK47;
using GungeonMod.Items.Weapons.Ranged.TheExotic;
using GungeonMod.Items.Accessories.BulletUpgrades.GhostBullets;
using GungeonMod.Items.Accessories.BulletUpgrades.IrradiatedLead;
using GungeonMod.Items.Accessories.BulletUpgrades.RocketBullets;
using GungeonMod.Items.Accessories.BulletUpgrades;
using GungeonMod.Items.Accessories.BulletUpgrades.SilverBullets;
using GungeonMod.Items.Accessories.Passives.HeartSynthesizer;
using GungeonMod.Items.Actives.DoubleVision;
using GungeonMod.Items.Weapons.Ranged.BeeHive;
using GungeonMod.Items.Weapons.Ranged.Cactus;
using GungeonMod.Items.Accessories.Passives.Broccoli;

namespace GungeonMod
{
    public class GungeonNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.MartianSaucerCore)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ShockRifle>(), 5));
            }
            if (npc.type == NPCID.DukeFishron)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<AWP>(), 4));
            }
            if (npc.type == NPCID.Hornet)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<IrradiatedLead>(), 25));
            }
            // ghorn
            if (npc.type == NPCID.AngryTrapper)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheExotic>(), 200));

            }
            if (npc.type == NPCID.Arapaima)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheExotic>(), 200));
            }
            if (npc.type == NPCID.Derpling)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheExotic>(), 200));
            }
            if (npc.type == NPCID.GiantFlyingFox)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheExotic>(), 200));
            }
            if (npc.type == NPCID.GiantTortoise)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheExotic>(), 200));
            }
            if (npc.type == NPCID.AnglerFish)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheExotic>(), 200));
            }
            // ghost bullets
            if (npc.type == NPCID.TacticalSkeleton)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            if (npc.type == NPCID.SkeletonSniper)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            if (npc.type == NPCID.BoneLee)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 25));
            }
            if (npc.type == NPCID.DungeonSpirit)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 25));
            }
            if (npc.type == NPCID.SkeletonCommando)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            if (npc.type == NPCID.GiantCursedSkull)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 25));
            }
            if (npc.type == NPCID.Necromancer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            if (npc.type == NPCID.NecromancerArmored)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            if (npc.type == NPCID.Paladin)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 25));
            }
            if (npc.type == NPCID.NecromancerArmored)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            if (npc.type == NPCID.RaggedCaster)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            if (npc.type == NPCID.RaggedCasterOpenCoat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            if (npc.type == NPCID.DiabolistRed)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            if (npc.type == NPCID.DiabolistWhite)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GhostBullets>(), 100));
            }
            //
            if (npc.type == NPCID.PossessedArmor) 
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<SilverBullets>(), 25));
            }
            if (npc.type == NPCID.WanderingEye)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DoubleVision>(), 25));
            }
            if (npc.type == NPCID.EyeofCthulhu)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DoubleVision>(), 100));
            }
            if (npc.type == NPCID.QueenBee)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BeeHive>(), 10));
            }
        }
       
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (NPC.downedBoss3) // skeletron
            {
                if (type == NPCID.ArmsDealer)
                {
                    shop.item[nextSlot].SetDefaults(ModContent.ItemType<JK47>());
                    nextSlot++; // Don't forget this line, it is essential.

                }
            }
            if (type == NPCID.Cyborg)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<RocketBullets>());
                nextSlot++;
            }
            if (type == NPCID.Merchant)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<HeartSynthesizer>());
                nextSlot++;
            }

            if (Main.hardMode)
            {
                if (type == NPCID.Dryad)
                {
                    shop.item[nextSlot].SetDefaults(ModContent.ItemType<Broccoli>());
                    nextSlot++; // Don't forget this line, it is essential.

                }
            }



        }
        public bool Needle;
        public override void ResetEffects(NPC npc)
        {
           Needle = false;
        }

      




    }
   



}
