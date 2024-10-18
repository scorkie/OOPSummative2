using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OOPSummative2
{
    public partial class firstAid : Form
    {
        private PictureBox addFirstAid;

        private Session session;
        private List<RescueItem> items;

        public firstAid(Session session)
        {
            InitializeComponent();
            this.session = session;
            refreshItems();
            
        }

        private void refreshItems()
        {
            this.Controls.Clear();

            // get all items
            items = this.session.GetItems(RescueItemType.FIRSTAID);

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
            pictureBox1.SendToBack();
        }

        private void placeAddButton(int locX, int locY)
        {
            locX += 285;
            locY += 85;

            this.addFirstAid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addFirstAid)).BeginInit();

            // 
            // addFirstAid
            // 
            this.addFirstAid.Anchor = AnchorStyles.None;
            this.addFirstAid.Image = global::OOPSummative2.Properties.Resources.add;
            this.addFirstAid.Location = new Point(locX, locY);
            this.addFirstAid.Margin = new System.Windows.Forms.Padding(4);
            this.addFirstAid.Name = "addFirstAid";
            this.addFirstAid.Size = new System.Drawing.Size(107, 101);
            this.addFirstAid.SizeMode = PictureBoxSizeMode.StretchImage;
            this.addFirstAid.TabIndex = 10;
            this.addFirstAid.TabStop = false;
            addFirstAid.MouseClick += new MouseEventHandler(addFirstAid_MouseClick);

            ((System.ComponentModel.ISupportInitialize)(this.addFirstAid)).EndInit();

            this.Controls.Add(addFirstAid);
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
            RescueItemType itemType = RescueItemType.FIRSTAID;

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

    }
}
