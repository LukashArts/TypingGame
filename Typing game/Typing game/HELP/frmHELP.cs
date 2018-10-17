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

            ChangeMSLanguage();
        }

        private bool verify { get; set; }

        /// <summary>
        /// Izvršava se ako je promijenjen jezik u msLanguage.
        /// </summary>
        /// <param name="english"></param>
        /// <param name="i">Jezik je promijenjen</param>
        public frmHELP(bool english, bool i)
        {
            verify = i;
            eng = english;

            ChangeMSLanguage();
        }

        /// <summary>
        /// Mijenja jezik na MenuStripu.
        /// </summary>
        private void ChangeMSLanguage()
        {                        
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
            this.CenterToScreen();

            if (verify == true)
            {
                msLanguage.PerformClick();
            }
            else
            {
                HELPMain();
            }
            
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
            frmHELPPractice frm = new frmHELPPractice(eng);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        /// <summary>
        /// Izvršava se nakon što se odabere Highscore MenuStrip.
        /// </summary>
        private void msHighscore_Click(object sender, EventArgs e)
        {
            frmHELPHighscore frm = new frmHELPHighscore(eng);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        /// <summary>
        /// Izvršava se nakon što se odabere Language MenuStrip.
        /// </summary>
        private void msLanguage_Click(object sender, EventArgs e)
        {
            frmHELPLanguage frm = new frmHELPLanguage(eng);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        /// <summary>
        /// Izvršava se nakon što se odabere About MenuStrip.
        /// </summary>
        private void msAbout_Click(object sender, EventArgs e)
        {
            frmHELPAbout frm = new frmHELPAbout(eng);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
