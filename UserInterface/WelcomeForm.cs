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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm(string title, string howTo, Action startAction)
        {
            InitializeComponent();
            Title.Text = title;
            HowTo.Click += (sender, args) => MessageBox.Show(howTo);
            Start.Click += (sender, args) => startAction();
            Invalidate();
        }
    }
}
