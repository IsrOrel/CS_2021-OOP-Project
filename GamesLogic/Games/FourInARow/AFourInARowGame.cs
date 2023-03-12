using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesLogic.Games.FourInARow
{
    public abstract class AFourInARowGame : AMultiPlayerGame
    {
        protected GameState State => (GameState)_state;
        public override int GetMaxAllowedPlayers() => 2;

        public override void Init(string[] playersName)
        {
            _state = new GameState();
            base.Init(playersName);
        }

        private bool CheckRow(int row, int col)
        {
            if (State.Map[row, col] == null)
                return false;

            string sign = State.Map[row, col];
            for (int i = 1; i < 4; i++)
            {
                int effectiveColumn = col + i;
                if (effectiveColumn >= State.Map.GetLength(1) ||
                    State.Map[row, effectiveColumn] != sign)
                    return false;
            }

            return true;
        }

        private bool CheckColumn(int row, int col)
        {
            if (State.Map[row, col] == null)
                return false;

            string sign = State.Map[row,col];
            for (int i = 1; i < 4; i++)
            {
                int effectiveRow = row + i;
                if (effectiveRow >= State.Map.GetLength(0) ||
                    State.Map[effectiveRow, col] != sign)
                    return false;
            }

            return true;
        }

        private bool CheckDiagonal(int x, int y)
        {
            if (State.Map[x, y] == null)
                return false;

            string sign = State.Map[x, y];
            bool rightDiagonal = true;
            bool leftDiagonal = true;
            for (int i = 1; i < 4; i++)
            {
                int effectiveX = x + i;
                int effectiveY = y + i;
                if (effectiveY >= State.Map.GetLength(1) ||
                    effectiveX >= State.Map.GetLength(0) ||
                    State.Map[effectiveX, effectiveY] != sign)
                {
                    rightDiagonal = false;
                    break;
                }
            }

            for (int i = 1; i < 4; i++)
            {
                int effectiveX = x + i;
                int effectiveY = y - i;
                if (effectiveY < 0 ||
                    effectiveX >= State.Map.GetLength(0) ||
                    State.Map[effectiveX, effectiveY] != sign)
                {
                    leftDiagonal = false;
                    break;
                }
            }

            return leftDiagonal || rightDiagonal;
        }

        public bool CheckTie()
        {
            for(int i=0;i<6;i++)
            {
                for(int j=0; j<7; j++)
                {
                    if(State.Map[i,j]==null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        protected void PlayTurn(ITurnInput turnInput)
        {
            if (State.IsGameOver)
                return;
            string player = GetNextPlayer();

            AFourInARowGameTurnInput input = turnInput as AFourInARowGameTurnInput;
            if (input == null)
                throw new ArgumentException("Turn input is of invalid type");
            
            if (input.X - 1 >= 0 && State.Map[input.X - 1, input.Y] == null)
                throw new ArgumentException("row is not the lowest possible");

            if (State.Map[input.X, input.Y] != null)
                throw new ArgumentException("slot is taken");
                
            State.Map[input.X, input.Y] = player;

            State.IsGameOver = CheckHasWon();
            if (State.IsGameOver)
                State.Winner = player;
            State.IsGameOver = State.IsGameOver || CheckTie();
        }

        public bool CheckHasWon()
        {
            for(int y = 0; y < State.Map.GetLength(1); y++)
            {
                for (int x = 0; x < State.Map.GetLength(0); x++)
                {
                    if (CheckColumn(x, y) || CheckRow(x, y) || CheckDiagonal(x, y))
                        return true;
                }
            }

            return false;
        }

        //public override void Load(string savedGame)
        //{
        //    GameState gameState = JsonConvert.DeserializeObject<GameState>(savedGame);
        //    _state = gameState;
        //}
        public class AFourInARowGameTurnInput : ITurnInput
        {
            public int Y { get; set; }
            public int X { get; set; }
        }

        [Serializable]
        public class GameState : AMultiPlayerGameState
        {
            [JsonProperty("map")]
            public string[,] Map { get; set; } = new string[6, 7];
        }

    }
}


