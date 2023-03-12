using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLogic.Games.TickTacToe
{
    public abstract class ATicTacToeGame : AMultiPlayerGame
    {
        protected GameState State => (GameState)_state;
        public override void Init(string[] playersName)
        {
            _state = new GameState();
            base.Init(playersName);
        }

        public override int GetMaxAllowedPlayers() => 2;

        public void PlayTurn(ITurnInput turnInput)
        {
            if (State.IsGameOver)
                return;

            if (turnInput == null)
                return;

            string player = GetNextPlayer();
            TurnInput input = turnInput as TurnInput;
            if (input == null)
                throw new ArgumentException("Turn input is of invalid type");

            string mark = State.CurrentPlayerIndex == 0 ? "X" : "O";
            int index = 3 * input.X + input.Y;
            State.Map[index] = mark;
            

            State.IsGameOver =
                (State.Map[0] == mark && State.Map[1] == mark && State.Map[2] == mark) ||
                (State.Map[3] == mark && State.Map[4] == mark && State.Map[5] == mark) ||
                (State.Map[6] == mark && State.Map[7] == mark && State.Map[8] == mark) ||
                (State.Map[0] == mark && State.Map[3] == mark && State.Map[6] == mark) ||
                (State.Map[1] == mark && State.Map[4] == mark && State.Map[7] == mark) ||
                (State.Map[2] == mark && State.Map[5] == mark && State.Map[8] == mark) ||
                (State.Map[0] == mark && State.Map[4] == mark && State.Map[8] == mark) ||
                (State.Map[2] == mark && State.Map[4] == mark && State.Map[6] == mark);

            if (State.IsGameOver)
                State.Winner = player;

            State.IsGameOver = State.IsGameOver || IsFullBoard();
        }

        private bool IsFullBoard() =>
            State.Map.All(x => x != null);

        //public override void Load(string savedGame)
        //{
        //    GameState gameState = JsonConvert.DeserializeObject<GameState>(savedGame);
        //    _state = gameState;
        //}

        public class TurnInput : ITurnInput
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        [Serializable]
        public class GameState : AMultiPlayerGameState
        {
            [JsonProperty("map")]
            public string[] Map { get; set; } = new string[9];
        }
    }
}
