using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_Chaos_Helper
{
    public partial class FormOverlay : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, UInt32 dwNewLong);

        public FormOverlay()
        {
            InitializeComponent();
        }

        public void PaintItems(List<PoE.Item> items, string tabType)
        {
            // sort the items into chaos recipe sets.
            var itemSets = GetItemSets(items);


            int slots;
            if (tabType == "QuadStash")
                slots = 24;
            else
                slots = 12;

            float slotWidth = (float)Width / slots;
            float slotHeight = (float)Height / slots;

            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);

            // show OverlayBorder for easy config
            if (Properties.Settings.Default.OverlayBorder == true)
            {
                HatchBrush semiTransBrush = new HatchBrush(HatchStyle.Percent50, TransparencyKey, Color.WhiteSmoke);
                bitmapGraphics.FillRectangle(semiTransBrush, 0, 0, Width, Height);
            }

            int setCount = 0;
            foreach(var set in itemSets)
            {
                Color[] colArr = { Color.Yellow, Color.Red, Color.Purple, Color.DarkBlue, Color.Blue, Color.LightBlue, Color.Cyan, Color.Green, Color.LightGreen, Color.Pink, Color.Beige, Color.Brown, Color.DarkRed, Color.Olive, Color.Orange, Color.Salmon };

                HatchBrush semiTransBrush = new HatchBrush(HatchStyle.Percent75, TransparencyKey, colArr[setCount]);

                foreach (PoE.Item item in set.Values)
                {
                    float itemX = item.x * slotWidth;
                    float itemY = item.y * slotHeight;
                    float itemWidth = item.w * slotWidth;
                    float itemHeight = item.h * slotHeight;

                    bitmapGraphics.FillRectangle(semiTransBrush, itemX, itemY, itemWidth, itemHeight);
                }

                if (setCount >= colArr.Length - 1)
                {
                    // oh no! we ran out of colors
                    break;
                }
                else
                    setCount++;
            }

            BackgroundImage = bitmap;
        }

        private List<Dictionary<String, PoE.Item>> GetItemSets(List<PoE.Item> items)
        {
            List<Dictionary<String, PoE.Item>> matrix = new List<Dictionary<String, PoE.Item>>();

            foreach (var item in items)
            {
                string type;

                if (item.icon.Contains("Wands") || item.icon.Contains("OneHandSwords") || item.icon.Contains("Daggers"))
                {
                    type = "OneHanded";
                }
                else if (item.icon.Contains("Helmets"))
                {
                    type = "Helmets";
                }
                else if (item.icon.Contains("BodyArmours"))
                {
                    type = "BodyArmours";
                }
                else if (item.icon.Contains("Gloves"))
                {
                    type = "Gloves";
                }
                else if (item.icon.Contains("Boots"))
                {
                    type = "Boots";
                }
                else if (item.icon.Contains("Belts"))
                {
                    type = "Belts";
                }
                else if (item.icon.Contains("Amulets"))
                {
                    type = "Amulets";
                }
                else if (item.icon.Contains("Rings"))
                {
                    type = "Rings";
                }
                else
                {
                    type = "Nothing";
                }

                if (type != "Nothing")
                {
                    bool foundSet = false;
                    foreach (var set in matrix)
                    {

                        if (!set.ContainsKey(type))
                        {
                            set.Add(type, item);
                            foundSet = true;
                            break;
                        }
                        else
                        {
                            // for rings we have to check if there are 2.
                            if (type == "Rings")
                            {
                                if (set.ContainsKey("Rings2") == false)
                                {
                                    set.Add("Rings2", item);
                                    foundSet = true;
                                    break;
                                }
                            }
                            else if (type == "OneHanded")
                            {
                                if (set.ContainsKey("OneHanded2") == false)
                                {
                                    set.Add("OneHanded2", item);
                                    foundSet = true;
                                    break;
                                }
                            }
                        }
                    }

                    if (foundSet == false)
                    {
                        Dictionary<String, PoE.Item> temp = new Dictionary<string, PoE.Item>();
                        temp.Add(type, item);
                        matrix.Add(temp);
                    }

                }

            }

            for (int i = matrix.Count; i > 0; i--)
            {
                var set = matrix.ElementAt(i - 1);

                if (set.Count < 10)
                {
                    matrix.RemoveAt(i - 1);
                }
            }

            return matrix;
        }

        #region Events
        private void FormOverlay_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.OverlayLocation;
            Size = Properties.Settings.Default.OverlaySize;

            // make click through
            
            uint initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            
            
        }
        #endregion

    }
}
