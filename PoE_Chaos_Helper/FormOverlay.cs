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
            int slots;
            if (tabType == "QuadStash")
                slots = 24;
            else
                slots = 12;

            float slotWidth = (float)Width / slots;
            float slotHeight = (float)Height / slots;

            Bitmap bitmap = new Bitmap(Width, Height);
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            HatchBrush semiTransBrush = new HatchBrush(HatchStyle.Percent50, TransparencyKey, Color.Red);

            foreach (var item in items)
            {
                float itemX = item.x * slotWidth;
                float itemY = item.y * slotHeight;
                float itemWidth = item.w * slotWidth;
                float itemHeight = item.h * slotHeight;

                bitmapGraphics.FillRectangle(semiTransBrush, itemX, itemY, itemWidth, itemHeight);
            }

            BackgroundImage = bitmap;
        }

        private void PaintItem(PoE.Item item, bool quadTab)
        {

        }

        private void FormOverlay_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.OverlayLocation;
            Size = Properties.Settings.Default.OverlaySize;

            // make click through
            
            uint initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);
            
            
        }

    }
}
