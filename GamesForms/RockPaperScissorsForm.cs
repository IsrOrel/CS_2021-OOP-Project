using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesForms
{
    public partial class RockPaperScissorsForm : Form
    {
        public delegate void InputReceivedEventHandler(string input);
        public event InputReceivedEventHandler OnInputReceived;
        public RockPaperScissorsForm() 
        {
            InitializeComponent();
        }

        private void RockPaperScissorsForm_Load(object sender, EventArgs e)
        {

        }
        public void Callwinner(string winner)
        {
            if (winner != null)
            {
                MessageBox.Show($"The winner is: {winner}");
            }
            else
            {
                MessageBox.Show("Draw");
            }
        }

        private void Rock_Click(object sender, EventArgs e)
        {
            Paper.Visible = false;
            Scissors.Visible = false;
            HandleClick("r");
        }

        public void AIpicked(string computer)
        {
            switch (computer)
            {
                case "r":
                    computerChoose.Image = global::GamesForms.Properties.Resources.download;
                    break;

                case "s":
                    computerChoose.Image = global::GamesForms.Properties.Resources.download__3_;
                    break;

                case "p":
                    computerChoose.Image = global::GamesForms.Properties.Resources.download__2_;
                    break;
            }
            
            computerChoose.Invalidate();
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            Rock.Visible = false;
            Scissors.Visible = false;
            HandleClick("p");
        }

        private void Scissors_Click(object sender, EventArgs e)
        {
            Paper.Visible = false;
            Rock.Visible = false;
            HandleClick("s");
        }
        
        private void HandleClick(string input)
        {
            computerChoose.Visible = true;
            computerChooseLabel.Visible = true;
            OnInputReceived?.Invoke(input);
        }

    }
}
