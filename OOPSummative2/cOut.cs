using System;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
           
            bill();
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
            taxTxt.Text = "0.00";
            cashTxt.Text = "0.00";
            totalTxt.Text = "0.00";
            discTxt.Text = "0.00";  
            changeTxt.Text = "0.00";
            
        }



        private void panel1_Paint(object sender, PaintEventArgs e){ }
        private void cashTxt_TextChanged(object sender, EventArgs e) { }
        private void taxTxt_TextChanged(object sender, EventArgs e) { }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            bill(); 

            string filePath = @"C:\Users\ANYA\Documents\AFC RECEIPTS";

            File.WriteAllText(filePath, receiptTxt.Text);
            Console.WriteLine("Receipt saved to " + filePath);
        }
        public void bill(){

            receiptTxt.Text = "Hello world"; 

            receiptTxt.Text = "--------------------------------------------------------------------------------------------------------------------------------\n";
            receiptTxt.Text = "\t\t\tAFC RESCUE TRADERS\n\t\tJefferson St., Samantha Homes\n\t\tMatina Pangi, Davao City\n\t\t\tAFC Rescue Traders@gmail.com\n0912-373-3353\n";
            receiptTxt.Text = "----------------------------------------------------------------------------------------------------------------------------------\n";
            receiptTxt.Text += "\nItem\t\tQTY\tPrice\n";


            foreach (RescueItem item in session.itemsToCheckout)
            {
                receiptTxt.Text += item.itemName + "\t" + item.currentItemCount.ToString() + "\t" + item.itemPrice.ToString() + "\n";

            }
            receiptTxt.Text += "\n";
            UpdateSubtotal();
            receiptTxt.Text += "Subtotal\t\t\t\t₱" + subTxt.Text + "\n";
            decimal tax = Convert.ToDecimal(taxTxt.Text);
            receiptTxt.Text += "Tax\t\t\t\t₱" + tax.ToString("N2") + "\n";
            decimal discount = Convert.ToDecimal(discTxt.Text);
            if (discount > 0) { receiptTxt.Text += "Discount\t\t\t\t₱" + discount.ToString("N2") + "\n"; }
            receiptTxt.Text += "\n";
            decimal subtotal = session.itemsToCheckout.Sum(item => item.itemPrice * item.currentItemCount);
            decimal taxedAmount = subtotal + tax;
            decimal total;
            if (discount > 0){total = taxedAmount * discount;}
            else { total = taxedAmount; }
            receiptTxt.Text += "Total\t:\t\t\t₱" + total.ToString("N2") + "\n";
            decimal cash = Convert.ToDecimal(cashTxt.Text);
            receiptTxt.Text += "Cash\t:\t\t\t₱" + cash.ToString("N2") + "\n";
            decimal change = cash - total;
            receiptTxt.Text += "Change\t:\t\t\t₱" + change.ToString("N2") + "\n";
            receiptTxt.Text += "\n";

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
            decimal discount = Convert.ToDecimal(discTxt.Text);

            if (discount > 0)
            {
                total = taxed * discount;
            }
            else
            {
                total = taxed;
            }

            decimal cash = Convert.ToDecimal(cashTxt.Text);

            totalTxt.Text = "₱" + total.ToString("N2");

            decimal change = cash - total;
            changeTxt.Text = change.ToString("N2");
           
        }
    }
}
 