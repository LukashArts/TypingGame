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
    public partial class frmHELPStart : Form
    {
        public frmHELPStart()
        {
            InitializeComponent();
        }

        private bool eng { get; set; }

        /// <summary>
        /// Konstruktor koji se izvršava prilikom otvaranje forme.
        /// </summary>
        /// <param name="english">Odabrani jezik.</param>
        public frmHELPStart(bool english)
        {
            eng = english;
            InitializeComponent();

            if(eng == false)
            {
                lbTitle.Text = "Računanje brzine tipkanja";
                lbText.Text = "Glavna funkcionalnost aplikacije jest da računa\nbrzinu tipkanja. Probajte biti što brži možete!";

                lbText2.Location = new Point(57, 155);
                lbText3.Location = new Point(104, 155);
                lbText3.Text = "Slova po minuti (engl. Characters per minute)\nRiječi po minuti (engl. Words per minute)";
                lbText4.Text = "WPM se dobiva tako da se CPM podijeli s 5, jer se prosječna\nriječ sastoji od 5 slova.";
                lbTextWords.Text = "Riječi su slučajno odabrane!";
            }
        }
    }
}
