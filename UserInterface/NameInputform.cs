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
    public partial class NameInputform : Form
    {
        public bool HasPressedOk { get; private set; } = false;
        bool IsMultiplayer;
        public string textboxinput2, textboxinput1;
        public NameInputform(bool enable)
        {
            InitializeComponent();
            textBox2.Visible = enable;
            textBox2.Invalidate();
            label2.Visible = enable;
            label2.Invalidate();
            IsMultiplayer = enable;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textboxinput2 = textBox2.Text;
           
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) ||
                (IsMultiplayer && string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Please enter names");
            }
            else
            {
                HasPressedOk = true;
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           textboxinput1 = textBox1.Text;
        }
    }
}
