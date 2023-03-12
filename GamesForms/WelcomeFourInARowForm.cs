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
    public partial class WelcomeFourInARowForm : Form
    {
        public WelcomeFourInARowForm()
        {
            InitializeComponent();
        }

        private void Singleplayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your goal is to put 3 of your color in a vertical,horizontal,or slant row");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Multiplayer_Click(object sender, EventArgs e)
        {

        }
    }
}
