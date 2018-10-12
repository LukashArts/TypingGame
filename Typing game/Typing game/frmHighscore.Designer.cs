namespace Typing_game
{
    partial class frmHighscore
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
            this.btnHighscore = new System.Windows.Forms.Button();
            this.txtHighscore = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.highscoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wPMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHighscore
            // 
            this.btnHighscore.Location = new System.Drawing.Point(276, 150);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(75, 23);
            this.btnHighscore.TabIndex = 0;
            this.btnHighscore.Text = "Highscore";
            this.btnHighscore.UseVisualStyleBackColor = true;
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click);
            // 
            // txtHighscore
            // 
            this.txtHighscore.Location = new System.Drawing.Point(276, 90);
            this.txtHighscore.Name = "txtHighscore";
            this.txtHighscore.Size = new System.Drawing.Size(100, 20);
            this.txtHighscore.TabIndex = 1;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(276, 116);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.cPMDataGridViewTextBoxColumn,
            this.wPMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.highscoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(99, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // highscoreBindingSource
            // 
            this.highscoreBindingSource.DataSource = typeof(Typing_game.Highscore);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nickname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cPMDataGridViewTextBoxColumn
            // 
            this.cPMDataGridViewTextBoxColumn.DataPropertyName = "CPM";
            this.cPMDataGridViewTextBoxColumn.HeaderText = "CPM";
            this.cPMDataGridViewTextBoxColumn.Name = "cPMDataGridViewTextBoxColumn";
            // 
            // wPMDataGridViewTextBoxColumn
            // 
            this.wPMDataGridViewTextBoxColumn.DataPropertyName = "WPM";
            this.wPMDataGridViewTextBoxColumn.HeaderText = "WPM";
            this.wPMDataGridViewTextBoxColumn.Name = "wPMDataGridViewTextBoxColumn";
            // 
            // frmHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtHighscore);
            this.Controls.Add(this.btnHighscore);
            this.Name = "frmHighscore";
            this.Text = "frmHighscore";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHighscore;
        private System.Windows.Forms.TextBox txtHighscore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wPMDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource highscoreBindingSource;
    }
}