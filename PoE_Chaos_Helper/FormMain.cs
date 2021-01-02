using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoE_Chaos_Helper
{
    public partial class FormMain : Form
    {
        FormOverlay formOverlay;

        public FormMain()
        {
            InitializeComponent();
        }

        private async void updateTab()
        {
            var poessid = Properties.Settings.Default.POESESSID;
            var league = Properties.Settings.Default.League;
            var accountName = Properties.Settings.Default.AccountName;
            var tabIndex = Properties.Settings.Default.TabIndex;
            var filterPath = Properties.Settings.Default.FilterPath;
            var maxSets = Properties.Settings.Default.MaxSets;

            PoE.Stash stash = await getStashAsync(poessid, league, accountName, tabIndex);

            if(stash != null)
            {
                // count items eligible for the chaos recipe
                List<PoE.Item> eligible = getEligibleForRecipe(stash.items);

                string tabType = stash.tabs.ElementAt(tabIndex).type;
                if (formOverlay != null)
                    formOverlay.PaintItems(eligible, tabType);

                int countOneHandedWeapon = countType(eligible, "OneHandWeapons");
                int countHelmet = countType(eligible, "Helmets");
                int countBodyArmour = countType(eligible, "BodyArmours");
                int countGloves = countType(eligible, "Gloves");
                int countBoots = countType(eligible, "Boots");
                int countBelt = countType(eligible, "Belts");
                int countAmulet = countType(eligible, "Amulets");
                int countRing = countType(eligible, "Rings");

                // check whats missing
                List<string> missing = new List<string>();
                if(countOneHandedWeapon < maxSets)
                {
                    missing.Add("One Hand Swords");
                    missing.Add("Daggers");
                    missing.Add("Rune Dagger");

                }
                if (countHelmet < maxSets)
                    missing.Add("Helmets");
                if (countBodyArmour < maxSets)
                    missing.Add("Body Armour");
                if (countGloves < maxSets)
                    missing.Add("Gloves");
                if (countBoots < maxSets)
                    missing.Add("Boots");
                if (countBelt < maxSets)
                    missing.Add("Belt");
                if (countAmulet < maxSets)
                    missing.Add("Amulets");
                if (countRing < (maxSets * 2))
                    missing.Add("Rings");

                // do filter here
                Filter filter = new Filter();
                filter.Modify(filterPath, missing);

                // Update GUI
                textBoxTabName.Text = stash.tabs.ElementAt(tabIndex).n;
                textBoxOneHandedWeapon.Text = countOneHandedWeapon + " / " + maxSets;
                textBoxHelmet.Text = countHelmet + " / " + maxSets;
                textBoxBodyArmour.Text = countBodyArmour + " / " + maxSets;
                textBoxGloves.Text = countGloves + " / " + maxSets;
                textBoxBoots.Text = countBoots + " / " + maxSets;
                textBoxBelt.Text = countBelt + " / " + maxSets;
                textBoxAmulet.Text = countAmulet + " / " + maxSets;
                textBoxRing.Text = countRing + " / " + (maxSets * 2);

            }
            else
            {
                timer.Stop();
                buttonStart.Text = "Start";
                MessageBox.Show("Couldn't get stash from poe api. Are the settings correct? Is your POESESSID expired?", "Api Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Task<PoE.Stash> getStashAsync(string poessid, string league, string accountName, int tabIndex)
        {
            TaskCompletionSource<PoE.Stash> tcs = new TaskCompletionSource<PoE.Stash>();
            Task.Run(() =>
            {
                PoeApi poeapi = new PoeApi(poessid, league, accountName);
                var result = poeapi.GetStashItems(tabIndex);
                tcs.SetResult(result);
            });

            return tcs.Task;
        }

        private int countType(List<PoE.Item> items, string type)
        {
            int count = 0;

            foreach (var item in items)
            {
                // this is not nice
                if (item.icon.Contains(type))
                {
                    count++;
                }

            }

            return count;
        }

        private List<PoE.Item> getEligibleForRecipe(List<PoE.Item> items)
        {
            List<PoE.Item> eligible = new List<PoE.Item>();

            foreach (var item in items)
            {

                if (item.identified == false && item.ilvl >= 60 && item.ilvl <= 74)
                {
                    eligible.Add(item);
                }

            }

            return eligible;
        }

        private void overlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formOverlay == null)
            {
                formOverlay = new FormOverlay();
                formOverlay.Show();
                updateTab();
            }
            else
            {
                formOverlay.Close();
                formOverlay = null;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            updateTab();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(buttonStart.Text == "Start")
            {
                updateTab();
                timer.Start();
                buttonStart.Text = "Stop";
            }
            else
            {
                buttonStart.Text = "Start";
                timer.Stop();
            }
        }

        private void aboutChaosHelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }
    }
}
