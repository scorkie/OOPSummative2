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
        private Session connection;

        public Form1()
        {
            InitializeComponent();
            connection = new Session("MSI\\SQLEXPRESS", "RescueDB");
            loadform(new firstAid(connection));
        }
        public void loadform(Form form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls[0].Dispose();
            Form f = form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void kitBtn_Click(object sender, EventArgs e)
        {
            loadform(new firstAid(connection));
        }

        private void ratBtn_Click(object sender, EventArgs e)
        {
            loadform(new ration(connection));
        }

        private void snrBtn_Click(object sender, EventArgs e)
        {
            loadform(new snRescue(connection));
        }

        private void chkBtn_Click(object sender, EventArgs e)
        {
            loadform(new cOut(connection));
        }

        private void invBtn_Click(object sender, EventArgs e)
        {
            loadform(new inv(connection));
        }
    }
}
