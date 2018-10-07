﻿using System;
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
            if (rbEnglish.Checked)
            {
                frmStart start = new frmStart();
                start.ShowDialog();
            }
            else
            {
                bool hrvatski = true;
                frmStart start = new frmStart(hrvatski);
                start.ShowDialog();
            }
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

        /// <summary>
        /// Mijenja jezik na engleski (default).
        /// </summary>
        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            btnExit.Text = "Exit";
            btnStart.Text = "Start";
            btnPractice.Text = "Practice";
            btnHighscore.Text = "Highscore";
        }

        /// <summary>
        /// Mijenja jezik na hrvatski.
        /// </summary>
        private void rbCroatian_CheckedChanged(object sender, EventArgs e)
        {
            btnExit.Text = "Izlaz";
            btnStart.Text = "Početak";
            btnPractice.Text = "Vježbaj";
            btnHighscore.Text = "Rezultati";
        }

        /// <summary>
        /// Izvršava se tijekom otvaranja aplikacije odnosno forme.
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            rbEnglish.Checked = true;
        }
    }
}