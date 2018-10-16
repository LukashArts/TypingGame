using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_game.HELP
{
    public partial class frmHELPLanguage : Form
    {
        public frmHELPLanguage()
        {
            InitializeComponent();
        }

        private bool eng { get; set; }

        /// <summary>
        /// Konstruktor koji se izvršava prilikom otvaranja forme.
        /// </summary>
        /// <param name="english">Odabrani jezik.</param>
        public frmHELPLanguage(bool english)
        {
            eng = english;
            InitializeComponent();

            if(eng == false)
            {
                lbTitle.Text = "Jezik";
                lbText.Text = "Možete birati između dva jezika:\n\n     hrvatskog i engleskog\n\nJezik se može promijeniti u Meniju klikom na zastave i ovdje!";
            }
        }

        /// <summary>
        /// Prebacuje jezik u engleski.
        /// </summary>
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            eng = true;

            frmHELP frm = new frmHELP(eng);
            frm.Show();
        }

        /// <summary>
        /// Prebacuje jezik u hrvatski.
        /// </summary>
        private void btnCroatian_Click(object sender, EventArgs e)
        {
            eng = false;
        }
    }
}
