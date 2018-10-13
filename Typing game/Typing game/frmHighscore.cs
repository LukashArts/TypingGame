using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_game
{
    public partial class frmHighscore : Form
    {
        public frmHighscore()
        {
            InitializeComponent();
        }

        private bool Hrv { get; set; }

        /// <summary>
        /// Konstruktor koji se izvršava ako je odabran hrvatski jezik.
        /// </summary>
        /// <param name="hrvatski">Odabrani jezik.</param>
        public frmHighscore(bool hrvatski)
        {
            Hrv = hrvatski;

            InitializeComponent();

            dataGridView1.Columns[2].HeaderText = "Ime";
        }

        /// <summary>
        /// Izvršava se prilikom učitavanja forme.
        /// </summary>
        private void frmHighscore_Load(object sender, EventArgs e)
        {
            BindingList<Highscore> lista = null;

            using (dbTypingGameEntities baza = new dbTypingGameEntities())
            {
                lista = new BindingList<Highscore>(baza.Highscore.ToList());
            }

            List<Highscore> SortedList = lista.OrderByDescending(o => o.CPM).ToList();

            highscoreBindingSource.DataSource = SortedList;
        }

        /// <summary>
        /// Ispisuje poredak u Highscoreu.
        /// </summary>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[1].Value = (e.RowIndex + 1).ToString();
        }
    }
}
