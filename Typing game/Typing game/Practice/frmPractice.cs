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
    public partial class frmPractice : Form
    {
        public frmPractice()
        {
            InitializeComponent();
        }

        private bool Hrv { get; set; }

        /// <summary>
        /// Konstruktor ako je odabran hrvatski jezik.
        /// </summary>
        /// <param name="hrvatski">Odabrani jezik.</param>
        public frmPractice(bool hrvatski)
        {
            Hrv = hrvatski;
            InitializeComponent();

            label1.Text = "Odaberite težinu:";
            btnEasy.Text = "Lagana";
            btnMedium.Text = "Srednja";
            btnHard.Text = "Teška";
        }

        /// <summary>
        /// Lagana razina.
        /// </summary>
        private void btnEasy_Click(object sender, EventArgs e)
        {
            frmStart start = new frmStart("easy");
            start.ShowDialog();
        }

        /// <summary>
        /// Srednja razina.
        /// </summary>
        private void btnMedium_Click(object sender, EventArgs e)
        {
            frmStart start = new frmStart("medium");
            start.ShowDialog();
        }

        /// <summary>
        /// Teška razina.
        /// </summary>
        private void btnHard_Click(object sender, EventArgs e)
        {
            frmStart start = new frmStart("hard");
            start.ShowDialog();
        }

        /// <summary>
        /// Izvršava se prilikom učitavanja forme.
        /// </summary>
        private void frmPractice_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
