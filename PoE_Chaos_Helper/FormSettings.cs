using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        private void FormSettings_Load(object sender, EventArgs e)
        {
            textBoxPoeSessId.Text = Properties.Settings.Default.POESESSID;
            textBoxLeague.Text = Properties.Settings.Default.League;
            textBoxAccountName.Text = Properties.Settings.Default.AccountName;
            textBoxTabIndex.Text = Properties.Settings.Default.TabIndex.ToString();
            textBoxMaxSets.Text = Properties.Settings.Default.MaxSets.ToString();
            textBoxFilterPath.Text = Properties.Settings.Default.FilterPath;
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.POESESSID = textBoxPoeSessId.Text;
            Properties.Settings.Default.League = textBoxLeague.Text;
            Properties.Settings.Default.AccountName = textBoxAccountName.Text;
            Properties.Settings.Default.TabIndex = int.Parse(textBoxTabIndex.Text);
            Properties.Settings.Default.MaxSets = int.Parse(textBoxMaxSets.Text);
            Properties.Settings.Default.FilterPath = textBoxFilterPath.Text;

            Properties.Settings.Default.Save();
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
    }
}
