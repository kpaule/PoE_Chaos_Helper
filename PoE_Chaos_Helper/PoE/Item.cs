using System;
using System.Collections.Generic;

namespace PoE_Chaos_Helper.PoE
{
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
        // public Sockets sockets { get; set; }
        public string name { get; set; }
        public string typeLine { get; set; }
        public bool identified { get; set; }
        public bool corrupted { get; set; }
        // public ItemLineContent properties { get; set; }
        public List<string> utilityMods { get; set; }
        public List<string> craftedMods { get; set; }
        public List<string> enchantMods { get; set; }
        public List<string> fracturedMods { get; set; }
        public List<string> flavourText { get; set; }
        public string descrText { get; set; }
        public string secDescrText { get; set; }
        public int frameType { get; set; }
        // category
        public int x { get; set; }
        public int y { get; set; }
        public string inventoryId { get; set; }
        public bool isRelic { get; set; }
        // socketetedItems
        public int socket { get; set; }
        public string colour { get; set; }

    }
}