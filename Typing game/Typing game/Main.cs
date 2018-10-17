using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
            if (english)
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
            if (english)
            {
                frmHighscore highscore = new frmHighscore();
                highscore.ShowDialog();
            }
            else
            {
                frmHighscore highscore = new frmHighscore(true);
                highscore.ShowDialog();
            }
        }

        /// <summary>
        /// Izlaz iz aplikacije.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (english)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da želite izaći?", "Izlaz", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        /// <summary>
        /// Otvara formu za vježbanje.
        /// </summary>
        private void btnPractice_Click(object sender, EventArgs e)
        {
            if (english)
            {
                frmPractice practice = new frmPractice();
                practice.ShowDialog();
            }
            else
            {            
                frmPractice practice = new frmPractice(true);
                practice.ShowDialog();
            }
        }

        bool english = false;
        /// <summary>
        /// Izvršava se tijekom otvaranja aplikacije odnosno forme.
        /// </summary>
        private void Main_Load(object sender, EventArgs e)
        {
            english = true;
        }

        /// <summary>
        /// Gumb koji mijenja jezik na hrvatski.
        /// </summary>
        private void btnCroatian_Click(object sender, EventArgs e)
        {
            english = false;

            btnExit.Text = "Izlaz";
            btnStart.Text = "Početak";
            btnPractice.Text = "Vježbaj";
            btnHighscore.Text = "Rezultati";
        }

        /// <summary>
        /// Gumb koji mijenja jezik na engleski (default).
        /// </summary>
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            english = true;

            btnExit.Text = "Exit";
            btnStart.Text = "Start";
            btnPractice.Text = "Practice";
            btnHighscore.Text = "Highscore";
        }

        /// <summary>
        /// Izvršava se nakon što se stisne HELP (?).
        /// </summary>
        private void Main_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            LoadHelp();
        }

        /// <summary>
        /// Izvršava se nakon što se stisne gumb F12 (za HELP).
        /// </summary>
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                LoadHelp();
            }
        }

        /// <summary>
        /// Učitava HELP file.
        /// </summary>
        private void LoadHelp()
        {
            //Process.Start(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "spartan-trials.pdf"));

            //Process.Start("spartan-trials.pdf");

            frmHELP frm = new frmHELP(english);
            frm.ShowDialog();

            //ProcessStartInfo startInfo = new ProcessStartInfo("C:\\Program Files (x86)\\Adobe\\Acrobat 11.0\\Acrobat\\Acrobat.exe", "/A page=5 C:\\spartan-trials.pdf");
            //startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            //Process.Start(startInfo);
        }
    }
}
