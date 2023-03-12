using GamesForms;
using GamesLogic.Games.FourInARow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamesLogic.Games.RockPaperScissors
{
    public class FormRockPaperScissors : ARockPaperScissorsGame
    {
        private RockPaperScissorsForm _form;
        public override void Init(string[] playersName)
        {
            base.Init(playersName);
            _form = new RockPaperScissorsForm();
            _form.OnInputReceived += InputReceivedEventHandler;
        }

        public void DrawStage()
        {
            switch(State.Computerpick)
            {
                case Choise.Rock:
                    _form.AIpicked("r");
                    break;
                case Choise.Papper:
                    _form.AIpicked("p");
                    break;
                case Choise.Scissors:
                    _form.AIpicked("s");
                    break;
            }

            _form.Callwinner(State.Winner);
        }

        public void InputReceivedEventHandler(string input)
        {
            RockPaperScissorsTurnInput turnInput = null;
            switch (input)
            {

                case "r":
                    turnInput = new ARockPaperScissorsGame.RockPaperScissorsTurnInput { Playerpick = Choise.Rock };
                    break;
                case "p":
                    turnInput = new ARockPaperScissorsGame.RockPaperScissorsTurnInput { Playerpick = Choise.Papper };
                    break;
                case "s":
                    turnInput = new ARockPaperScissorsGame.RockPaperScissorsTurnInput { Playerpick = Choise.Scissors };
                    break;
            }

            PlayTurn(turnInput);
            DrawStage();
        }

        public override void StartGame()
        {
            _form.Show();
        }
    }
}
