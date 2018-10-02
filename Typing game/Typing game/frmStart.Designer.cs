namespace Typing_game
{
    partial class frmStart
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
            this.txtWords = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbSeconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.lbWords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCharacters = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(49, 34);
            this.txtWords.Name = "txtWords";
            this.txtWords.ReadOnly = true;
            this.txtWords.Size = new System.Drawing.Size(143, 20);
            this.txtWords.TabIndex = 2;
            this.txtWords.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWords_KeyUp);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSeconds.Location = new System.Drawing.Point(266, 20);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(80, 37);
            this.lbSeconds.TabIndex = 4;
            this.lbSeconds.Text = "00.0";
            this.lbSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time:";
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(49, 82);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(100, 20);
            this.txtWrite.TabIndex = 0;
            this.txtWrite.TextChanged += new System.EventHandler(this.txtWrite_TextChanged);
            this.txtWrite.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtWrite_KeyUp);
            // 
            // lbWords
            // 
            this.lbWords.AutoSize = true;
            this.lbWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbWords.Location = new System.Drawing.Point(266, 67);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(35, 37);
            this.lbWords.TabIndex = 8;
            this.lbWords.Text = "0";
            this.lbWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Words:";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(263, 179);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Characters:";
            // 
            // lbCharacters
            // 
            this.lbCharacters.AutoSize = true;
            this.lbCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCharacters.Location = new System.Drawing.Point(266, 114);
            this.lbCharacters.Name = "lbCharacters";
            this.lbCharacters.Size = new System.Drawing.Size(35, 37);
            this.lbCharacters.TabIndex = 12;
            this.lbCharacters.Text = "0";
            this.lbCharacters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 321);
            this.Controls.Add(this.lbCharacters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSeconds);
            this.Controls.Add(this.txtWords);
            this.Name = "frmStart";
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.frmStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.Label lbWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCharacters;
    }
}