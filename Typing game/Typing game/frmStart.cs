using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using EasyWords;

namespace Typing_game
{
    public partial class frmStart : Form
    {        
        public frmStart()
        {
            ClassLibrary1.Class1 words = new ClassLibrary1.Class1();
            randomWords = words.GetWordList();

            InitializeComponent();            
        }

        private string choosenDifficulty = null;

        private bool hrvat;

        public frmStart(bool hrvatski)
        {
            hrvat = hrvatski;

            //hrvatske riječi, tu nešt ne valja - mora se složit dll za hrv riječi, inače ne radi.
            randomWords = new List<string>();
            randomWords.Add("avion");
            randomWords.Add("palma");
            
            InitializeComponent();

            lbTimeName.Text = "Vrijeme:";
            lbWordName.Text = "Riječi:";
            lbChName.Text = "Slova:";
            btnRestart.Name = "Ponovi";
        }

        /// <summary>
        /// Odnosi se na practice i određivanju koju će težinu riječi koristiti.
        /// </summary>
        /// <param name="difficulty">Težina riječi.</param>
        public frmStart(string difficulty)
        {              
            choosenDifficulty = difficulty;
            
            if(choosenDifficulty == "easy")
            {                
                EasyWords.Class1 words = new EasyWords.Class1();
                randomWords = words.GetWordList();
            }

            else if(choosenDifficulty == "medium")
            {

            }

            else if(choosenDifficulty == "hard")
            {
                Hard_Words.Class1 words = new Hard_Words.Class1();
                randomWords = words.GetWordList();
            }

            InitializeComponent();
        }

        List<string> randomWords = null;
        Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// Pokreće se prilikom otvaranja forme.
        /// </summary>
        private void frmStart_Load(object sender, EventArgs e)
        {            
            RandomWords();

            if(choosenDifficulty == "easy")
            {
                lbTimeName.Hide();
                lbSeconds.Text = "Difficulty: EASY";
                lbSeconds.Location = new Point(200, 35);
                lbSeconds.Font = new Font(lbSeconds.Font.FontFamily, 12);
            }
            else if(choosenDifficulty == "medium")
            {
                lbTimeName.Hide();
                lbSeconds.Text = "Difficulty: MEDIUM";
                lbSeconds.Location = new Point(200, 35);
                lbSeconds.Font = new Font(lbSeconds.Font.FontFamily, 12);
            }
            else if (choosenDifficulty == "hard")
            {
                lbTimeName.Hide();
                lbSeconds.Text = "Difficulty: HARD";
                lbSeconds.Location = new Point(200, 35);
                lbSeconds.Font = new Font(lbSeconds.Font.FontFamily, 12);
            }
        }

        int number = 0;
        int numbers = 0;
        /// <summary>
        /// Puni textbox sa slučajnim riječima.
        /// </summary>
        private void RandomWords()
        {
            Random rand = new Random();
            number = rand.Next(randomWords.Count);

            if (numbers == number)
            {
                // provjera da ne bi došla ista riječ
                RandomWords();
            }
            else
            {
                for (int i = 0; i < randomWords.Count; i++)
                {
                    if (i == number)
                    {
                        txtWords.Text = randomWords[i];
                        numbers = number;
                    }
                }
            }            
        }

        /// <summary>
        /// Timer koji broji svaku stotinku.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {                          
            lbSeconds.Text = stopwatch.Elapsed.ToString("ss\\.f");
            if (stopwatch.Elapsed.Minutes >= 1)
            {                
                stopwatch.Stop();
                txtWrite.Enabled = false;
            }         
        }

        int sizeOfWords = 0;
        int correctWords = 0;
        /// <summary>
        /// Provjerava ispravnost unesenog teksta i prelazi na novi.
        /// </summary>
        private void txtWrite_TextChanged(object sender, EventArgs e)
        {
            if(txtWrite.Text == txtWords.Text)
            {
                sizeOfWords = sizeOfWords + txtWords.TextLength;

                RandomWords();
                txtWrite.Clear();
                correctWords = correctWords + 1;
                PrintOutSpeed();

                btnRestart.Enabled = true;
            }
        }

        /// <summary>
        /// Timer počinje kada se unese prvo slovo.
        /// </summary>
        private void txtWrite_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnRestart.PerformClick();
            }
            else
            {
                if(choosenDifficulty == null)
                {
                    timer.Start();
                    stopwatch.Start();
                }                
            }            
        }

        /// <summary>
        /// Restarta cijelu formu.
        /// </summary>
        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtWrite.Clear();
            txtWrite.Enabled = true;
            txtWrite.Focus();

            correctWords = 0;
            sizeOfWords = 0;
            PrintOutSpeed();

            stopwatch.Stop();
            stopwatch.Reset();

            RandomWords();            
        }

        /// <summary>
        /// Ispisuje WPM i CPM.
        /// </summary>
        private void PrintOutSpeed()
        {
            lbWords.Text = correctWords.ToString();
            lbCharacters.Text = sizeOfWords.ToString();
        }

        /// <summary>
        /// Nakon entera restarta parametre.
        /// </summary>
        private void txtWords_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnRestart.PerformClick();
            }
        }
    }
}
