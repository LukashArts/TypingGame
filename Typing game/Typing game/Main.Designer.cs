namespace Typing_game
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnCroatian = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find out your\r\ntyping speed!\r\n";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(77, 110);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 57);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHighscore
            // 
            this.btnHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHighscore.Location = new System.Drawing.Point(77, 236);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(142, 57);
            this.btnHighscore.TabIndex = 2;
            this.btnHighscore.Text = "Highscore";
            this.btnHighscore.UseVisualStyleBackColor = true;
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(77, 299);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPractice.Location = new System.Drawing.Point(77, 173);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(142, 57);
            this.btnPractice.TabIndex = 4;
            this.btnPractice.Text = "Practice";
            this.btnPractice.UseVisualStyleBackColor = true;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnCroatian
            // 
            this.btnCroatian.BackColor = System.Drawing.Color.Transparent;
            this.btnCroatian.BackgroundImage = global::Typing_game.Properties.Resources.Croatian_flag;
            this.btnCroatian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCroatian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCroatian.ForeColor = System.Drawing.Color.Transparent;
            this.btnCroatian.Location = new System.Drawing.Point(152, 79);
            this.btnCroatian.Name = "btnCroatian";
            this.btnCroatian.Size = new System.Drawing.Size(41, 25);
            this.btnCroatian.TabIndex = 8;
            this.btnCroatian.UseVisualStyleBackColor = false;
            this.btnCroatian.Click += new System.EventHandler(this.btnCroatian_Click);
            // 
            // btnEnglish
            // 
            this.btnEnglish.BackColor = System.Drawing.Color.Transparent;
            this.btnEnglish.BackgroundImage = global::Typing_game.Properties.Resources.Britain_flag;
            this.btnEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnglish.ForeColor = System.Drawing.Color.Transparent;
            this.btnEnglish.Location = new System.Drawing.Point(105, 79);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(41, 25);
            this.btnEnglish.TabIndex = 9;
            this.btnEnglish.UseVisualStyleBackColor = false;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 398);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighscore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCroatian);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHighscore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnCroatian;
        private System.Windows.Forms.Button btnEnglish;
    }
}

