namespace Typing_game
{
    partial class ScoreInput
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbNickname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCPM = new System.Windows.Forms.Label();
            this.lbWPM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(59, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Location = new System.Drawing.Point(47, 21);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(87, 13);
            this.lbNickname.TabIndex = 2;
            this.lbNickname.Text = "Enter your name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "WPM:";
            // 
            // lbCPM
            // 
            this.lbCPM.AutoSize = true;
            this.lbCPM.Location = new System.Drawing.Point(55, 64);
            this.lbCPM.Name = "lbCPM";
            this.lbCPM.Size = new System.Drawing.Size(13, 13);
            this.lbCPM.TabIndex = 5;
            this.lbCPM.Text = "0";
            // 
            // lbWPM
            // 
            this.lbWPM.AutoSize = true;
            this.lbWPM.Location = new System.Drawing.Point(55, 84);
            this.lbWPM.Name = "lbWPM";
            this.lbWPM.Size = new System.Drawing.Size(13, 13);
            this.lbWPM.TabIndex = 6;
            this.lbWPM.Text = "0";
            // 
            // ScoreInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 148);
            this.Controls.Add(this.lbWPM);
            this.Controls.Add(this.lbCPM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNickname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Name = "ScoreInput";
            this.Text = "ScoreInput";
            this.Load += new System.EventHandler(this.ScoreInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbNickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCPM;
        private System.Windows.Forms.Label lbWPM;
    }
}