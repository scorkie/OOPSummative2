using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OOPSummative2
{
    public enum RescueItemType
    {
        FIRSTAID,
        RATIONS,
        SEARCHANDRESCUE,
        DUMMY,
    }

    public class RescueItem
    {
        public string itemName { get; set; }
        public decimal itemPrice { get; set; }
        public int itemQuantity { get; set; }
        public int currentItemCount { get; set; } = 0;
        public Image itemThumbnail { get; set; }
        public RescueItemType itemType { get; } = RescueItemType.DUMMY;

        private Panel background = new Panel();
        private PictureBox itemPictureBox = new PictureBox();
        private Label priceLabel = new Label();
        private Label titleLabel = new Label();
        private TextBox itemCount = new TextBox();
        private PictureBox itemPlus = new PictureBox();
        private PictureBox itemMinus = new PictureBox();

        public RescueItem()
        {
            itemName = "Dummy Name";
            itemPrice = 500;
        }

        public RescueItem(string name, decimal price, int count, Image thumbnail, RescueItemType type)
        {
            itemName = name;
            itemPrice = price;
            itemQuantity = count;
            itemThumbnail = thumbnail;
            itemType = type;
        }

        public static RescueItemType stringToType(string input)
        {
            RescueItemType itemType = RescueItemType.DUMMY;
            switch (input)
            {
                case "FIRSTAID":
                    itemType = RescueItemType.FIRSTAID;
                    break;
                case "RATIONS":
                    itemType = RescueItemType.RATIONS;
                    break;
                case "SEARCHANDRESCUE":
                    itemType = RescueItemType.SEARCHANDRESCUE;
                    break;
                default:
                    itemType = RescueItemType.DUMMY;
                    break;
            }
            return itemType;
        } 

        private void bndgPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentItemCount+1 > itemQuantity) return;
            currentItemCount++;
            itemCount.Text = currentItemCount.ToString();
        }

        private void bndgMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentItemCount-1 < 0) return;
            currentItemCount--;
            itemCount.Text = currentItemCount.ToString();
        }

        public void itemToPanel(Control control, int x, int y)
        {   
            ((ISupportInitialize)(itemMinus)).BeginInit();
            ((ISupportInitialize)(itemPlus)).BeginInit();
            ((ISupportInitialize)(itemPictureBox)).BeginInit();

            // 
            // background
            // 
            background.BackColor = Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            background.Controls.Add(itemMinus);
            background.Controls.Add(itemPlus);
            background.Controls.Add(itemCount);
            background.Controls.Add(priceLabel);
            background.Controls.Add(titleLabel);
            background.Controls.Add(itemPictureBox);
            background.Location = new Point(x, y);
            background.Margin = new Padding(4, 4, 4, 4);
            background.Name = "background";
            background.Size = new System.Drawing.Size(240, 283);
            background.TabIndex = 3;
            // 
            // itemMinus
            // 
            itemMinus.Image = global::OOPSummative2.Properties.Resources._2;
            itemMinus.Location = new Point(139, 246);
            itemMinus.Margin = new Padding(4, 4, 4, 4);
            itemMinus.Name = "itemMinus";
            itemMinus.Size = new Size(21, 23);
            itemMinus.SizeMode = PictureBoxSizeMode.CenterImage;
            itemMinus.TabIndex = 5;
            itemMinus.TabStop = false;
            itemMinus.MouseClick += new MouseEventHandler(bndgMinus_MouseClick);
            // 
            // itemPlus
            // 
            itemPlus.Image = global::OOPSummative2.Properties.Resources._13;
            itemPlus.Location = new Point(197, 246);
            itemPlus.Margin = new Padding(4, 4, 4, 4);
            itemPlus.Name = "itemPlus";
            itemPlus.Size = new Size(21, 23);
            itemPlus.SizeMode = PictureBoxSizeMode.CenterImage;
            itemPlus.TabIndex = 4;
            itemPlus.TabStop = false;
            itemPlus.MouseClick += new MouseEventHandler(bndgPlus_MouseClick);
            // 
            // itemCount
            // 
            itemCount.Location = new Point(164, 245);
            itemCount.Margin = new Padding(4, 4, 4, 4);
            itemCount.Name = "itemCount";
            itemCount.Size = new Size(29, 22);
            itemCount.TabIndex = 3;
            itemCount.Text = "0";
            itemCount.TextAlign = HorizontalAlignment.Center;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new Point(17, 240);
            priceLabel.Margin = new Padding(4, 0, 4, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(42, 18);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "₱" + this.itemPrice.ToString();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new Point(15, 218);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(122, 18);
            titleLabel.TabIndex = 1;
            titleLabel.Text = this.itemName;

            // 
            // itemPictureBox
            // 
            itemPictureBox.Image = itemThumbnail;
            itemPictureBox.Location = new Point(17, 16);
            itemPictureBox.Margin = new Padding(4, 4, 4, 4);
            itemPictureBox.Name = "itemPictureBox";
            itemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            itemPictureBox.Size = new Size(205, 197);
            itemPictureBox.TabIndex = 0;
            itemPictureBox.TabStop = false;


            ((ISupportInitialize)(itemMinus)).EndInit();
            ((ISupportInitialize)(itemPlus)).EndInit();
            ((ISupportInitialize)(itemPictureBox)).EndInit();

            itemPictureBox.BringToFront();
            background.BringToFront();

            control.Controls.Add(background);
        }


    }
}
