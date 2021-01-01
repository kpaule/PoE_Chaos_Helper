using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE_Chaos_Helper.PoE
{
    class Stash
    {
        public int numTabs { get; set; }
        public List<Tab> tabs { get; set; }
        public bool quadLayout { get; set; }
        public List<Item> items { get; set; }

    }
}
