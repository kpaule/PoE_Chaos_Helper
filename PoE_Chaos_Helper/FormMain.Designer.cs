
namespace PoE_Chaos_Helper
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxTabName = new System.Windows.Forms.TextBox();
            this.labelTabName = new System.Windows.Forms.Label();
            this.labelOneHandedWeapon = new System.Windows.Forms.Label();
            this.textBoxOneHandedWeapon = new System.Windows.Forms.TextBox();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.labelRing = new System.Windows.Forms.Label();
            this.textBoxRing = new System.Windows.Forms.TextBox();
            this.labelBelt = new System.Windows.Forms.Label();
            this.textBoxBelt = new System.Windows.Forms.TextBox();
            this.labelAmulet = new System.Windows.Forms.Label();
            this.textBoxAmulet = new System.Windows.Forms.TextBox();
            this.labelBoots = new System.Windows.Forms.Label();
            this.textBoxBoots = new System.Windows.Forms.TextBox();
            this.labelGloves = new System.Windows.Forms.Label();
            this.textBoxGloves = new System.Windows.Forms.TextBox();
            this.labelBodyArmour = new System.Windows.Forms.Label();
            this.textBoxBodyArmour = new System.Windows.Forms.TextBox();
            this.labelHelmet = new System.Windows.Forms.Label();
            this.textBoxHelmet = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.overlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutChaosHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxItems.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonStart.Location = new System.Drawing.Point(0, 288);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(294, 40);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxTabName
            // 
            this.textBoxTabName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTabName.Location = new System.Drawing.Point(78, 27);
            this.textBoxTabName.Name = "textBoxTabName";
            this.textBoxTabName.ReadOnly = true;
            this.textBoxTabName.Size = new System.Drawing.Size(204, 20);
            this.textBoxTabName.TabIndex = 4;
            // 
            // labelTabName
            // 
            this.labelTabName.AutoSize = true;
            this.labelTabName.Location = new System.Drawing.Point(12, 30);
            this.labelTabName.Name = "labelTabName";
            this.labelTabName.Size = new System.Drawing.Size(60, 13);
            this.labelTabName.TabIndex = 5;
            this.labelTabName.Text = "Tab Name:";
            // 
            // labelOneHandedWeapon
            // 
            this.labelOneHandedWeapon.AutoSize = true;
            this.labelOneHandedWeapon.Location = new System.Drawing.Point(6, 22);
            this.labelOneHandedWeapon.Name = "labelOneHandedWeapon";
            this.labelOneHandedWeapon.Size = new System.Drawing.Size(115, 13);
            this.labelOneHandedWeapon.TabIndex = 7;
            this.labelOneHandedWeapon.Text = "One-Handed Weapon:";
            // 
            // textBoxOneHandedWeapon
            // 
            this.textBoxOneHandedWeapon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOneHandedWeapon.Location = new System.Drawing.Point(127, 19);
            this.textBoxOneHandedWeapon.Name = "textBoxOneHandedWeapon";
            this.textBoxOneHandedWeapon.ReadOnly = true;
            this.textBoxOneHandedWeapon.Size = new System.Drawing.Size(137, 20);
            this.textBoxOneHandedWeapon.TabIndex = 6;
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxItems.Controls.Add(this.labelRing);
            this.groupBoxItems.Controls.Add(this.textBoxRing);
            this.groupBoxItems.Controls.Add(this.labelBelt);
            this.groupBoxItems.Controls.Add(this.textBoxBelt);
            this.groupBoxItems.Controls.Add(this.labelAmulet);
            this.groupBoxItems.Controls.Add(this.textBoxAmulet);
            this.groupBoxItems.Controls.Add(this.labelBoots);
            this.groupBoxItems.Controls.Add(this.textBoxBoots);
            this.groupBoxItems.Controls.Add(this.labelGloves);
            this.groupBoxItems.Controls.Add(this.textBoxGloves);
            this.groupBoxItems.Controls.Add(this.labelBodyArmour);
            this.groupBoxItems.Controls.Add(this.textBoxBodyArmour);
            this.groupBoxItems.Controls.Add(this.labelHelmet);
            this.groupBoxItems.Controls.Add(this.textBoxHelmet);
            this.groupBoxItems.Controls.Add(this.labelOneHandedWeapon);
            this.groupBoxItems.Controls.Add(this.textBoxOneHandedWeapon);
            this.groupBoxItems.Location = new System.Drawing.Point(12, 53);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(270, 229);
            this.groupBoxItems.TabIndex = 8;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
            // 
            // labelRing
            // 
            this.labelRing.AutoSize = true;
            this.labelRing.Location = new System.Drawing.Point(6, 204);
            this.labelRing.Name = "labelRing";
            this.labelRing.Size = new System.Drawing.Size(32, 13);
            this.labelRing.TabIndex = 21;
            this.labelRing.Text = "Ring:";
            // 
            // textBoxRing
            // 
            this.textBoxRing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRing.Location = new System.Drawing.Point(127, 201);
            this.textBoxRing.Name = "textBoxRing";
            this.textBoxRing.ReadOnly = true;
            this.textBoxRing.Size = new System.Drawing.Size(137, 20);
            this.textBoxRing.TabIndex = 20;
            // 
            // labelBelt
            // 
            this.labelBelt.AutoSize = true;
            this.labelBelt.Location = new System.Drawing.Point(6, 152);
            this.labelBelt.Name = "labelBelt";
            this.labelBelt.Size = new System.Drawing.Size(28, 13);
            this.labelBelt.TabIndex = 19;
            this.labelBelt.Text = "Belt:";
            // 
            // textBoxBelt
            // 
            this.textBoxBelt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBelt.Location = new System.Drawing.Point(127, 149);
            this.textBoxBelt.Name = "textBoxBelt";
            this.textBoxBelt.ReadOnly = true;
            this.textBoxBelt.Size = new System.Drawing.Size(137, 20);
            this.textBoxBelt.TabIndex = 18;
            // 
            // labelAmulet
            // 
            this.labelAmulet.AutoSize = true;
            this.labelAmulet.Location = new System.Drawing.Point(6, 178);
            this.labelAmulet.Name = "labelAmulet";
            this.labelAmulet.Size = new System.Drawing.Size(42, 13);
            this.labelAmulet.TabIndex = 17;
            this.labelAmulet.Text = "Amulet:";
            // 
            // textBoxAmulet
            // 
            this.textBoxAmulet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAmulet.Location = new System.Drawing.Point(127, 175);
            this.textBoxAmulet.Name = "textBoxAmulet";
            this.textBoxAmulet.ReadOnly = true;
            this.textBoxAmulet.Size = new System.Drawing.Size(137, 20);
            this.textBoxAmulet.TabIndex = 16;
            // 
            // labelBoots
            // 
            this.labelBoots.AutoSize = true;
            this.labelBoots.Location = new System.Drawing.Point(6, 126);
            this.labelBoots.Name = "labelBoots";
            this.labelBoots.Size = new System.Drawing.Size(37, 13);
            this.labelBoots.TabIndex = 15;
            this.labelBoots.Text = "Boots:";
            // 
            // textBoxBoots
            // 
            this.textBoxBoots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBoots.Location = new System.Drawing.Point(127, 123);
            this.textBoxBoots.Name = "textBoxBoots";
            this.textBoxBoots.ReadOnly = true;
            this.textBoxBoots.Size = new System.Drawing.Size(137, 20);
            this.textBoxBoots.TabIndex = 14;
            // 
            // labelGloves
            // 
            this.labelGloves.AutoSize = true;
            this.labelGloves.Location = new System.Drawing.Point(6, 100);
            this.labelGloves.Name = "labelGloves";
            this.labelGloves.Size = new System.Drawing.Size(43, 13);
            this.labelGloves.TabIndex = 13;
            this.labelGloves.Text = "Gloves:";
            // 
            // textBoxGloves
            // 
            this.textBoxGloves.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGloves.Location = new System.Drawing.Point(127, 97);
            this.textBoxGloves.Name = "textBoxGloves";
            this.textBoxGloves.ReadOnly = true;
            this.textBoxGloves.Size = new System.Drawing.Size(137, 20);
            this.textBoxGloves.TabIndex = 12;
            // 
            // labelBodyArmour
            // 
            this.labelBodyArmour.AutoSize = true;
            this.labelBodyArmour.Location = new System.Drawing.Point(6, 74);
            this.labelBodyArmour.Name = "labelBodyArmour";
            this.labelBodyArmour.Size = new System.Drawing.Size(70, 13);
            this.labelBodyArmour.TabIndex = 11;
            this.labelBodyArmour.Text = "Body Armour:";
            // 
            // textBoxBodyArmour
            // 
            this.textBoxBodyArmour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBodyArmour.Location = new System.Drawing.Point(127, 71);
            this.textBoxBodyArmour.Name = "textBoxBodyArmour";
            this.textBoxBodyArmour.ReadOnly = true;
            this.textBoxBodyArmour.Size = new System.Drawing.Size(137, 20);
            this.textBoxBodyArmour.TabIndex = 10;
            // 
            // labelHelmet
            // 
            this.labelHelmet.AutoSize = true;
            this.labelHelmet.Location = new System.Drawing.Point(6, 48);
            this.labelHelmet.Name = "labelHelmet";
            this.labelHelmet.Size = new System.Drawing.Size(43, 13);
            this.labelHelmet.TabIndex = 9;
            this.labelHelmet.Text = "Helmet:";
            // 
            // textBoxHelmet
            // 
            this.textBoxHelmet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHelmet.Location = new System.Drawing.Point(127, 45);
            this.textBoxHelmet.Name = "textBoxHelmet";
            this.textBoxHelmet.ReadOnly = true;
            this.textBoxHelmet.Size = new System.Drawing.Size(137, 20);
            this.textBoxHelmet.TabIndex = 8;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overlayToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(294, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip";
            // 
            // overlayToolStripMenuItem
            // 
            this.overlayToolStripMenuItem.Name = "overlayToolStripMenuItem";
            this.overlayToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.overlayToolStripMenuItem.Text = "Overlay";
            this.overlayToolStripMenuItem.Click += new System.EventHandler(this.overlayToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutChaosHelperToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // aboutChaosHelperToolStripMenuItem
            // 
            this.aboutChaosHelperToolStripMenuItem.Name = "aboutChaosHelperToolStripMenuItem";
            this.aboutChaosHelperToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aboutChaosHelperToolStripMenuItem.Text = "About Chaos Helper";
            this.aboutChaosHelperToolStripMenuItem.Click += new System.EventHandler(this.aboutChaosHelperToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 328);
            this.Controls.Add(this.groupBoxItems);
            this.Controls.Add(this.labelTabName);
            this.Controls.Add(this.textBoxTabName);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Chaos Helper";
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxItems.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxTabName;
        private System.Windows.Forms.Label labelTabName;
        private System.Windows.Forms.Label labelOneHandedWeapon;
        private System.Windows.Forms.TextBox textBoxOneHandedWeapon;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.Label labelBodyArmour;
        private System.Windows.Forms.TextBox textBoxBodyArmour;
        private System.Windows.Forms.Label labelHelmet;
        private System.Windows.Forms.TextBox textBoxHelmet;
        private System.Windows.Forms.Label labelRing;
        private System.Windows.Forms.TextBox textBoxRing;
        private System.Windows.Forms.Label labelBelt;
        private System.Windows.Forms.TextBox textBoxBelt;
        private System.Windows.Forms.Label labelAmulet;
        private System.Windows.Forms.TextBox textBoxAmulet;
        private System.Windows.Forms.Label labelBoots;
        private System.Windows.Forms.TextBox textBoxBoots;
        private System.Windows.Forms.Label labelGloves;
        private System.Windows.Forms.TextBox textBoxGloves;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutChaosHelperToolStripMenuItem;
    }
}

