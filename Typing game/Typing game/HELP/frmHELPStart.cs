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
                lbTitle.Text = "Računanje brzine tipkanja (CPM i WPM)";
            }
        }
    }
}
