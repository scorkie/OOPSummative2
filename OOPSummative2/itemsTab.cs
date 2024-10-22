using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPSummative2
{
    public partial class itemsTab : Form
    {
        private PictureBox addButton;

        private Session session;
        private List<RescueItem> items;
        private RescueItemType tabItemsType;

        public itemsTab(Session session, RescueItemType type)
        {
            InitializeComponent();
            this.session = session;
            this.tabItemsType = type;
            refreshItems();
            
        }

        private void refreshItems()
        {
            this.Controls.Clear();

            // get all items
            items = this.session.GetItems(tabItemsType);

            int row = 0;
            int pos = 0;
            int locX = 80;
            int locY = 50;

            foreach (RescueItem item in items)
            {
                locX = 80 + ((240 + 45) * pos);
                locY = 50 + ((283 + 45) * row);

                // base + ((size of rectangle + padding) * position)

                item.itemToPanel(this, locX, locY);

                // if position is on the third item, reset position back to 0 and increment the row for the next row of items
                if (pos == 3)
                {
                    pos = 0;
                    row++;
                }
                else
                    pos++;
            }

            placeAddButton(locX, locY);
            Controls.Add(pictureBox1);
            Controls.Add(addToCheckout);
            pictureBox1.SendToBack();
        }

        private void placeAddButton(int locX, int locY)
        {
            locX += 285;
            locY += 85;

            addButton = new PictureBox();
            ((ISupportInitialize)(addButton)).BeginInit();

            // 
            // addFirstAid
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Image = Properties.Resources.add;
            addButton.Location = new Point(locX, locY);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(107, 101);
            addButton.SizeMode = PictureBoxSizeMode.StretchImage;
            addButton.TabIndex = 10;
            addButton.TabStop = false;
            addButton.MouseClick += new MouseEventHandler(addFirstAid_MouseClick);

            ((ISupportInitialize)(addButton)).EndInit();

            Controls.Add(addButton);
        }

        private void addFirstAid_MouseClick(object sender, MouseEventArgs e)
        {
            string itemNameText = Interaction.InputBox("Input Item Name", "New Rescue Item", "Dummy Name");
            if (itemNameText.Length <= 0) return;
            string itemPriceText = Interaction.InputBox("Input Item Price", "New Rescue Item", "500.00");
            if (itemPriceText.Length <= 0) return;
            string itemQuantityText = Interaction.InputBox("Input Item Quantity", "New Rescue Item", "10");
            if (itemQuantityText.Length <= 0) return;

            string itemName = itemNameText.Trim();
            decimal itemPrice = Convert.ToDecimal(itemPriceText);
            int itemCount = Convert.ToInt32(itemQuantityText);
            Image itemImage = Properties.Resources.dummy;
            RescueItemType itemType = tabItemsType;

            // load thumbnail image
            OpenFileDialog thumbnailFileDialog = new OpenFileDialog();
            thumbnailFileDialog.Filter = "Picture files (*.png, *.jpg, *.jpeg)|*.png;*.jpg;*.jpeg";
            thumbnailFileDialog.FilterIndex = 0;
            thumbnailFileDialog.RestoreDirectory = true;
            thumbnailFileDialog.Title = "Select item thumbnail picture";

            if (thumbnailFileDialog.ShowDialog() == DialogResult.OK)
            {
                itemImage = Image.FromFile(thumbnailFileDialog.FileName);
            }

            session.AddItem(new RescueItem(itemName, itemPrice, itemCount, itemImage, itemType));
            refreshItems();
        }

        private void addToCheckout_Click(object sender, EventArgs e)
        {
            foreach (RescueItem item in items)
            {
                if (item.currentItemCount > 0)
                {
                    RescueItem foundItem = session.itemsToCheckout.FirstOrDefault(x => x.itemName == item.itemName);
                    if (foundItem == null) { session.itemsToCheckout.Add(item); }
                }
            }
            refreshItems();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
