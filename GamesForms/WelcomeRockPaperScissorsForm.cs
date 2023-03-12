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
    public partial class WelcomeRockPaperScissorsForm : Form
    {
        public WelcomeRockPaperScissorsForm()
        {
            InitializeComponent();
        }

        private void HowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this game youre playing against the coputer each on of you chose a weapon:\nRock\nPapar\nScissers\nThe rules are:\nRock win Scissers\nScissers win Paper\nPaper win Rock\n If you both chose the same weapons is a tie\nGood Luck");

        }
    }
}
