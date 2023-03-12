using GamesLogic.Games;
using GamesLogic.Games.GuessMyNumber;
using GamesLogic.Games.RockPaperScissors;
using GamesLogic.Games.TicTacToe;
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

namespace UserInterface
{
    public partial class SinglePlayer : Form
    {
        private readonly string _playerName;
        public SinglePlayer(string playerName)
        {
            InitializeComponent();
            _playerName = playerName;
        }

        private void RockPapperScissors_Click(object sender, EventArgs e)
        {
            ShowWithWelcomeScreen<FormRockPaperScissors>(
                "Welcome to the Rock / Papper / Scissors game:",
                "Your goal is to win the computer the ruls are:\nRock win Scissors\nPaper win Rock\nScissors win Paper\nChoose wisely :)");
        }

        private void ShowWithWelcomeScreen<TGame>(string title, string howTo) where TGame : IGame, new()
        {
            WelcomeForm welcome = new WelcomeForm(title, howTo, StartGame);
            welcome.ShowDialog(this);

            void StartGame()
            {
                var game = new TGame();
                game.Init(new[] { _playerName });
                game.StartGame();
            }
        }
    
        private void TicTacToe_Click(object sender, EventArgs e)
        {
            ShowWithWelcomeScreen<FormGuessMyNumber>(
                "Welcome to Guess my number game:",
                "Your goal is to guess the number the computer chose in minimal tries");
        }
    }
}
