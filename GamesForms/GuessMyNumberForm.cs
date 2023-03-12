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
    public partial class GuessMyNumberForm : Form
    {
        public delegate void InputReceivedEventHandler(int number);
        public event InputReceivedEventHandler OnInputReceived;
        public int Guess { get; private set; } = 50;
        public GuessMyNumberForm()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox input = (sender as TextBox);
            var parseSucceeded = int.TryParse(input.Text, out int guessInt);
            if (!parseSucceeded || guessInt < 0 || guessInt > 100)
            {
                 input.Text = Guess.ToString();
                return;
            }

            Guess = guessInt;
            trackBar1.Value = Guess;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackBar input = (sender as TrackBar);
            Guess = input.Value;
            textBox1.Text = Guess.ToString();
        }

        private void Guessbtn_Click(object sender, EventArgs e) =>
            OnInputReceived?.Invoke(Guess);

        private delegate void InvokeDelegate();
        public void Updatestage(string winner,int guess)
        {
            //Invoke(new InvokeDelegate(() =>
            //{
                string message = string.Empty;
                GuessedNumbers.SuspendLayout();
                if (winner == "Sucsses")
                {
                    message = "Gratulation you guessed my secret number";
                    MessageBox.Show("Gratulation you guessed my secret number");
                }
                else if (winner == "Greater")
                {
                    message = $"Your guess: { guess}.Oops, wrong number!, Try again..(Hint: Try lower numbers)";
                }
                else if (winner == "lower")
                {
                    message = $"Your guess: { guess}. Oops, wrong number!, Try again..(Hint: Try greater numbers)";
                }
                Label lbl = new Label();
                lbl.Text = message;
                lbl.AutoSize = true;
                GuessedNumbers.Controls.Add(lbl);
                GuessedNumbers.ResumeLayout();
                GuessedNumbers.PerformLayout();
                GuessedNumbers.Invalidate();
            //}));
        }
    }
}
