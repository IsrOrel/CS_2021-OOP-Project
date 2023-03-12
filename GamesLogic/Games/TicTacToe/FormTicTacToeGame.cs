using GamesForms;
using GamesLogic.Games.TickTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesLogic.Games.TicTacToe
{
    
    public class FormTicTacToeGame : ATicTacToeGame
    {
        private TicTacToeForm _form;
        public override void Init(string[] playersName)
        {
            base.Init(playersName);
            _form = new TicTacToeForm();
            _form.OnGameSave += Save;
            _form.OnGameLoad += Load;
            _form.OnInputReceived += InputReceivedEventHandler;
        }

        public void DrawStage()
        {
            if (State.IsGameOver)
                _form.CallWinner(State.Winner);
        }

        public void InputReceivedEventHandler(int input)
        {
            var turnInput =  new TurnInput 
            { 
                X = input / 3, 
                Y = input % 3 
            };

            PlayTurn(turnInput);
            DrawStage();
        }

        public override void StartGame()
        {
            _form.Show();
        }

        public override void Load(string filePath)
        {
            base.Load(filePath);
            _form.ReDraw(State.Map);
        }
    }
}
