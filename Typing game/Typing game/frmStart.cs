﻿using System;
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
using hrvrijeci;
using medium;

namespace Typing_game
{
    public partial class frmStart : Form
    {        
        /// <summary>
        /// Ako je po defaultu odabran engleski jezik, tada se izvršava sljedeći konstruktor.
        /// </summary>
        public frmStart()
        {
            ClassLibrary1.Class1 words = new ClassLibrary1.Class1();
            randomWords = words.GetWordList();

            InitializeComponent();            
        }

        private string choosenDifficulty = null;

        private bool hrvat;

        /// <summary>
        /// Ako je odabran hrvatski jezik izvršava se sljedeći konstruktor.
        /// </summary>
        /// <param name="hrvatski">Odabrani jezik.</param>
        public frmStart(bool hrvatski)
        {
            hrvat = hrvatski;

            hrvrijeci.Class1 words = new hrvrijeci.Class1();
            randomWords = words.GetWordList();
            
            InitializeComponent();

            lbTimeName.Text = "Vrijeme:";
            lbWordName.Text = "Riječi:";
            lbChName.Text = "Slova:";
            btnRestart.Text = "Ponovi";
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
                medium.Class1 words = new medium.Class1();
                randomWords = words.GetWordList();
            }

            else if(choosenDifficulty == "hard")
            {
                Hard_Words.Class1 words = new Hard_Words.Class1();
                randomWords = words.GetWordList();
            }

            InitializeComponent();
        }

        private bool verifyingCustom = false;
        private bool type = true;
        /// <summary>
        /// Izvršava se ako korisnik odabere custom text prilikom vježbanja.
        /// </summary>
        /// <param name="customText">Lista teksta.</param>
        /// <param name="typeOfText">Tip teksta.</param>
        public frmStart(List<string> customText, string typeOfText)
        {
            randomWords = customText;

            if (typeOfText == "random")
                type = true;
            else
                type = false;

            verifyingCustom = true;
            choosenDifficulty = "custom";

            InitializeComponent();
        }

        List<string> randomWords = null;
        /// <summary>
        /// Pokreće se prilikom otvaranja forme.
        /// </summary>
        private void frmStart_Load(object sender, EventArgs e)
        {
            RandomWords();
            this.CenterToScreen();

            if (choosenDifficulty == "easy")
            {
                lbTimeName.Hide();
                lbSeconds.Text = "Difficulty: EASY";
                lbSeconds.Location = new Point(200, 35);
                lbSeconds.Font = new Font(lbSeconds.Font.FontFamily, 12);
            }
            else if (choosenDifficulty == "medium")
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
            else if(choosenDifficulty == "custom")
            {
                lbTimeName.Hide();
                lbSeconds.Text = "Difficulty: CUSTOM";
                lbSeconds.Location = new Point(200, 35);
                lbSeconds.Font = new Font(lbSeconds.Font.FontFamily, 12);
            }
        }

        int number = 0;
        List<string> allWords = null;
        List<string> allWordsDis = null;
        /// <summary>
        /// Puni textbox sa slučajnim riječima.
        /// </summary>
        private void RandomWords()
        {
            Random rand = new Random();
            allWords = new List<string>();
            allWordsDis = new List<string>();

            if(type == true)
            {
                for (int j = 0; j < 220; j++)
                {
                    number = rand.Next(randomWords.Count);

                    for (int i = 0; i < randomWords.Count; i++)
                    {
                        if (i == number)
                        {
                            if (allWords.Count == 0)
                            {
                                allWords.Add(randomWords[i]);
                                break;
                            }
                            else
                            {
                                if (allWords[allWords.Count - 1] == randomWords[i])
                                {
                                    break;
                                }
                                else
                                {
                                    allWords.Add(randomWords[i]);
                                    break;
                                }
                            }
                        }
                    }
                }

                if (verifyingCustom == false)
                    allWordsDis = allWords.Distinct().ToList();
                else
                    allWordsDis = allWords;

                txtWords.Text = allWordsDis[0];
                txtNextWord1.Text = allWordsDis[1];
                txtNextWord2.Text = allWordsDis[2];
            }
            else
            {
                allWordsDis = randomWords;
            }
        }

