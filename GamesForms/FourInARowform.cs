using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesForms
{
    public partial class FourInARowform : Form
    {
        public delegate void InputReceivedEventHandler(Point point);
        public event InputReceivedEventHandler OnInputReceived;
        public event IOActionEventHandler OnGameSave;
        public event IOActionEventHandler OnGameLoad;
        private bool _isgameover = false;
        private Color clr;
        public FourInARowform()
        {
            InitializeComponent();
        }
        public void ReDraw(string[,] map, string[] players, int currentPlayerIndex)
        {
            var playersColor = new Dictionary<string, Color>
            {
                [players[0]] = Color.Red,
                [players[1]] = Color.Blue
            };

            for(int i=0;i<6;i++)
            {
                FillColor(0, i, fourInARowColumn1);
                FillColor(1, i, fourInARowColumn2);
                FillColor(2, i, fourInARowColumn3);
                FillColor(3, i, fourInARowColumn4);
                FillColor(4, i, fourInARowColumn5);
                FillColor(5, i, fourInARowColumn6);
                FillColor(6, i, fourInARowColumn7);
            }

            clr = playersColor[players[currentPlayerIndex]];

            void FillColor(int col, int row, FourInARowColumn column)
            {
                var player = map[row, col];
                if (player != null)
                    column.FillColumn(playersColor[player]);
            }
        }

        public void CallWinner(string playerName)
        {
            string message = playerName == null ?
                "This game is TIE!" :
                $"Player {playerName} has won the game";
            _isgameover = true;
            MessageBox.Show(message);
        }

        private void Column_Click(object sender, EventArgs e)
        {
            if (_isgameover)
                return;
            var column = sender as FourInARowColumn;
            if (clr == Color.Red)
                clr = Color.Blue;
            else
                clr = Color.Red;
            var row = column.FillColumn(clr);
            if (row == null)
                return;
            
            Point selected=new Point();
            selected.X = row.Value;
            selected.Y = int.Parse(column.Tag.ToString());

            OnInputReceived?.Invoke(selected);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                OnGameSave?.Invoke(saveFileDialog.FileName);
            }

        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OnGameLoad?.Invoke(openFileDialog1.FileName);
            }
        }
    }
}
