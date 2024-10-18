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
    public partial class inv : Form
    {
        private PictureBox addFirstAid;

        private Session session;
        private List<RescueItem> items;

        public inv(Session session)
        {
            InitializeComponent();
            this.session = session;
            // get all items
            items = this.session.GetItems();

            int row = 0;
            int pos = 0;
            int locX = 80;
            int locY = 50;

            foreach (RescueItem item in items)
            {
                // Skip dummy items
                if (item.itemType == RescueItemType.DUMMY) { continue; }
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

            // set picturebox back
            pictureBox1.SendToBack();
        }

        private void placeAddButton(int locX, int locY)
        {
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
            this.addFirstAid.TabIndex = 10;
            this.addFirstAid.TabStop = false;

            ((System.ComponentModel.ISupportInitialize)(this.addFirstAid)).EndInit();

            this.Controls.Add(addFirstAid);
        }

    }
}
