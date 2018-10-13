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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wPMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highscoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnCroatian = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Position,
            this.dataGridViewTextBoxColumn2,
            this.cPMDataGridViewTextBoxColumn,
            this.wPMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.highscoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(335, 273);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Position
            // 
            this.Position.HeaderText = "";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nickname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nickname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cPMDataGridViewTextBoxColumn
            // 
            this.cPMDataGridViewTextBoxColumn.DataPropertyName = "CPM";
            this.cPMDataGridViewTextBoxColumn.HeaderText = "CPM";
            this.cPMDataGridViewTextBoxColumn.Name = "cPMDataGridViewTextBoxColumn";
            this.cPMDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPMDataGridViewTextBoxColumn.Width = 80;
            // 
            // wPMDataGridViewTextBoxColumn
            // 
            this.wPMDataGridViewTextBoxColumn.DataPropertyName = "WPM";
            this.wPMDataGridViewTextBoxColumn.HeaderText = "WPM";
            this.wPMDataGridViewTextBoxColumn.Name = "wPMDataGridViewTextBoxColumn";
            this.wPMDataGridViewTextBoxColumn.ReadOnly = true;
            this.wPMDataGridViewTextBoxColumn.Width = 80;
            // 
            // highscoreBindingSource
            // 
            this.highscoreBindingSource.DataSource = typeof(Typing_game.Highscore);
            // 
            // btnEnglish
            // 
            this.btnEnglish.Location = new System.Drawing.Point(191, 12);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(75, 23);
            this.btnEnglish.TabIndex = 4;
            this.btnEnglish.Text = "English";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnCroatian
            // 
            this.btnCroatian.Location = new System.Drawing.Point(272, 12);
            this.btnCroatian.Name = "btnCroatian";
            this.btnCroatian.Size = new System.Drawing.Size(75, 23);
            this.btnCroatian.TabIndex = 5;
            this.btnCroatian.Text = "Croatian";
            this.btnCroatian.UseVisualStyleBackColor = true;
            this.btnCroatian.Click += new System.EventHandler(this.btnCroatian_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(12, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // frmHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 334);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnCroatian);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHighscore";
            this.Text = "frmHighscore";
            this.Load += new System.EventHandler(this.frmHighscore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource highscoreBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wPMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnCroatian;
        private System.Windows.Forms.Button btnAll;
    }
}