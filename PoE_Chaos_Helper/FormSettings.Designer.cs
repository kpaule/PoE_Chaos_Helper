
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
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxPoeSessId
            // 
            this.textBoxPoeSessId.Location = new System.Drawing.Point(99, 12);
            this.textBoxPoeSessId.Name = "textBoxPoeSessId";
            this.textBoxPoeSessId.Size = new System.Drawing.Size(173, 20);
            this.textBoxPoeSessId.TabIndex = 2;
            // 
            // labelPoeSessId
            // 
            this.labelPoeSessId.AutoSize = true;
            this.labelPoeSessId.Location = new System.Drawing.Point(12, 15);
            this.labelPoeSessId.Name = "labelPoeSessId";
            this.labelPoeSessId.Size = new System.Drawing.Size(71, 13);
            this.labelPoeSessId.TabIndex = 3;
            this.labelPoeSessId.Text = "POESESSID:";
            // 
            // labelLeague
            // 
            this.labelLeague.AutoSize = true;
            this.labelLeague.Location = new System.Drawing.Point(12, 41);
            this.labelLeague.Name = "labelLeague";
            this.labelLeague.Size = new System.Drawing.Size(46, 13);
            this.labelLeague.TabIndex = 5;
            this.labelLeague.Text = "League:";
            // 
            // textBoxLeague
            // 
            this.textBoxLeague.Location = new System.Drawing.Point(99, 38);
            this.textBoxLeague.Name = "textBoxLeague";
            this.textBoxLeague.Size = new System.Drawing.Size(173, 20);
            this.textBoxLeague.TabIndex = 4;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(12, 67);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(81, 13);
            this.labelAccountName.TabIndex = 7;
            this.labelAccountName.Text = "Account Name:";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(99, 64);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(173, 20);
            this.textBoxAccountName.TabIndex = 6;
            // 
            // labelTabIndex
            // 
            this.labelTabIndex.AutoSize = true;
            this.labelTabIndex.Location = new System.Drawing.Point(12, 93);
            this.labelTabIndex.Name = "labelTabIndex";
            this.labelTabIndex.Size = new System.Drawing.Size(58, 13);
            this.labelTabIndex.TabIndex = 9;
            this.labelTabIndex.Text = "Tab Index:";
            // 
            // textBoxTabIndex
            // 
            this.textBoxTabIndex.Location = new System.Drawing.Point(99, 90);
            this.textBoxTabIndex.Name = "textBoxTabIndex";
            this.textBoxTabIndex.Size = new System.Drawing.Size(173, 20);
            this.textBoxTabIndex.TabIndex = 8;
            // 
            // labelMaxSets
            // 
            this.labelMaxSets.AutoSize = true;
            this.labelMaxSets.Location = new System.Drawing.Point(12, 119);
            this.labelMaxSets.Name = "labelMaxSets";
            this.labelMaxSets.Size = new System.Drawing.Size(54, 13);
            this.labelMaxSets.TabIndex = 11;
            this.labelMaxSets.Text = "Max Sets:";
            // 
            // textBoxMaxSets
            // 
            this.textBoxMaxSets.Location = new System.Drawing.Point(99, 116);
            this.textBoxMaxSets.Name = "textBoxMaxSets";
            this.textBoxMaxSets.Size = new System.Drawing.Size(173, 20);
            this.textBoxMaxSets.TabIndex = 10;
            // 
            // labelFilterPath
            // 
            this.labelFilterPath.AutoSize = true;
            this.labelFilterPath.Location = new System.Drawing.Point(12, 145);
            this.labelFilterPath.Name = "labelFilterPath";
            this.labelFilterPath.Size = new System.Drawing.Size(56, 13);
            this.labelFilterPath.TabIndex = 13;
            this.labelFilterPath.Text = "Filter path:";
            // 
            // textBoxFilterPath
            // 
            this.textBoxFilterPath.Location = new System.Drawing.Point(99, 142);
            this.textBoxFilterPath.Name = "textBoxFilterPath";
            this.textBoxFilterPath.Size = new System.Drawing.Size(173, 20);
            this.textBoxFilterPath.TabIndex = 12;
            this.textBoxFilterPath.Click += new System.EventHandler(this.textBoxFilterPath_Click);
            // 
            // FormSettings
            // 
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.labelFilterPath);
            this.Controls.Add(this.textBoxFilterPath);
            this.Controls.Add(this.labelMaxSets);
            this.Controls.Add(this.textBoxMaxSets);
            this.Controls.Add(this.labelTabIndex);
            this.Controls.Add(this.textBoxTabIndex);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.textBoxAccountName);
            this.Controls.Add(this.labelLeague);
            this.Controls.Add(this.textBoxLeague);
            this.Controls.Add(this.labelPoeSessId);
            this.Controls.Add(this.textBoxPoeSessId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}