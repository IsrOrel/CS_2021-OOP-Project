using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesLogic.Games
{
    public abstract class ARockPaperScissorsGame : ASinglePlayerGame
    {
        private static Random _Rand = new Random();
        protected GameState State => (GameState)_state;
        public override void Init(string[] playersName)
        {
            _state = new GameState();
            base.Init(playersName);
            State.IsGameOver = false;
        }

        //public override void Load(string savedGame)
        //{
        //    GameState gameState = JsonConvert.DeserializeObject<GameState>(savedGame);
        //    _state = gameState;
        //}

        public void PlayTurn(ITurnInput turnInput)
        {
            RockPaperScissorsTurnInput input = turnInput as RockPaperScissorsTurnInput;
            if (input == null)
                throw new ArgumentException("Turn input is of invalid type");

            if (State.IsGameOver)
                return;

            State.Computerpick = (Choise)(_Rand.Next(0, 3));
            State.PlayerPick = input.Playerpick;

            if (input.Playerpick == State.Computerpick)
            {
                State.Winner = null;
            }
            else if(input.Playerpick == Choise.Rock && State.Computerpick == Choise.Scissors ||
                input.Playerpick == Choise.Papper && State.Computerpick == Choise.Rock ||
                input.Playerpick == Choise.Scissors && State.Computerpick == Choise.Papper)
            {
                State.Score++;
                State.Winner = State.PlayerName;
            }
            else
            {
                State.Winner = "AI";
            }

            State.IsGameOver = true;
        }

        public class RockPaperScissorsTurnInput : ITurnInput
        {
            public Choise Playerpick { get; set; }
        }

        [Serializable]
        public class GameState : ASinglePlayerGameState
        {
            [JsonProperty("computerPick")]
            public Choise Computerpick { get; set; }

            [JsonProperty("playerPick")]
            public Choise PlayerPick { get; set; }
        }

        public enum Choise
        {
            Rock = 0,
            Papper,
            Scissors
        }
    }
}
