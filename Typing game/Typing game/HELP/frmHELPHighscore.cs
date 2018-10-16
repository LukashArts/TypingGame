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
    public partial class frmHELPHighscore : Form
    {
        public frmHELPHighscore()
        {
            InitializeComponent();
        }

        private bool eng { get; set; }

        public frmHELPHighscore(bool engleski)
        {
            eng = engleski;
            InitializeComponent();

            if (eng == false)
            {
                lbTitle.Text = "Tablica rezultata";
                lbText.Text = "U rezultatima se mogu pratiti Vaši rezultati. Pokažite da ste \nbolji od ostalih!\n\nPostoji cjelokupna, engleska i hrvatska tablica.\n\n" +
                    "Cjelokupna tablica sadrži rezultate od oba jezika.\n" +
                    "Engleska tablica sadrži rezultate od samo engleskog jezika.\n" +
                    "Hrvatska tablica sadrži rezultate od samo hrvatskog jezika.";
            }
        }
    }
}
