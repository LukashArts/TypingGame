namespace Typing_game
{
    partial class frmHELP
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.msMain = new System.Windows.Forms.ToolStripMenuItem();
            this.msStart = new System.Windows.Forms.ToolStripMenuItem();
            this.msPractice = new System.Windows.Forms.ToolStripMenuItem();
            this.msHighscore = new System.Windows.Forms.ToolStripMenuItem();
            this.msLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.msAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msMain,
            this.msStart,
            this.msPractice,
            this.msHighscore,
            this.msLanguage,
            this.msAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(450, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // msMain
            // 
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(46, 20);
            this.msMain.Text = "Main";
            this.msMain.Click += new System.EventHandler(this.msMain_Click);
            // 
            // msStart
            // 
            this.msStart.Name = "msStart";
            this.msStart.Size = new System.Drawing.Size(43, 20);
            this.msStart.Text = "Start";
            this.msStart.Click += new System.EventHandler(this.msStart_Click);
            // 
            // msPractice
            // 
            this.msPractice.Name = "msPractice";
            this.msPractice.Size = new System.Drawing.Size(61, 20);
            this.msPractice.Text = "Practice";
            this.msPractice.Click += new System.EventHandler(this.msPractice_Click);
            // 
            // msHighscore
            // 
            this.msHighscore.Name = "msHighscore";
            this.msHighscore.Size = new System.Drawing.Size(73, 20);
            this.msHighscore.Text = "Highscore";
            this.msHighscore.Click += new System.EventHandler(this.msHighscore_Click);
            // 
            // msLanguage
            // 
            this.msLanguage.Name = "msLanguage";
            this.msLanguage.Size = new System.Drawing.Size(71, 20);
            this.msLanguage.Text = "Language";
            this.msLanguage.Click += new System.EventHandler(this.msLanguage_Click);
            // 
            // msAbout
            // 
            this.msAbout.Name = "msAbout";
            this.msAbout.Size = new System.Drawing.Size(52, 20);
            this.msAbout.Text = "About";
            this.msAbout.Click += new System.EventHandler(this.msAbout_Click);
            // 
            // frmHELP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 297);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmHELP";
            this.Text = "frmHELP";
            this.Load += new System.EventHandler(this.frmHELP_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem msMain;
        private System.Windows.Forms.ToolStripMenuItem msStart;
        private System.Windows.Forms.ToolStripMenuItem msPractice;
        private System.Windows.Forms.ToolStripMenuItem msLanguage;
        private System.Windows.Forms.ToolStripMenuItem msHighscore;
        private System.Windows.Forms.ToolStripMenuItem msAbout;
    }
}