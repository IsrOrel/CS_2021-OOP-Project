using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLogic.Games.GuessMyNumber
{
    public abstract class AGuessMyNumberGame : ASinglePlayerGame
    {
        private static Random Rand = new Random();
        protected GameState State => (GameState)_state;

        public override void Init(string[] playersName)
        {
            _state = new GameState();
            base.Init(playersName);
            State.PickedNumber = Rand.Next(0, 100);
        }


        protected void PlayTurn(ITurnInput turnInput)
        {
            GuessNumberTurnInput input = turnInput as GuessNumberTurnInput;
            if (input == null)
                throw new ArgumentException("Turn input is of invalid type");

            if (State.IsGameOver)
                return;
            
            State.Score++;
            if (input.GuessedNumber == State.PickedNumber)
            {
                State.IsGameOver = true;
            }
            else
            {
                State.IsGreaterThanPicked = input.GuessedNumber > State.PickedNumber;
            }
            State.Lastguess = input.GuessedNumber;
        }

        public class GuessNumberTurnInput : ITurnInput
        {
            public int GuessedNumber { get; set; }
        }

        [Serializable]
        public class GameState : ASinglePlayerGameState
        {
            [JsonProperty("pickedNumber")]
            public int PickedNumber { get; set; }

            [JsonProperty("isGreaterThanPicked")]
            public bool IsGreaterThanPicked { get; set; }

            [JsonProperty("lastGuess")]
            public int Lastguess { get; set; }
        }
    }
}
