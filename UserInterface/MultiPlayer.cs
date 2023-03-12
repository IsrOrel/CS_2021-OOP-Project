using GamesLogic.Games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamesLogic.Games.TicTacToe;
using GamesLogic.Games.FourInARow;
using System.Threading;

namespace UserInterface
{
    public partial class MultiPlayer : Form
    {
        private readonly string[] _players;
        public MultiPlayer(string[] players)
        {
            InitializeComponent();
            _players = players;
        }

        private void TicTacToe_Click(object sender, EventArgs e)
        {
            ShowWithWelcomeScreen<FormTicTacToeGame>(
                "Welcome to the TicTacToe game:",
                "Your goal is to put 3 of your shape (X or O) in a vertical,horizontal,or slant row");
        }

        private void FourInARow_Click(object sender, EventArgs e)
        {
            ShowWithWelcomeScreen<FormFourInARowGame>(
                "Welcome to the FourInARow game:",
                "Your goal is to put 4 of your color in a vertical,horizontal,or slant row");
        }

        private void ShowWithWelcomeScreen<TGame>(string title, string howTo) where TGame : IGame, new()
        {
            WelcomeForm welcome = new WelcomeForm(title, howTo, StartGame);
            welcome.ShowDialog(this);

            void StartGame()
            {
                var game = new TGame();
                game.Init(_players);
                game.StartGame();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
