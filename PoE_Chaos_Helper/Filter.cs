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
        private string template;

        public void Modify(string path, List<string> filterClasses)
        {
            // convert saveable collection to string
            var filterTemplateCollection = Properties.Settings.Default.FilterTemplate;
            var filterTemplateList = filterTemplateCollection.Cast<string>().ToList();
            template = string.Join(Environment.NewLine, filterTemplateList);
            template += Environment.NewLine + "{0}";

            // preventing edge case: empty Class in filter
            if (filterClasses.Count == 0)
                template = "";

            // build class string
            string filterClassStr = "Class ";
            foreach (var filterClass in filterClasses)
            {
                filterClassStr += String.Format("\"{0}\" ", filterClass);
            }

            // read the specified filter text
            List<string> filterFileLines = new List<string>(System.IO.File.ReadAllLines(Properties.Settings.Default.FilterPath));

            int lineStart = -1;
            int lineStop = -1;
            // search for 'start' and 'stop' stop tags
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

            // both start and stop tags exist
            if(lineStart != -1 && lineStop != -1)
            {
                // check if we have to write an update
                bool updateRequired = true;
                for (int i = lineStart; i < lineStop; i++)
                {
                    var currLine = filterFileLines[i];
                    if (currLine.Contains(filterClassStr))
                    {
                        updateRequired = false;
                    }
                }

                if (updateRequired)
                {
                    // delete existing lines
                    for (int i = lineStop; i > lineStart - 1; i--)
                    {
                        filterFileLines.RemoveAt(i);
                    }

                    // write template between tags
                    filterFileLines.InsertRange(lineStart, new List<string> { start, String.Format(template, filterClassStr), stop });

                    System.IO.File.WriteAllLines(path, filterFileLines);

                    MessageBox.Show("Filter changed, pls refresh!", "Alert", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Can't find start and stop tags. Please adjust your filter.", "Alert", MessageBoxButtons.OK);
            }

        }

    }
}
