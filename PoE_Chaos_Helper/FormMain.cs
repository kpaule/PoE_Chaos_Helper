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
        PoE.Stash stash;
        FormOverlay formOverlay;

        public FormMain()
        {
            InitializeComponent();
        }

        private async void updateTab()
        {
            // load the settings
            var poessid = Properties.Settings.Default.POESESSID;
            var league = Properties.Settings.Default.League;
            var accountName = Properties.Settings.Default.AccountName;
            var tabIndex = Properties.Settings.Default.TabIndex;
            var filterPath = Properties.Settings.Default.FilterPath;
            var maxSets = Properties.Settings.Default.MaxSets;

            // update from poe api
            stash = await getStashAsync(poessid, league, accountName, tabIndex); // returns null if failed

            if(stash != null)
            {
                // count items eligible for the chaos recipe
                List<PoE.Item> eligible = getEligibleForRecipe(stash.items);

                int countOneHandedWeapon = countType(eligible, PoE.ItemType.OneHandWeapons);
                int countHelmet = countType(eligible, PoE.ItemType.Helmets);
                int countBodyArmour = countType(eligible, PoE.ItemType.BodyArmours);
                int countGloves = countType(eligible, PoE.ItemType.Gloves);
                int countBoots = countType(eligible, PoE.ItemType.Boots);
                int countBelt = countType(eligible, PoE.ItemType.Belts);
                int countAmulet = countType(eligible, PoE.ItemType.Amulets);
                int countRing = countType(eligible, PoE.ItemType.Rings);

                // check whats missing so we can add it to poe item filter
                List<string> missing = new List<string>();
                if(countOneHandedWeapon < maxSets * 2) // we need 2 weapons
                {
                    missing.Add("One Hand Swords");
                    missing.Add("Daggers");
                    missing.Add("Rune Dagger");
                    missing.Add("Wands");
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
                if (countRing < (maxSets * 2)) // we need 2 rings
                    missing.Add("Rings");

                // do filter here
                Filter filter = new Filter();
                filter.Modify(filterPath, missing);

                // Update GUI
                textBoxTabName.Text = stash.tabs.ElementAt(tabIndex).n;
                textBoxOneHandedWeapon.Text = countOneHandedWeapon + " / " + maxSets * 2;
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

        private int countType(List<PoE.Item> items, PoE.ItemType itemType)
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.ItemType == itemType)
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
                if (item.identified == false && item.ilvl >= 60 && item.ilvl <= 74 && item.ItemType != PoE.ItemType.NotImplemented)
                {
                    eligible.Add(item);
                }
            }
            return eligible;
        }

        private void toggleOverlay()
        {
            // Overlay is not open -> create it
            if (formOverlay == null)
            {
                formOverlay = new FormOverlay();
                formOverlay.Show();

                if (stash != null)
                {
                    var tabIndex = Properties.Settings.Default.TabIndex;
                    // get items eligible for the chaos recipe
                    List<PoE.Item> eligible = getEligibleForRecipe(stash.items);

                    // what is the stash tab type?
                    string tabType = stash.tabs.ElementAt(tabIndex).type;

                    // tell Overlay Form to paint 'eligible' items in tab 'tabType'
                    formOverlay.PaintItems(eligible, tabType);
                }
                else
                {
                    MessageBox.Show("No data. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    formOverlay.Close();
                    formOverlay = null;
                }

            }
            // Overlay is open -> remove it
            else
            {
                formOverlay.Close();
                formOverlay = null;
            }
        }

        #region Events
        private void overlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleOverlay();
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Hotkey
            try
            {
                GlobalHotKey.RegisterHotKey(Properties.Settings.Default.OverlayHotkey, () => toggleOverlay());

            }
            catch
            {
                MessageBox.Show("Can't register hotkey. Are settings correct?", "Settings Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion


    }
}
