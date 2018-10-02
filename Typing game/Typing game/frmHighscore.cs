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
    public partial class frmHighscore : Form
    {
        public frmHighscore()
        {
            InitializeComponent();
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            //string newpath = @"Data Source= ..\..\dbTypingGame.mdf";

            //AppDomain.CurrentDomain.SetData("DataDirectory", newpath);

            BindingList<HighscoreTable> lista = null;

            using(dbTypingGameEntities1 baza = new dbTypingGameEntities1())
            {
                lista = new BindingList<HighscoreTable>(baza.HighscoreTable.ToList());
            }
            highscoreTableBindingSource.DataSource = lista;
        }
    }
}
