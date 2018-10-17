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
            btnAll.Text = "Svi";
            btnCroatian.Text = "Hrvatski";
            btnEnglish.Text = "Engleski";
        }

        /// <summary>
        /// Izvršava se prilikom učitavanja forme.
        /// </summary>
        private void frmHighscore_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            LoadingHighscore();
            LoadingHighscore(); //nekako srediti ovo da se ne mora dva puta učitavat
            highscoreBindingSource.DataSource = FirstTenHighscores;
        }

        /// <summary>
        /// Ispisuje poredak u Highscoreu.
        /// </summary>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells[1].Value = (e.RowIndex + 1).ToString();
        }

        List<Highscore> SortedList = null;
        List<Highscore> FirstTenHighscores = null;
        /// <summary>
        /// Pokazuje rezultate koji su napravljeni na engleskom jeziku.
        /// </summary>
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            LoadingHighscore();

            List<Highscore> englishHighscore = new List<Highscore>();

            foreach(Highscore score in SortedList)
            {
                if (score.language == false)
                    englishHighscore.Add(score);
            }
            if (englishHighscore.Count > 10)
            {
                using (dbTypingGameEntities baza = new dbTypingGameEntities())
                {                
                    baza.Highscore.Attach(englishHighscore[englishHighscore.Count - 1]);
                    baza.Highscore.Remove(englishHighscore[englishHighscore.Count - 1]);
                    baza.SaveChanges();
                }
                englishHighscore.Remove(englishHighscore[englishHighscore.Count - 1]);
            }
            highscoreBindingSource.DataSource = englishHighscore;
        }

        /// <summary>
        /// Svi rezultati.
        /// </summary>
        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadingHighscore();

            highscoreBindingSource.DataSource = FirstTenHighscores;

            //Ponovno učitavanje forme.
            //frmHighscore_Load(sender, e);
        }

        /// <summary>
        /// Pokazuje rezultate koji su napravljeni na hrvatskom jeziku.
        /// </summary>
        private void btnCroatian_Click(object sender, EventArgs e)
        {
            LoadingHighscore();

            List<Highscore> croatianHighscore = new List<Highscore>();

            foreach (Highscore score in SortedList)
            {
                if (score.language == true)
                    croatianHighscore.Add(score);
            }
            if (croatianHighscore.Count > 10)
            {
                using (dbTypingGameEntities baza = new dbTypingGameEntities())
                {
                    baza.Highscore.Attach(croatianHighscore[croatianHighscore.Count - 1]);
                    baza.Highscore.Remove(croatianHighscore[croatianHighscore.Count - 1]);
                    baza.SaveChanges();
                }
                croatianHighscore.Remove(croatianHighscore[croatianHighscore.Count - 1]);
            }
            highscoreBindingSource.DataSource = croatianHighscore;
        }

        /// <summary>
        /// Učitava Highscore tablicu
        /// </summary>
        private void LoadingHighscore()
        {
            BindingList<Highscore> lista = null;

            using (dbTypingGameEntities baza = new dbTypingGameEntities())
            {
                lista = new BindingList<Highscore>(baza.Highscore.ToList());
            }
            SortedList = lista.OrderByDescending(o => o.CPM).ToList();

            FirstTenHighscores = SortedList.Take(10).ToList();
        }
    }
}
