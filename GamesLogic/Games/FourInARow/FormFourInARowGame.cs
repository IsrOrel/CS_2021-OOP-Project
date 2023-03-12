using GamesForms;
using GamesLogic.Games.FourInARow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamesLogic.Games.FourInARow
{
    public class FormFourInARowGame : AFourInARowGame
    {
        private FourInARowform _form;
        public override void Init(string[] playersName)
        {
            base.Init(playersName);
            _form = new FourInARowform();
            _form.OnGameSave += Save;
            _form.OnGameLoad += Load;
            _form.OnInputReceived += InputReceivedEventHandler;
        }

        public void DrawStage()
        {
            if(State.IsGameOver)
            {
                _form.CallWinner(State.Winner);
            }
        }

        public override void StartGame() =>
            _form.Show();

        public void InputReceivedEventHandler(Point input)
        {
            var turnInput =  new AFourInARowGame.AFourInARowGameTurnInput
            {
                X = input.X,
                Y = input.Y
            };

            PlayTurn(turnInput);
            DrawStage();
        }
        public override void Load(string filePath)
        {
            base.Load(filePath);
            _form.ReDraw(State.Map,State.Players,State.CurrentPlayerIndex);
        }
    }
}
