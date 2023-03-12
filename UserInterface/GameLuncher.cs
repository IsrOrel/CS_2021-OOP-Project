using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class GameLuncher : Form
    {
        public GameLuncher()
        {
            InitializeComponent();
        }

        private void multiplayer_Click(object sender, EventArgs e)
        {
            NameInputform win2 = new NameInputform(true);
            win2.FormClosed += (sndr, args) =>
            {
                if (!((NameInputform)sndr).HasPressedOk)
                    return;

                var players = new string[] { win2.textboxinput1, win2.textboxinput2 };
                MultiPlayer multiplayerForm = new MultiPlayer(players);
                multiplayerForm.ShowDialog(this);
            };

            win2.ShowDialog(this);
        }

        private void singleplayer_Click(object sender, EventArgs e)
        {
            NameInputform win2 = new NameInputform(false);
            win2.FormClosed += (sndr, args) =>
            {
                if (!((NameInputform)sndr).HasPressedOk)
                    return;

                SinglePlayer singlePlayerForm = new SinglePlayer(win2.textboxinput1);
                singlePlayerForm.ShowDialog(this);
            };

            win2.ShowDialog(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
