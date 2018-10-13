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
    public partial class ScoreInput : Form
    {
        public ScoreInput()
        {
            InitializeComponent();
        }

        private int CPM { get; set; }
        private int WPM { get; set; }
        private bool Hrv { get; set; }
        /// <summary>
        /// Izvršava se prilikom otvaranja forme gdje se prenose CPM i WPM podaci.
        /// </summary>
        /// <param name="iCPM">Slova po minuti.</param>
        /// <param name="iWPM">Riječi po minuti.</param>
        public ScoreInput(int iCPM, int iWPM, bool hrvat)
        {
            CPM = iCPM;
            WPM = iWPM;

            if (hrvat == true)
                Hrv = false;
            else
                Hrv = true;

            InitializeComponent();
        }

        /// <summary>
        /// Gumb prilikom kojeg se usnimava rezultat.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {    
            
            using(dbTypingGameEntities baza = new dbTypingGameEntities())
            {
                Highscore highscore = new Highscore
                {
                    nickname = txtName.Text,
                    CPM = CPM,
                    WPM = WPM,
                    language = Hrv,
                };
                baza.Highscore.Add(highscore);
                baza.SaveChanges();
            }
            Close();
        }

        /// <summary>
        /// Izvršava se prilikom otvaranja forme.
        /// </summary>
        private void ScoreInput_Load(object sender, EventArgs e)
        {
            lbCPM.Text = CPM.ToString();
            lbWPM.Text = WPM.ToString();
        }
    }
}
