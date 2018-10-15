using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Typing_game.HELP;

namespace Typing_game
{
    public partial class frmHELP : Form
    {       
        public frmHELP()
        {
            InitializeComponent();
        }
        
        private bool eng { get; set; }

        /// <summary>
        /// Konstruktor za otvaranje forme.
        /// </summary>
        /// <param name="english">Odabrani jezik.</param>
        public frmHELP(bool english)
        {
            eng = english;
            InitializeComponent();

            if (eng == false)
            {
                msHighscore.Text = "Rezultati";
                msLanguage.Text = "Jezik";
                msMain.Text = "Glavni";
                msPractice.Text = "Vježbaj";
            }                      
        }

        /// <summary>
        /// Izvršava se prilikom otvaranja forme.
        /// </summary>
        private void frmHELP_Load(object sender, EventArgs e)
        {
            HELPMain();
        }

        /// <summary>
        /// Izvršava se nakon što se odabere Main MenuStrip.
        /// </summary>
        private void msMain_Click(object sender, EventArgs e)
        {
            HELPMain();
        }

        /// <summary>
        /// Metoda za učitavanje Main HELP forme.
        /// </summary>
        private void HELPMain()
        {
            frmHELPMain frm = new frmHELPMain(eng);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        /// <summary>
        /// Izvršava se nakon što se odabere Start MenuStrip.
        /// </summary>
        private void msStart_Click(object sender, EventArgs e)
        {
            frmHELPStart frm = new frmHELPStart(eng);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        /// <summary>
        /// Izvršava se nakon što se odabere Practice MenuStrip.
        /// </summary>
        private void msPractice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Practice");
        }

        /// <summary>
        /// Izvršava se nakon što se odabere Highscore MenuStrip.
        /// </summary>
        private void msHighscore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highscore");
        }

        /// <summary>
        /// Izvršava se nakon što se odabere Language MenuStrip.
        /// </summary>
        private void msLanguage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Language");
        }
    }
}
