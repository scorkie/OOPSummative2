using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSummative2
{
    public partial class firstAid : Form
    {
        public firstAid()
        {
            InitializeComponent();
        }

        private void bndgPlus_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Plus 1");
        }

        private void bndgMinus_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Minus 1");
        }
    }
}
