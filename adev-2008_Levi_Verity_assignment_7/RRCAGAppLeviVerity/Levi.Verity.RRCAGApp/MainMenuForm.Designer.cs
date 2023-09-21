namespace Levi.Verity.RRCAGApp
{
    partial class MainMenuForm
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
            this.mnuStripMain = new System.Windows.Forms.MenuStrip();
            this.nmuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuSalesQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuCarWash = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuData = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.nmuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStripMain
            // 
            this.mnuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuFile,
            this.nmuData,
            this.nmuHelp});
            this.mnuStripMain.Location = new System.Drawing.Point(0, 0);
            this.mnuStripMain.Name = "mnuStripMain";
            this.mnuStripMain.Size = new System.Drawing.Size(800, 28);
            this.mnuStripMain.TabIndex = 0;
            this.mnuStripMain.Text = "menuStrip1";
            this.mnuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuStripMain_ItemClicked);
            // 
            // nmuFile
            // 
            this.nmuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuOpen,
            this.nmuExit});
            this.nmuFile.Name = "nmuFile";
            this.nmuFile.Size = new System.Drawing.Size(46, 24);
            this.nmuFile.Text = "&File";
            this.nmuFile.Click += new System.EventHandler(this.nmuFile_Click);
            // 
            // nmuOpen
            // 
            this.nmuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuSalesQuote,
            this.nmuCarWash});
            this.nmuOpen.Name = "nmuOpen";
            this.nmuOpen.Size = new System.Drawing.Size(224, 26);
            this.nmuOpen.Text = "&Open";
            this.nmuOpen.Click += new System.EventHandler(this.nmuOpen_Click);
            // 
            // nmuSalesQuote
            // 
            this.nmuSalesQuote.Name = "nmuSalesQuote";
            this.nmuSalesQuote.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.nmuSalesQuote.Size = new System.Drawing.Size(225, 26);
            this.nmuSalesQuote.Text = "&Sales Quote ";
            // 
            // nmuCarWash
            // 
            this.nmuCarWash.Name = "nmuCarWash";
            this.nmuCarWash.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.nmuCarWash.Size = new System.Drawing.Size(225, 26);
            this.nmuCarWash.Text = "&Car Wash";
            // 
            // nmuExit
            // 
            this.nmuExit.Name = "nmuExit";
            this.nmuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.nmuExit.Size = new System.Drawing.Size(224, 26);
            this.nmuExit.Text = "&Exit";
            // 
            // nmuData
            // 
            this.nmuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuVehicle});
            this.nmuData.Name = "nmuData";
            this.nmuData.Size = new System.Drawing.Size(55, 26);
            this.nmuData.Text = "&Data";
            this.nmuData.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // nmuVehicle
            // 
            this.nmuVehicle.Name = "nmuVehicle";
            this.nmuVehicle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.nmuVehicle.Size = new System.Drawing.Size(224, 26);
            this.nmuVehicle.Text = "&Vehicle";
            // 
            // nmuHelp
            // 
            this.nmuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmuAbout});
            this.nmuHelp.Name = "nmuHelp";
            this.nmuHelp.Size = new System.Drawing.Size(55, 26);
            this.nmuHelp.Text = "&Help";
            // 
            // nmuAbout
            // 
            this.nmuAbout.Name = "nmuAbout";
            this.nmuAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.nmuAbout.Size = new System.Drawing.Size(224, 26);
            this.nmuAbout.Text = "&About...";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 93);
            this.Controls.Add(this.mnuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuStripMain;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "RRC Automotive Group";
            this.mnuStripMain.ResumeLayout(false);
            this.mnuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStripMain;
        private System.Windows.Forms.ToolStripMenuItem nmuFile;
        private System.Windows.Forms.ToolStripMenuItem nmuData;
        private System.Windows.Forms.ToolStripMenuItem nmuHelp;
        private System.Windows.Forms.ToolStripMenuItem nmuExit;
        private System.Windows.Forms.ToolStripMenuItem nmuVehicle;
        private System.Windows.Forms.ToolStripMenuItem nmuAbout;
        private System.Windows.Forms.ToolStripMenuItem nmuOpen;
        private System.Windows.Forms.ToolStripMenuItem nmuSalesQuote;
        private System.Windows.Forms.ToolStripMenuItem nmuCarWash;
    }
}

