using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesForms
{
    public partial class WelcomeTicTacToeForm : Form
    {
        public WelcomeTicTacToeForm()
        {
            InitializeComponent();
        }

        private void Singleplayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your goal is to put 3 of your shape (X or O) in a vertical,horizontal,or slant row");

        }

        private void Multiplayer_Click(object sender, EventArgs e)
        {

        }
    }
}
