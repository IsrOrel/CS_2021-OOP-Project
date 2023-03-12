using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesForms
{
    public partial class FourInARowColumn : UserControl
    {
        public FourInARowColumn()
        {
            InitializeComponent();
        }

        public int? FillColumn(Color clr)
        {
            foreach(var control in this.Controls)
            {
                var btn = control as Button;
                if(btn.BackColor == Color.Transparent)
                {
                    btn.BackColor = clr;
                    return int.Parse(btn.Tag.ToString());
                }
            }

            return null;
        }

        private void FourInARowColumn_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
