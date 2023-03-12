using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GamesLogic.Games
{
    public abstract class AGame : IGame
    {
        protected AGameState _state;
 
        public abstract void Init(string[] playersName);
        public bool IsGameOver() => _state.IsGameOver;
        public abstract Dictionary<string, int> GetScores();
        public void Save(string filePath)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, _state);
            }
        }

        public virtual void Load(string filePath)
        {
            Stream stream = File.Open(filePath, FileMode.Open);
            var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            _state = (AGameState)binaryFormatter.Deserialize(stream);
        }
        public abstract int GetMaxAllowedPlayers();

        public abstract void StartGame();
    }
}
