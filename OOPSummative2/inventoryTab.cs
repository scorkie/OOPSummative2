using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPSummative2
{
    public partial class inventoryTab : Form
    {
        private Session session;
        private List<RescueItem> items;

        public inventoryTab(Session session)
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

            // set picturebox back
            pictureBox1.SendToBack();
        }

    }
}
