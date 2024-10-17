using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOPSummative2
{
    public partial class firstAid : Form
    {
        private Connection connection;
        private List<RescueItem> items;

        public firstAid(Connection connection)
        {
            InitializeComponent();
            this.connection = connection;
            items = connection.getCurrentItems(RescueItemType.FIRSTAID);

            int row = 0;
            int pos = 0;

            foreach (RescueItem item in items)
            {
                // base + ((size of rectangle + padding) * position)
                int locX = 80 + ((240+45)*pos);
                int locY = 50 + ((283+45)*row);
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
            //pictureBox1.SendToBack();
        }

    }
}
