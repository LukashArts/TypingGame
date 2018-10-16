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
    public partial class frmHELPAbout : Form
    {
        public frmHELPAbout()
        {
            InitializeComponent();
        }

        private bool eng { get; set; }

        /// <summary>
        /// Konstruktor koji se izvršava prilikom otvaranja forme.
        /// </summary>
        public frmHELPAbout(bool english)
        {
            eng = english;
            InitializeComponent();
            
            if (eng == false)
            {
                lbTitle.Text = "O meni";
                lbText.Text = "Moje ime je Mihael Lukaš i ja sam stvorio ovu aplikaciju.\n\nAko imate nekakvih pitanja vezanih unutar i izvan \naplikacije, možete me dobiti putem maila.";
            }
        }

        /// <summary>
        /// Šalje se mail.
        /// </summary>
        private void lnkMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:mihael.lukas@hotmail.com");
        }
    }
}
