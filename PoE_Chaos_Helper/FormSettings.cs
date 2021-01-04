using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_Chaos_Helper
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        #region Events
        private void FormSettings_Load(object sender, EventArgs e)
        {
            textBoxPoeSessId.Text = Properties.Settings.Default.POESESSID;
            textBoxLeague.Text = Properties.Settings.Default.League;
            textBoxAccountName.Text = Properties.Settings.Default.AccountName;
            textBoxTabIndex.Text = Properties.Settings.Default.TabIndex.ToString();
            textBoxMaxSets.Text = Properties.Settings.Default.MaxSets.ToString();
            textBoxFilterPath.Text = Properties.Settings.Default.FilterPath;
            textBoxOverlayLocation.Text = Properties.Settings.Default.OverlayLocation.ToString();
            textBoxOverlaySize.Text = Properties.Settings.Default.OverlaySize.ToString();
            textBoxOverlayHotkey.Text = Properties.Settings.Default.OverlayHotkey;

            // convert saveable collection to string
            var filterTemplateCollection = Properties.Settings.Default.FilterTemplate;
            var filterTemplateList = filterTemplateCollection.Cast<string>().ToList();
            textBoxFilterTemplate.Text = string.Join(Environment.NewLine, filterTemplateList);

            // overlay border
            if (Properties.Settings.Default.OverlayBorder == false)
                radioButtonHide.Checked = true;
            else
                radioButtonShow.Checked = true;
        }

        private void textBoxFilterPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select your Filter";
            openFileDialog.Filter = "Filter Files (*.filter)|*.filter";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filter = openFileDialog.FileName;
                textBoxFilterPath.Text = filter;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.POESESSID = textBoxPoeSessId.Text;
            Properties.Settings.Default.League = textBoxLeague.Text;
            Properties.Settings.Default.AccountName = textBoxAccountName.Text;
            Properties.Settings.Default.TabIndex = int.Parse(textBoxTabIndex.Text);
            Properties.Settings.Default.MaxSets = int.Parse(textBoxMaxSets.Text);
            Properties.Settings.Default.FilterPath = textBoxFilterPath.Text;

            // parse string to system.drawing.point
            var p = Regex.Replace(textBoxOverlayLocation.Text, @"[\{\}a-zA-Z=]", "").Split(',');
            Point point = new Point(int.Parse(p[0]), int.Parse(p[1]));
            Properties.Settings.Default.OverlayLocation = point;

            // parse string to system.drawing.size
            p = Regex.Replace(textBoxOverlaySize.Text, @"[\{\}a-zA-Z=]", "").Split(',');
            Size size = new Size(int.Parse(p[0]), int.Parse(p[1]));
            Properties.Settings.Default.OverlaySize = size;

            // convert string to saveable collection 
            var filterTemplateText = textBoxFilterTemplate.Text;
            string[] filterTemplateLines = filterTemplateText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            StringCollection filterTemplateColl = new StringCollection();
            filterTemplateColl.AddRange(filterTemplateLines);
            Properties.Settings.Default.FilterTemplate = filterTemplateColl;

            // overlay border
            if (radioButtonHide.Checked)
                Properties.Settings.Default.OverlayBorder = false;
            else
                Properties.Settings.Default.OverlayBorder = true;

            // overlay hotkey
            Properties.Settings.Default.OverlayHotkey = textBoxOverlayHotkey.Text;

            Properties.Settings.Default.Save();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            var contextMenu = menuItem.GetCurrentParent() as ContextMenuStrip;
            var textBox = contextMenu.SourceControl;

            if(textBox == textBoxFilterTemplate)
            {
                textBox.Text = "Show" + Environment.NewLine +
                    "SetBorderColor 50 130 165 255" + Environment.NewLine +
                    "SetFontSize 45" + Environment.NewLine +
                    "SetTextColor 50 130 165 255" + Environment.NewLine +
                    "SetBackgroundColor 255 255 255 255" + Environment.NewLine +
                    "PlayAlertSound 1 300" + Environment.NewLine +
                    "PlayEffect Red" + Environment.NewLine +
                    "MinimapIcon 0 Red Cross" + Environment.NewLine +
                    "Rarity = Rare" + Environment.NewLine +
                    "Identified False" + Environment.NewLine +
                    "ItemLevel >= 60" + Environment.NewLine +
                    "ItemLevel <= 74";
            }
            else if(textBox == textBoxOverlayLocation)
            {
                textBox.Text = "{X=16,Y=126}";
            }
            else if (textBox == textBoxOverlaySize)
            {
                textBox.Text = "{Width=635, Height=635}";
            }
            else if (textBox == textBoxOverlayHotkey)
            {
                textBox.Text = "Alt + Shift + S"; 
            }

        }

        #endregion

    }
}
