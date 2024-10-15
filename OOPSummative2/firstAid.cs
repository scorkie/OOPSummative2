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
    public partial class firstAid : Form
    {
        public firstAid()
        {
            InitializeComponent();

            int baseX = 100;
            int baseY = 14;

            itemToPanel(baseX, baseY);

            for (int i = 0; i < 3; i++)
            {
                int locX = baseX + 271 * (i + 1);
                int locY = 14;
                itemToPanel(locX, locY);
            }
            
        }

        private void itemToPanel(int x, int y)
        {
            Panel background = new Panel();
            PictureBox itemPictureBox = new PictureBox();
            Label priceLabel = new Label();
            Label titleLabel = new Label();
            TextBox itemCount = new TextBox();
            PictureBox itemPlus = new PictureBox();
            PictureBox itemMinus = new PictureBox();
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
            priceLabel.Text = "₱225";
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
            titleLabel.Text = "Bandage (5 pcs)";

            // 
            // itemPictureBox
            // 
            itemPictureBox.Image = global::OOPSummative2.Properties.Resources.bandage;
            itemPictureBox.Location = new Point(17, 16);
            itemPictureBox.Margin = new Padding(4, 4, 4, 4);
            itemPictureBox.Name = "itemPictureBox";
            itemPictureBox.Size = new Size(205, 197);
            itemPictureBox.TabIndex = 0;
            itemPictureBox.TabStop = false;


            ((ISupportInitialize)(itemMinus)).EndInit();
            ((ISupportInitialize)(itemPlus)).EndInit();
            ((ISupportInitialize)(itemPictureBox)).EndInit();

            itemPictureBox.BringToFront();
            background.BringToFront();

            Controls.Add(background);
            pictureBox1.SendToBack();
        }

        private void bndgPlus_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Plus 1");
        }

        private void bndgMinus_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Minus 1");
        }
    }
}
