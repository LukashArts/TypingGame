namespace Typing_game.HELP
{
    partial class frmHELPLanguage
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
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnCroatian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(26, 44);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(134, 31);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Language";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbText.Location = new System.Drawing.Point(29, 85);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(321, 96);
            this.lbText.TabIndex = 7;
            this.lbText.Text = "You can choose between two languages:\r\n\r\n     English and Croatian\r\n\r\nYou can cha" +
    "nge in Menu clicking on flag and you can\r\nchange it here!";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.Transparent;
            this.btnEnglish.BackgroundImage = global::Typing_game.Properties.Resources.Britain_flag;
            this.btnEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnglish.ForeColor = System.Drawing.Color.Transparent;
            this.btnEnglish.Location = new System.Drawing.Point(117, 204);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(41, 25);
            this.btnEnglish.TabIndex = 11;
            this.btnEnglish.UseVisualStyleBackColor = false;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnCroatian
            // 
            this.btnCroatian.BackColor = System.Drawing.Color.Transparent;
            this.btnCroatian.BackgroundImage = global::Typing_game.Properties.Resources.Croatian_flag;
            this.btnCroatian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCroatian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCroatian.ForeColor = System.Drawing.Color.Transparent;
            this.btnCroatian.Location = new System.Drawing.Point(164, 204);
            this.btnCroatian.Name = "btnCroatian";
            this.btnCroatian.Size = new System.Drawing.Size(41, 25);
            this.btnCroatian.TabIndex = 10;
            this.btnCroatian.UseVisualStyleBackColor = false;
            this.btnCroatian.Click += new System.EventHandler(this.btnCroatian_Click);
            // 
            // frmHELPLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 296);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnCroatian);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHELPLanguage";
            this.Text = "frmHELPLanguage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnCroatian;
    }
}