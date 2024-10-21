namespace OOPSummative2
{
    partial class cOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.receiptGrid = new System.Windows.Forms.DataGridView();
            this.itm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeTxt = new System.Windows.Forms.TextBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.cashTxt = new System.Windows.Forms.TextBox();
            this.discTxt = new System.Windows.Forms.TextBox();
            this.taxTxt = new System.Windows.Forms.TextBox();
            this.subTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.totalBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.receiptTxt = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.receiptGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptGrid
            // 
            this.receiptGrid.AllowUserToAddRows = false;
            this.receiptGrid.AllowUserToDeleteRows = false;
            this.receiptGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receiptGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itm,
            this.qty,
            this.price});
            this.receiptGrid.Location = new System.Drawing.Point(37, 15);
            this.receiptGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.receiptGrid.MultiSelect = false;
            this.receiptGrid.Name = "receiptGrid";
            this.receiptGrid.ReadOnly = true;
            this.receiptGrid.RowHeadersWidth = 51;
            this.receiptGrid.Size = new System.Drawing.Size(1108, 585);
            this.receiptGrid.TabIndex = 1;
            // 
            // itm
            // 
            this.itm.HeaderText = "Item Name";
            this.itm.MinimumWidth = 6;
            this.itm.Name = "itm";
            this.itm.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.changeTxt);
            this.panel1.Controls.Add(this.totalTxt);
            this.panel1.Controls.Add(this.cashTxt);
            this.panel1.Controls.Add(this.discTxt);
            this.panel1.Controls.Add(this.taxTxt);
            this.panel1.Controls.Add(this.subTxt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PrintBtn);
            this.panel1.Controls.Add(this.totalBtn);
            this.panel1.Controls.Add(this.clrBtn);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Location = new System.Drawing.Point(37, 623);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 258);
            this.panel1.TabIndex = 2;
            // 
            // changeTxt
            // 
            this.changeTxt.Location = new System.Drawing.Point(556, 170);
            this.changeTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeTxt.Name = "changeTxt";
            this.changeTxt.Size = new System.Drawing.Size(172, 22);
            this.changeTxt.TabIndex = 15;
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(556, 112);
            this.totalTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(172, 22);
            this.totalTxt.TabIndex = 14;
            // 
            // cashTxt
            // 
            this.cashTxt.Location = new System.Drawing.Point(556, 54);
            this.cashTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cashTxt.Name = "cashTxt";
            this.cashTxt.Size = new System.Drawing.Size(172, 22);
            this.cashTxt.TabIndex = 13;
            // 
            // discTxt
            // 
            this.discTxt.Location = new System.Drawing.Point(195, 170);
            this.discTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discTxt.Name = "discTxt";
            this.discTxt.Size = new System.Drawing.Size(175, 22);
            this.discTxt.TabIndex = 12;
            // 
            // taxTxt
            // 
            this.taxTxt.Location = new System.Drawing.Point(193, 112);
            this.taxTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taxTxt.Name = "taxTxt";
            this.taxTxt.Size = new System.Drawing.Size(175, 22);
            this.taxTxt.TabIndex = 11;
            // 
            // subTxt
            // 
            this.subTxt.Location = new System.Drawing.Point(193, 54);
            this.subTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subTxt.Name = "subTxt";
            this.subTxt.Size = new System.Drawing.Size(175, 22);
            this.subTxt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Change    :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total         :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cash        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discount  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tax            :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subtotal    :";
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.PrintBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.Location = new System.Drawing.Point(917, 139);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(157, 54);
            this.PrintBtn.TabIndex = 3;
            this.PrintBtn.Text = "PRINT";
            this.PrintBtn.UseVisualStyleBackColor = false;
            // 
            // totalBtn
            // 
            this.totalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.totalBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBtn.Location = new System.Drawing.Point(752, 138);
            this.totalBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalBtn.Name = "totalBtn";
            this.totalBtn.Size = new System.Drawing.Size(157, 54);
            this.totalBtn.TabIndex = 2;
            this.totalBtn.Text = "TOTAL";
            this.totalBtn.UseVisualStyleBackColor = false;
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(185)))), ((int)(((byte)(229)))));
            this.clrBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.ForeColor = System.Drawing.Color.White;
            this.clrBtn.Location = new System.Drawing.Point(913, 57);
            this.clrBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(157, 54);
            this.clrBtn.TabIndex = 1;
            this.clrBtn.Text = "CLEAR";
            this.clrBtn.UseVisualStyleBackColor = false;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.delBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Location = new System.Drawing.Point(748, 58);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(157, 54);
            this.delBtn.TabIndex = 0;
            this.delBtn.Text = "DELETE";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.panel2.Controls.Add(this.receiptTxt);
            this.panel2.Location = new System.Drawing.Point(1181, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 866);
            this.panel2.TabIndex = 3;
            // 
            // receiptTxt
            // 
            this.receiptTxt.Location = new System.Drawing.Point(24, 23);
            this.receiptTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.receiptTxt.Name = "receiptTxt";
            this.receiptTxt.Size = new System.Drawing.Size(525, 819);
            this.receiptTxt.TabIndex = 0;
            this.receiptTxt.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::OOPSummative2.Properties.Resources.backgroudn;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1793, 896);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 896);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.receiptGrid);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cOut";
            this.Text = "cOut";
            ((System.ComponentModel.ISupportInitialize)(this.receiptGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView receiptGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itm;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox receiptTxt;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button totalBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox changeTxt;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.TextBox cashTxt;
        private System.Windows.Forms.TextBox discTxt;
        private System.Windows.Forms.TextBox taxTxt;
        private System.Windows.Forms.TextBox subTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}