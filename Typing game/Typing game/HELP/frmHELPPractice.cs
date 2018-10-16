using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_game.HELP
{
    public partial class frmHELPPractice : Form
    {
        public frmHELPPractice()
        {
            InitializeComponent();
        }

        private bool eng { get; set; }

        /// <summary>
        /// Konstruktor koji se izvršava prilikom otvaranja forme.
        /// </summary>
        /// <param name="english">Odabrani jezik.</param>
        public frmHELPPractice(bool english)
        {
            eng = english;
            InitializeComponent();

            if(eng == false)
            {
                lbTitle.Text = "Poboljšaj svoje vještine!";
                lbText.Text = "Ovaj dio aplikacije pomaže Vam da vježbate na sposobnostima \ntipkanja. Ako dovoljno vježbate rezultati će brzo doći!";

                lbEasy1.Text = "Lagana -";
                lbEasy2.Location = new Point(93, 131);
                lbEasy2.Text = "riječi do 4 slova.";

                lbMedium1.Text = "Srednja -";
                lbMedium2.Text = "riječi između 7 i 9 slova.";

                lbHard1.Text = "Teška -";
                lbHard2.Location = new Point(82, 184);
                lbHard2.Text = "riječi veće od 10 slova.";

                lbCustom1.Text = "Custom -";
                lbCustom2.Text = "Vaš tekst.";
            }
        }
    }
}