        Stopwatch stopwatch = new Stopwatch();
        bool check = false;
        /// <summary>
        /// Izvršavanje štoperice.
        /// </summary>
        private void timer_Tick(object sender, EventArgs e)
        {                          
            lbSeconds.Text = stopwatch.Elapsed.ToString("ss\\.f");
            if (stopwatch.Elapsed.Minutes >= 1)
            {
                lbSeconds.Text = stopwatch.Elapsed.ToString("m\\:ss\\.f");
                if (check == true || string.IsNullOrWhiteSpace(txtWrite.Text))
                {                    
                    stopwatch.Stop();
                    timer.Stop();
                    txtWrite.Enabled = false;
                    Calculating();
                }
            }         
        }

        int sizeOfWords = 0;
        int correctWords = 0;
        int i = 0;
        /// <summary>
        /// Provjerava ispravnost unesenog teksta i prelazi na novi.
        /// </summary>
        private void txtWrite_TextChanged(object sender, EventArgs e)
        {     
            if(txtWrite.Text == txtWords.Text)
            {
                sizeOfWords = sizeOfWords + txtWords.TextLength;

                txtWords.Text = allWordsDis[i + 1];
                txtNextWord1.Text = allWordsDis[i + 2];
                txtNextWord2.Text = allWordsDis[i + 3];
                //ponavljanje tih 3 riječi ako je custom
                i++;

                txtWrite.Clear();
                correctWords = correctWords + 1;
                PrintOutSpeed();

                check = true;
                btnRestart.Enabled = true;
            }
            else
            {
                check = false;
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
                if(choosenDifficulty == null && verifyingCustom == false)
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
            i = 0;

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

        /// <summary>
        /// Izračunava WPM i CPM.
        /// </summary>
        private void Calculating()
        {
            double CPM;
            double WPM;

            double time = stopwatch.Elapsed.TotalMinutes;
            int minutes = stopwatch.Elapsed.Minutes;

            if(lbSeconds.Text == "1:00.0")
            {
                CPM = sizeOfWords;
            }
            else
            {
                CPM = sizeOfWords / time;                
            }

            WPM = CPM / 5;

            decimal dCPM = (decimal)CPM;
            decimal dWPM = (decimal)WPM;

            int iCPM = (int)decimal.Round(dCPM, 0, MidpointRounding.AwayFromZero);
            int iWPM = (int)decimal.Round(dWPM, 0, MidpointRounding.AwayFromZero);

            textBox1.Text = iCPM.ToString();
            textBox2.Text = iWPM.ToString();

            CheckForHighscore(iCPM, iWPM);
        }

        /// <summary>
        /// Provjerava je li rezultat dovoljan za ući na listu.
        /// </summary>
        private void CheckForHighscore(int iCPM, int iWPM)
        {
            List<Highscore> sortedList = null;
            BindingList<Highscore> list = null;
            using (dbTypingGameEntities baza = new dbTypingGameEntities())
            {
                list = new BindingList<Highscore>(baza.Highscore.ToList());
            }
            sortedList = list.OrderByDescending(o => o.CPM).ToList();

            List<Highscore> listEnglish = new List<Highscore>();
            List<Highscore> listCroatian = new List<Highscore>();

            foreach (Highscore item in sortedList)
            {
                if (item.language == hrvat)
                {
                    listCroatian.Add(item);
                }
                else
                {
                    listEnglish.Add(item);
                }
            }
            if (hrvat)
            {
                if (listCroatian.Count < 10 || listCroatian[listCroatian.Count - 1].CPM < iCPM)
                {
                    ScoreInput scoreInput = new ScoreInput(iCPM, iWPM, hrvat);
                    scoreInput.ShowDialog();

                    ShowHighscore();
                }
                else
                {
                    ShowHighscore();
                }
            }
            else
            {
                if (listEnglish.Count < 10 || listEnglish[listEnglish.Count - 1].CPM < iCPM)
                {
                    ScoreInput scoreInput = new ScoreInput(iCPM, iWPM, hrvat);
                    scoreInput.ShowDialog();

                    ShowHighscore();
                }
                else
                {
                    ShowHighscore();
                }
            }
        }

        /// <summary>
        /// Prikazuje tablicu s rezultatima.
        /// </summary>
        private void ShowHighscore()
        {
            frmHighscore frm = new frmHighscore(hrvat);
            frm.ShowDialog();
        }

        /// <summary>
        /// Izvršava se ako korisnik izađe iz forme Start.
        /// </summary>
        private void frmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                timer.Stop();
                stopwatch.Stop();
            }
        }
    }
}
