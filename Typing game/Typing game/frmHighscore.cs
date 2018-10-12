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
            BindingList<Highscore> lista = null;

            using(dbTypingGameEntities baza = new dbTypingGameEntities())
            {
                lista = new BindingList<Highscore>(baza.Highscore.ToList());
            }
            highscoreBindingSource.DataSource = lista;
        }
    }
}
