
namespace PoE_Chaos_Helper
{
    partial class FormSettings
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxPoeSessId = new System.Windows.Forms.TextBox();
            this.labelPoeSessId = new System.Windows.Forms.Label();
            this.labelLeague = new System.Windows.Forms.Label();
            this.textBoxLeague = new System.Windows.Forms.TextBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.labelTabIndex = new System.Windows.Forms.Label();
            this.textBoxTabIndex = new System.Windows.Forms.TextBox();
            this.labelMaxSets = new System.Windows.Forms.Label();
            this.textBoxMaxSets = new System.Windows.Forms.TextBox();
            this.labelFilterPath = new System.Windows.Forms.Label();
            this.textBoxFilterPath = new System.Windows.Forms.TextBox();
            this.labelOverlayLocation = new System.Windows.Forms.Label();
            this.textBoxOverlayLocation = new System.Windows.Forms.TextBox();
            this.labelOverlaySize = new System.Windows.Forms.Label();
            this.textBoxOverlaySize = new System.Windows.Forms.TextBox();
            this.groupBoxOverlay = new System.Windows.Forms.GroupBox();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.groupBoxChaosRecipe = new System.Windows.Forms.GroupBox();
            this.groupBoxOverlay.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxChaosRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxPoeSessId
            // 
            this.textBoxPoeSessId.Location = new System.Drawing.Point(93, 13);
            this.textBoxPoeSessId.Name = "textBoxPoeSessId";
            this.textBoxPoeSessId.Size = new System.Drawing.Size(173, 20);
            this.textBoxPoeSessId.TabIndex = 2;
            // 
            // labelPoeSessId
            // 
            this.labelPoeSessId.AutoSize = true;
            this.labelPoeSessId.Location = new System.Drawing.Point(6, 16);
            this.labelPoeSessId.Name = "labelPoeSessId";
            this.labelPoeSessId.Size = new System.Drawing.Size(71, 13);
            this.labelPoeSessId.TabIndex = 3;
            this.labelPoeSessId.Text = "POESESSID:";
            // 
            // labelLeague
            // 
            this.labelLeague.AutoSize = true;
            this.labelLeague.Location = new System.Drawing.Point(6, 42);
            this.labelLeague.Name = "labelLeague";
            this.labelLeague.Size = new System.Drawing.Size(46, 13);
            this.labelLeague.TabIndex = 5;
            this.labelLeague.Text = "League:";
            // 
            // textBoxLeague
            // 
            this.textBoxLeague.Location = new System.Drawing.Point(93, 39);
            this.textBoxLeague.Name = "textBoxLeague";
            this.textBoxLeague.Size = new System.Drawing.Size(173, 20);
            this.textBoxLeague.TabIndex = 4;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(6, 68);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(81, 13);
            this.labelAccountName.TabIndex = 7;
            this.labelAccountName.Text = "Account Name:";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(93, 65);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(173, 20);
            this.textBoxAccountName.TabIndex = 6;
            // 
            // labelTabIndex
            // 
            this.labelTabIndex.AutoSize = true;
            this.labelTabIndex.Location = new System.Drawing.Point(6, 16);
            this.labelTabIndex.Name = "labelTabIndex";
            this.labelTabIndex.Size = new System.Drawing.Size(58, 13);
            this.labelTabIndex.TabIndex = 9;
            this.labelTabIndex.Text = "Tab Index:";
            // 
            // textBoxTabIndex
            // 
            this.textBoxTabIndex.Location = new System.Drawing.Point(93, 13);
            this.textBoxTabIndex.Name = "textBoxTabIndex";
            this.textBoxTabIndex.Size = new System.Drawing.Size(173, 20);
            this.textBoxTabIndex.TabIndex = 8;
            // 
            // labelMaxSets
            // 
            this.labelMaxSets.AutoSize = true;
            this.labelMaxSets.Location = new System.Drawing.Point(6, 42);
            this.labelMaxSets.Name = "labelMaxSets";
            this.labelMaxSets.Size = new System.Drawing.Size(54, 13);
            this.labelMaxSets.TabIndex = 11;
            this.labelMaxSets.Text = "Max Sets:";
            // 
            // textBoxMaxSets
            // 
            this.textBoxMaxSets.Location = new System.Drawing.Point(93, 39);
            this.textBoxMaxSets.Name = "textBoxMaxSets";
            this.textBoxMaxSets.Size = new System.Drawing.Size(173, 20);
            this.textBoxMaxSets.TabIndex = 10;
            // 
            // labelFilterPath
            // 
            this.labelFilterPath.AutoSize = true;
            this.labelFilterPath.Location = new System.Drawing.Point(6, 68);
            this.labelFilterPath.Name = "labelFilterPath";
            this.labelFilterPath.Size = new System.Drawing.Size(56, 13);
            this.labelFilterPath.TabIndex = 13;
            this.labelFilterPath.Text = "Filter path:";
            // 
            // textBoxFilterPath
            // 
            this.textBoxFilterPath.Location = new System.Drawing.Point(93, 65);
            this.textBoxFilterPath.Name = "textBoxFilterPath";
            this.textBoxFilterPath.Size = new System.Drawing.Size(173, 20);
            this.textBoxFilterPath.TabIndex = 12;
            this.textBoxFilterPath.Click += new System.EventHandler(this.textBoxFilterPath_Click);
            // 
            // labelOverlayLocation
            // 
            this.labelOverlayLocation.AutoSize = true;
            this.labelOverlayLocation.Location = new System.Drawing.Point(6, 16);
            this.labelOverlayLocation.Name = "labelOverlayLocation";
            this.labelOverlayLocation.Size = new System.Drawing.Size(51, 13);
            this.labelOverlayLocation.TabIndex = 15;
            this.labelOverlayLocation.Text = "Location:";
            // 
            // textBoxOverlayLocation
            // 
            this.textBoxOverlayLocation.Location = new System.Drawing.Point(93, 13);
            this.textBoxOverlayLocation.Name = "textBoxOverlayLocation";
            this.textBoxOverlayLocation.Size = new System.Drawing.Size(173, 20);
            this.textBoxOverlayLocation.TabIndex = 14;
            // 
            // labelOverlaySize
            // 
            this.labelOverlaySize.AutoSize = true;
            this.labelOverlaySize.Location = new System.Drawing.Point(6, 42);
            this.labelOverlaySize.Name = "labelOverlaySize";
            this.labelOverlaySize.Size = new System.Drawing.Size(30, 13);
            this.labelOverlaySize.TabIndex = 17;
            this.labelOverlaySize.Text = "Size:";
            // 
            // textBoxOverlaySize
            // 
            this.textBoxOverlaySize.Location = new System.Drawing.Point(93, 39);
            this.textBoxOverlaySize.Name = "textBoxOverlaySize";
            this.textBoxOverlaySize.Size = new System.Drawing.Size(173, 20);
            this.textBoxOverlaySize.TabIndex = 16;
            // 
            // groupBoxOverlay
            // 
            this.groupBoxOverlay.Controls.Add(this.labelOverlayLocation);
            this.groupBoxOverlay.Controls.Add(this.labelOverlaySize);
            this.groupBoxOverlay.Controls.Add(this.textBoxOverlayLocation);
            this.groupBoxOverlay.Controls.Add(this.textBoxOverlaySize);
            this.groupBoxOverlay.Location = new System.Drawing.Point(12, 216);
            this.groupBoxOverlay.Name = "groupBoxOverlay";
            this.groupBoxOverlay.Size = new System.Drawing.Size(276, 67);
            this.groupBoxOverlay.TabIndex = 18;
            this.groupBoxOverlay.TabStop = false;
            this.groupBoxOverlay.Text = "Overlay";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.labelPoeSessId);
            this.groupBoxUser.Controls.Add(this.textBoxPoeSessId);
            this.groupBoxUser.Controls.Add(this.textBoxLeague);
            this.groupBoxUser.Controls.Add(this.labelLeague);
            this.groupBoxUser.Controls.Add(this.textBoxAccountName);
            this.groupBoxUser.Controls.Add(this.labelAccountName);
            this.groupBoxUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(276, 94);
            this.groupBoxUser.TabIndex = 19;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // groupBoxChaosRecipe
            // 
            this.groupBoxChaosRecipe.Controls.Add(this.textBoxTabIndex);
            this.groupBoxChaosRecipe.Controls.Add(this.labelTabIndex);
            this.groupBoxChaosRecipe.Controls.Add(this.textBoxMaxSets);
            this.groupBoxChaosRecipe.Controls.Add(this.labelMaxSets);
            this.groupBoxChaosRecipe.Controls.Add(this.labelFilterPath);
            this.groupBoxChaosRecipe.Controls.Add(this.textBoxFilterPath);
            this.groupBoxChaosRecipe.Location = new System.Drawing.Point(12, 112);
            this.groupBoxChaosRecipe.Name = "groupBoxChaosRecipe";
            this.groupBoxChaosRecipe.Size = new System.Drawing.Size(276, 98);
            this.groupBoxChaosRecipe.TabIndex = 20;
            this.groupBoxChaosRecipe.TabStop = false;
            this.groupBoxChaosRecipe.Text = "Chaos recipe";
            // 
            // FormSettings
            // 
            this.ClientSize = new System.Drawing.Size(298, 291);
            this.Controls.Add(this.groupBoxChaosRecipe);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupBoxOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxOverlay.ResumeLayout(false);
            this.groupBoxOverlay.PerformLayout();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxChaosRecipe.ResumeLayout(false);
            this.groupBoxChaosRecipe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxPoeSessId;
        private System.Windows.Forms.Label labelPoeSessId;
        private System.Windows.Forms.Label labelLeague;
        private System.Windows.Forms.TextBox textBoxLeague;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.Label labelTabIndex;
        private System.Windows.Forms.TextBox textBoxTabIndex;
        private System.Windows.Forms.Label labelMaxSets;
        private System.Windows.Forms.TextBox textBoxMaxSets;
        private System.Windows.Forms.Label labelFilterPath;
        private System.Windows.Forms.TextBox textBoxFilterPath;
        private System.Windows.Forms.Label labelOverlayLocation;
        private System.Windows.Forms.TextBox textBoxOverlayLocation;
        private System.Windows.Forms.Label labelOverlaySize;
        private System.Windows.Forms.TextBox textBoxOverlaySize;
        private System.Windows.Forms.GroupBox groupBoxOverlay;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.GroupBox groupBoxChaosRecipe;
    }
}