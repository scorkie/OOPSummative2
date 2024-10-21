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
    public partial class cOut : Form
    {
        private Session session;

        public cOut(Session session)
        {
            InitializeComponent();
            this.session = session;
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            receiptGrid.Rows.Clear();

            foreach(RescueItem item in session.itemsToCheckout)
            {
                receiptGrid.Rows.Add(new string[] {item.itemName, item.currentItemCount.ToString(), item.itemPrice.ToString()});
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = receiptGrid.CurrentCell.RowIndex;
            string selectedItemName = receiptGrid.Rows[selectedRow].Cells[0].Value.ToString();
            RescueItem item = session.itemsToCheckout.First(x => x.itemName.Equals(selectedItemName));
            session.itemsToCheckout.Remove(item);
            refreshDataGrid();
        }
    }
}
