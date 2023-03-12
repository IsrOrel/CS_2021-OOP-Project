using GamesForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesLogic.Games.GuessMyNumber
{
    public class FormGuessMyNumber : AGuessMyNumberGame
    {
        private GuessMyNumberForm _form;
        public override void Init(string[] playersName)
        {
            base.Init(playersName);
            _form = new GuessMyNumberForm();
            _form.OnInputReceived += InputReceivedEventHandler;
        }
        public void DrawStage()
        {
            if(State.IsGameOver)
            {
                _form.Updatestage("Sucsses", State.Lastguess);
            }
            if (State.IsGreaterThanPicked)
            {
                _form.Updatestage("Greater", State.Lastguess);
            }
            else
                _form.Updatestage("lower", State.Lastguess);
        }

        public void InputReceivedEventHandler(int number)
        {
            var turnInput =  new GuessNumberTurnInput
            {
                GuessedNumber = number
            };

            PlayTurn(turnInput);
            DrawStage();
        }
        public override void StartGame()
        {
            _form.Show();
        }
    }
}
