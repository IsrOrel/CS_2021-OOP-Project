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
    public delegate void IOActionEventHandler(string filePath);
    public partial class TicTacToeForm : Form
    {
        public delegate void InputReceivedEventHandler(int input);
        public event InputReceivedEventHandler OnInputReceived;
        public event IOActionEventHandler OnGameSave;
        public event IOActionEventHandler OnGameLoad;

        private bool _isGameOver = false;
        private bool _isX = true;
        private HashSet<int> _pressedButtons;
        public TicTacToeForm()
        {
            _pressedButtons = new HashSet<int>();
            InitializeComponent();
        }
       
        public void CallWinner(string playerName)
        {
            _isGameOver = true;

            string message = playerName == null ?
                "This game is TIE!" :
                $"Player {playerName} has won the game";

            MessageBox.Show(message);
        }

        private void ButtonClickEventHandler(object sender, EventArgs e)
        {
            if (_isGameOver)
                return;

            Button button = sender as Button;
            if (button == null)
                return;

            var selected = int.Parse(button.Tag.ToString());
            if (_pressedButtons.Contains(selected))
                return;

            button.Text = _isX ? "X" : "O";
            _isX = !_isX;

            _pressedButtons.Add(selected);
            button.Enabled = false;
            OnInputReceived?.Invoke(selected);
        }

        public void ReDraw(string[] map)
        {
            b0.Text = map[0];
            b1.Text = map[1];
            b2.Text = map[2];
            b3.Text = map[3];
            b4.Text = map[4];
            b5.Text = map[5];
            b6.Text = map[6];
            b7.Text = map[7];
            b8.Text = map[8];

            _pressedButtons = map
                .Select((sign, index) => sign != null ? index : (int?)null)
                .Where(num => num.HasValue)
                .Select(num => num.Value)
                .ToHashSet();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
