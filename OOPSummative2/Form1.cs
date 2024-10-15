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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadform(new firstAid());
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls[0].Dispose();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void kitBtn_Click(object sender, EventArgs e)
        {
            loadform(new firstAid());
        }

        private void ratBtn_Click(object sender, EventArgs e)
        {
            loadform(new ration());
        }

        private void snrBtn_Click(object sender, EventArgs e)
        {
            loadform(new snRescue());
        }

        private void chkBtn_Click(object sender, EventArgs e)
        {
            loadform(new cOut());
        }

        private void invBtn_Click(object sender, EventArgs e)
        {
            loadform(new inv());
        }
    }
}
