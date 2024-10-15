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
        int buttonPresses = 0;

        public firstAid()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonPresses++;

            int locX = 100 * (buttonPresses + 1);
            int locY = 14 + (296 * (buttonPresses / 5));
            RescueItem item = new RescueItem();
            item.itemToPanel(this, locX, locY);
            pictureBox1.SendToBack();
        }
    }
}
