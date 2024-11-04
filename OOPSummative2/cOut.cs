using System;
using System.IO;
using System.Linq;
using System.Security.Policy;
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

            foreach (RescueItem item in session.itemsToCheckout)
            {
                receiptGrid.Rows.Add(new string[] { item.itemName, item.currentItemCount.ToString(), item.itemPrice.ToString() });
            }

            UpdateSubtotal();
            taxTxt.Text = "0.00";
            totalTxt.Text = "0.00";
            cashTxt.Text = "0.00";
            changeTxt.Text = "0.00";
            discTxt.Text = "0.00";
           
            
        }

        private void UpdateSubtotal()
        {
            decimal subtotal = session.itemsToCheckout.Sum(item => item.itemPrice * item.currentItemCount);
            if (subtotal == 0)
            {
                subTxt.Text = "0.00";
            }
            else { subTxt.Text = subtotal.ToString(); }
                
        }

        private void totalTxt_TextChanged(object sender, EventArgs e) {
            
        }
        
        private void subTxt_TextChanged(object sender, EventArgs e) { 
        
        }


        private void totalBtn_Click(object sender, EventArgs e)
        {

        }
    

        private void delBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = receiptGrid.CurrentCell.RowIndex;
            string selectedItemName = receiptGrid.Rows[selectedRow].Cells[0].Value.ToString();
            RescueItem item = session.itemsToCheckout.First(x => x.itemName.Equals(selectedItemName));
            session.itemsToCheckout.Remove(item);
            refreshDataGrid();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        { 
            taxTxt.Text = "0.00";
            cashTxt.Text = "0.00";
            totalTxt.Text = "0.00";
            discTxt.Text = "0.00";  
            changeTxt.Text = "0.00";
            receiptTxt.Text = "";
            session.resetSession();
            refreshDataGrid();
        }



        private void panel1_Paint(object sender, PaintEventArgs e){ }
        private void cashTxt_TextChanged(object sender, EventArgs e) { }
        private void taxTxt_TextChanged(object sender, EventArgs e) { }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            

            string directoryPath = @"C:\Users\Keian\Documents\AFC RECEIPTS";
            string fileName = $"Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.txt"; 
            string filePath = Path.Combine(directoryPath, fileName);

            
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            
            File.WriteAllText(filePath, receiptTxt.Text);
            MessageBox.Show("Transaction Done!");
            //print receipt then go back to itemstab siguro?
            reset();
            Refresh();

        }

        public void bill(){

            receiptTxt.Text += "\n-----------------------------------------------------------------------------\n";
            receiptTxt.Text += "\n\t            AFC RESCUE TRADERS";
            receiptTxt.Text += "\n\t         Jefferson St., Samantha Homes";
            receiptTxt.Text += "\n\t            Matina Pangi, Davao City";
            receiptTxt.Text += "\n\t        AFC Rescue Traders@gmail.com";
            receiptTxt.Text += "\n\t                     0912-373-3353\n";
            receiptTxt.Text += "\n-----------------------------------------------------------------------------\n";
            receiptTxt.Text += "  Item \t\t\t\t\t\tQTY\t Price";
            receiptTxt.Text += "\n----------------------------------------------------------------------------\n";
            foreach (RescueItem item in session.itemsToCheckout)
            {
                receiptTxt.Text += "    " + item.itemName + "\t\t\t" + item.currentItemCount.ToString() + "\t " + item.itemPrice.ToString() + "\n";
            }
            receiptTxt.Text += "\n======================================================\n";
            receiptTxt.Text += "\n";
            UpdateSubtotal();
            receiptTxt.Text += "\t   Subtotal\t\t\t\t₱" + subTxt.Text + "\n";
            decimal tax = Convert.ToDecimal(taxTxt.Text);
            receiptTxt.Text += "\t   Tax\t\t\t\t\t₱" + tax.ToString("N2") + "\n";
            decimal discount = Convert.ToDecimal(discTxt.Text);
            if (discount > 0) { receiptTxt.Text += "Discount\t\t\t\t₱" + discount.ToString("N2") + "\n"; }
            receiptTxt.Text += "\n";
            decimal subtotal = session.itemsToCheckout.Sum(item => item.itemPrice * item.currentItemCount);
            decimal taxedAmount = subtotal + tax;
            decimal total;
            if (discount > 0){total = taxedAmount * discount;}
            else { total = taxedAmount; }
            receiptTxt.Text += "\t   Total\t:\t\t\t₱" + total.ToString("N2") + "\n";
            decimal cash = Convert.ToDecimal(cashTxt.Text);
            receiptTxt.Text += "\t   Cash\t:\t\t\t\t₱" + cash.ToString("N2") + "\n";
            decimal change = cash - total;
            receiptTxt.Text += "\t   Change\t:\t\t\t₱" + change.ToString("N2") + "\n";
            receiptTxt.Text += "\n";
            receiptTxt.Text += "\n======================================================\n";
            receiptTxt.Text += $"\t       Date : {DateTime.Now:dd-MM-yyyy}  Time : {DateTime.Now:HH:mm:ss}";
            receiptTxt.Text += "\n======================================================\n";
            receiptTxt.Text += "\t          Thank you for your patronage!";
            receiptTxt.Text += "\n======================================================\n";
            receiptTxt.Text += "\t\t     Sofware by OOPWorld\n\t\tContact: oopworld@gmail.com";



        }
        private void receiptTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalBtn_Click_1(object sender, EventArgs e)
        {
            decimal tax = Convert.ToDecimal(taxTxt.Text);
            decimal subtotal = session.itemsToCheckout.Sum(item => item.itemPrice * item.currentItemCount);
            decimal taxed = subtotal + tax;
            decimal total;
            decimal semitotal;
            decimal discount = Convert.ToDecimal(discTxt.Text);

            if (discount > 0)
            {
                semitotal = taxed * discount;
                total = taxed -semitotal;
            }
            else
            {
                total = taxed;
            }

            decimal cash = Convert.ToDecimal(cashTxt.Text);

            totalTxt.Text = "₱" + total.ToString("N2");

            if (cash > 0)
            {
                decimal change = cash - total;
                changeTxt.Text = change.ToString("N2");
                bill();
            }

            
            

        }
    }
}
 