using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_Chaos_Helper
{
    class Filter
    {
        private string start = "# Chaos Helper - Start #";
        private string stop = "# Chaos Helper - Stop #";
        private string template = "Show\n" +
            "SetBorderColor 50 130 165 255\n" +
            "SetFontSize 45\n" +
            "SetTextColor 50 130 165 255\n" +
            "SetBackgroundColor 255 255 255 255\n" +
            "PlayAlertSound 1 300\n" +
            "PlayEffect Red\n" +
            "MinimapIcon 0 Red Cross\n" +
            "ItemLevel >= 60\n" +
            "Rarity = Rare\n" +
            "{0}\n" +
            "Identified False\n" +
            "ItemLevel <= 74";

        public void Modify(string path, List<string> filterClasses)
        {
            var oldFilterClasses = Properties.Settings.Default.FilterClasses;

            // if nothing changed, we don't have to change to filter
            if (oldFilterClasses != null && oldFilterClasses.SequenceEqual(filterClasses))
                return;
            else
            {
                Properties.Settings.Default.FilterClasses = filterClasses;
                Properties.Settings.Default.Save();

                //MessageBox.Show("Filter changed, pls refresh!", "Alert");
            }

            // preventing empty Class in filter
            if (filterClasses.Count == 0)
                template = "";

            string filterClassStr = "Class ";
            foreach (var filterClass in filterClasses)
            {
                filterClassStr += String.Format("\"{0}\" ", filterClass);
            }

            List<string> filterFileLines = new List<string>(System.IO.File.ReadAllLines(Properties.Settings.Default.FilterPath));


            int lineStart = -1;
            int lineStop = -1;

            for (int i = 0; i < filterFileLines.Count; i++)
            {
                string line = filterFileLines[i];

                if (line == start)
                {
                    lineStart = i;
                }
                else if (line == stop)
                {
                    lineStop = i;
                }
            }

            if(lineStart != -1 && lineStop != -1)
            {
                for (int i = lineStop; i > lineStart - 1; i--)
                {
                    filterFileLines.RemoveAt(i);
                }

                filterFileLines.InsertRange(lineStart, new List<string> { start, String.Format(template, filterClassStr), stop });

                System.IO.File.WriteAllLines(path, filterFileLines);
            }

        }

    }
}
