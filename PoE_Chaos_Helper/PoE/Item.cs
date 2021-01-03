using System;
using System.Collections.Generic;

namespace PoE_Chaos_Helper.PoE
{
    public enum ItemType
    {
        OneHandWeapons,
        Helmets,
        BodyArmours,
        Gloves,
        Boots,
        Belts,
        Amulets,
        Rings,
        NotImplemented
    }

    public class Item
    {
        public bool verified { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public int ilvl { get; set; }
        public string icon { get; set; }
        public string league { get; set; }
        public string id { get; set; }
        public bool elder { get; set; }
        public bool shaper { get; set; }
        public bool fractured { get; set; }
        // public Sockets sockets { get; set; } (NotImplemented)
        public string name { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public bool corrupted { get; set; }
        // public ItemLineContent properties { get; set; } (NotImplemented)
        public List<string> utilityMods { get; set; }
        public List<string> craftedMods { get; set; }
        public List<string> enchantMods { get; set; }
        public List<string> fracturedMods { get; set; }
        public List<string> flavourText { get; set; }
        public string descrText { get; set; }
        public string secDescrText { get; set; }
        public int frameType { get; set; }
        // category (NotImplemented)
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
        public bool isRelic { get; set; }
        // socketetedItems (NotImplemented)
        public int socket { get; set; }
        public string colour { get; set; }


        // custom

        public ItemType ItemType {
            get 
            {
                if (icon.Contains("OneHandWeapons"))
                    return ItemType.OneHandWeapons;
                else if (icon.Contains("Helmets"))
                    return ItemType.Helmets;
                else if (icon.Contains("BodyArmours"))
                    return ItemType.BodyArmours;
                else if (icon.Contains("Gloves"))
                    return ItemType.Gloves;
                else if (icon.Contains("Boots"))
                    return ItemType.Boots;
                else if (icon.Contains("Belts"))
                    return ItemType.Belts;
                else if (icon.Contains("Amulets"))
                    return ItemType.Amulets;
                else if (icon.Contains("Rings"))
                    return ItemType.Rings;
                else
                    return ItemType.NotImplemented;
            } 
            set
            {
                ItemType = value; 
            } 
        }

    }

}