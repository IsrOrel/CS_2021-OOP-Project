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
    public partial class WelcomeGuessMyNumberForm : Form
    {
        public WelcomeGuessMyNumberForm()
        {
            InitializeComponent();
        }

        private void HowToPlay_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Your goal is to guess the number i think about in minimal number of guesses");
        }
    }
}
