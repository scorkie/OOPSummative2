using System;
using System.Windows.Forms;

namespace OOPSummative2
{
    public partial class Form1 : Form
    {
        private Session connection;

        public Form1()
        {
            InitializeComponent();
            //connection = new Session("MSI\\SQLEXPRESS", "RescueDB");
            connection = new Session("DESKTOP-3CSMR83", "RescueDB");
            // Load firstaid as default
            loadform(new itemsTab(connection, RescueItemType.FIRSTAID));
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
            loadform(new itemsTab(connection, RescueItemType.FIRSTAID));
        }

        private void ratBtn_Click(object sender, EventArgs e)
        {
            loadform(new itemsTab(connection, RescueItemType.RATIONS));
        }

        private void snrBtn_Click(object sender, EventArgs e)
        {
            loadform(new itemsTab(connection, RescueItemType.SEARCHANDRESCUE));
        }

        private void chkBtn_Click(object sender, EventArgs e)
        {
            loadform(new cOut(connection));
        }

        private void invBtn_Click(object sender, EventArgs e)
        {
            loadform(new inventoryTab(connection));
        }
    }
}
