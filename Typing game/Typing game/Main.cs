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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Starta formu za brojanje brzine pisanja.
        /// </summary>
        private void btnStart_Click(object sender, EventArgs e)
        {
            frmStart start = new frmStart();
            start.ShowDialog();
        }

        /// <summary>
        /// Otvara formu za pregledavanje Highscore-a.
        /// </summary>
        private void btnHighscore_Click(object sender, EventArgs e)
        {
            frmHighscore highscore = new frmHighscore();
            highscore.ShowDialog();
        }

        /// <summary>
        /// Izlazi iz aplikacije.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Otvara formu za vježbanje.
        /// </summary>
        private void btnPractice_Click(object sender, EventArgs e)
        {
            frmPractice practice = new frmPractice();
            practice.ShowDialog();
        }
    }
}
