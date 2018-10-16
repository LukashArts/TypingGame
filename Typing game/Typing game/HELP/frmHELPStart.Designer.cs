namespace Typing_game.HELP
{
    partial class frmHELPStart
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
            this.lbText = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbText2 = new System.Windows.Forms.Label();
            this.lbText3 = new System.Windows.Forms.Label();
            this.lbText4 = new System.Windows.Forms.Label();
            this.lbTextWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbText.Location = new System.Drawing.Point(29, 85);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(299, 32);
            this.lbText.TabIndex = 4;
            this.lbText.Text = "Main functionality of this application is to calculate\r\nyour typing speed. Try to" +
    " type as fast as you can!";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(26, 44);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(400, 31);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Calculating your CPM and WPM";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbText2
            // 
            this.lbText2.AutoSize = true;
            this.lbText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbText2.Location = new System.Drawing.Point(87, 155);
            this.lbText2.Name = "lbText2";
            this.lbText2.Size = new System.Drawing.Size(50, 34);
            this.lbText2.TabIndex = 6;
            this.lbText2.Text = "CPM  -\r\nWPM -\r\n";
            // 
            // lbText3
            // 
            this.lbText3.AutoSize = true;
            this.lbText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbText3.Location = new System.Drawing.Point(134, 155);
            this.lbText3.Name = "lbText3";
            this.lbText3.Size = new System.Drawing.Size(148, 34);
            this.lbText3.TabIndex = 7;
            this.lbText3.Text = "Characters per minute\r\nWords per minute\r\n";
            // 
            // lbText4
            // 
            this.lbText4.AutoSize = true;
            this.lbText4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbText4.Location = new System.Drawing.Point(30, 202);
            this.lbText4.Name = "lbText4";
            this.lbText4.Size = new System.Drawing.Size(336, 32);
            this.lbText4.TabIndex = 8;
            this.lbText4.Text = "WPM are equal to CPM divided by 5 because average \r\nnumber of letters in a word i" +
    "s 5.";
            this.lbText4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTextWords
            // 
            this.lbTextWords.AutoSize = true;
            this.lbTextWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTextWords.Location = new System.Drawing.Point(30, 128);
            this.lbTextWords.Name = "lbTextWords";
            this.lbTextWords.Size = new System.Drawing.Size(177, 16);
            this.lbTextWords.TabIndex = 9;
            this.lbTextWords.Text = "Words are randomly picked!";
            // 
            // frmHELPStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 296);
            this.ControlBox = false;
            this.Controls.Add(this.lbTextWords);
            this.Controls.Add(this.lbText4);
            this.Controls.Add(this.lbText3);
            this.Controls.Add(this.lbText2);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHELPStart";
            this.Text = "frmHELPStart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbText2;
        private System.Windows.Forms.Label lbText3;
        private System.Windows.Forms.Label lbText4;
        private System.Windows.Forms.Label lbTextWords;
    }
}