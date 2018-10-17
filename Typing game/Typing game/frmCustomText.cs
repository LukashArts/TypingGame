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
    public partial class frmCustomText : Form
    {
        public frmCustomText()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Izvršava se prilikom korištenja gumba Add.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;

            List<string> separated = new List<string>();

            separated = text.Split(new Char[] { ' ', '\n' }).ToList();
            
            //pregledat ako je koji prazan unutar liste da ne dođe unutra.
            if(separated.Count < 220)
            {
                for(int i = 0; i < 220; i++)
                {
                    separated.Add(separated[i]);
                    if (separated.Count >= 220)
                        break;
                }
            }
            frmStart start = new frmStart(separated, "random");
            start.ShowDialog();
        }

        /// <summary>
        /// Izvršava se prilikom otvaranja forme.
        /// </summary>
        private void frmCustomText_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        /// <summary>
        /// Izvršava se prilikom korištenja gumba InOrder.
        /// </summary>
        private void btnInOrder_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;

            List<string> separated = new List<string>();

            separated = text.Split(new Char[] { ' ', '\n' }).ToList();

            frmStart start = new frmStart(separated, "inOrder");
            start.ShowDialog();
        }
    }
}
