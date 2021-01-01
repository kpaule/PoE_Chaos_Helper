using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoE_Chaos_Helper.PoE
{
    class Colour
    {
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
    }

    class Tab
    {
        public string n { get; set; }
        public int i { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public bool selected { get; set; }
        public Colour colour { get; set; }
        public string srcL { get; set; }
        public string srcC { get; set; }
        public string srcR { get; set; }
    }
}
