namespace Typing_game.HELP
{
    partial class frmHELPAbout
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.lnkMail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(26, 44);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(85, 31);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "About";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbText.Location = new System.Drawing.Point(29, 85);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(386, 64);
            this.lbText.TabIndex = 8;
            this.lbText.Text = "My name is Mihael Lukaš and I am developer of this application.\r\n\r\nIf you have an" +
    "y inquiries about this application or anything else\r\nyou can contact me through " +
    "mail.";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkMail
            // 
            this.lnkMail.AutoSize = true;
            this.lnkMail.Location = new System.Drawing.Point(29, 166);
            this.lnkMail.Name = "lnkMail";
            this.lnkMail.Size = new System.Drawing.Size(132, 13);
            this.lnkMail.TabIndex = 9;
            this.lnkMail.TabStop = true;
            this.lnkMail.Text = "mihael.lukas@hotmail.com";
            this.lnkMail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMail_LinkClicked);
            // 
            // frmHELPAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 296);
            this.ControlBox = false;
            this.Controls.Add(this.lnkMail);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHELPAbout";
            this.Text = "frmHELPAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.LinkLabel lnkMail;
    }
}