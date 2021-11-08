using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanitiesOfRyuse.Items.MAIDChanVanity
{
    [AutoloadEquip(EquipType.Head)]
    public class MAIDChanHair : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MAID-chan's Wig");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 28;
            item.rare = ItemRarityID.Green;
            item.vanity = true;
            item.value = Item.buyPrice(gold: 1);
        }

        //public override bool IsVanitySet(int head, int body, int legs)
        //{
        //    return head == mod.GetEquipSlot("GuraGawrHeadHair", EquipType.Head) 
        //        && body == mod.GetEquipSlot("GuraGawrBody", EquipType.Body)
        //        && legs == mod.GetEquipSlot("GuraGawrLeg", EquipType.Legs);
        //}

        //public override void UpdateVanitySet(Player player)
        //{
        //    player.Friends().extraBodyDyesNeeded += 2;
        //}

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = false;  //player make so the player hair does not show when the vanity mask is equipped.  add true if you want to show the player hair.
        }
    }
}
