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
    public partial class frmHELPMain : Form
    {
        public frmHELPMain()
        {
            InitializeComponent();
        }

        private bool eng { get; set; }

        /// <summary>
        /// Konstruktor za otvaranje forme.
        /// </summary>
        /// <param name="english">Odabrani jezik.</param>
        public frmHELPMain(bool english)
        {
            eng = english;
            InitializeComponent();

            if(eng == false)
            {
                lbTitle.Text = "Kako koristiti? HELP sadržaj";

                lbText.Text = "Aplikacija Vam pomaže da saznate vašu brzinu tipkanja. \nOsim toga, imate mogućnost usavršavanja vašeg pisanja \nna tipkovnici kao i natjecanje s drugima na istom računalu." +
                    "\n\nZa lakše snalaženje u aplikaciji objašnjene su sljedeće stavke: \n\n" +
                    "START - prilikom odabira se pojavljuje prozor s kojim je \nmoguće saznati brzinu tipkanja.\n" +
                    "PRACTICE - služi za usavršavanje tipkanja i svakodnevnog \nvježbanja \n"+
                    "HIGHSCORE - prikazuje ljestvicu po brzini tipkanja(CPM i WPM) \n"+
                    "EXIT - izlaz iz aplikacije";
            }
        }
    }
}
