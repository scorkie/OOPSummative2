namespace OOPSummative2
{
    partial class Form1
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.invBtn = new System.Windows.Forms.Button();
            this.chkBtn = new System.Windows.Forms.Button();
            this.snrBtn = new System.Windows.Forms.Button();
            this.ratBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kitBtn = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panelHeader.Controls.Add(this.invBtn);
            this.panelHeader.Controls.Add(this.chkBtn);
            this.panelHeader.Controls.Add(this.snrBtn);
            this.panelHeader.Controls.Add(this.ratBtn);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.kitBtn);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1348, 59);
            this.panelHeader.TabIndex = 0;
            // 
            // invBtn
            // 
            this.invBtn.Location = new System.Drawing.Point(1242, 22);
            this.invBtn.Name = "invBtn";
            this.invBtn.Size = new System.Drawing.Size(75, 23);
            this.invBtn.TabIndex = 6;
            this.invBtn.Text = "Inventory";
            this.invBtn.UseVisualStyleBackColor = true;
            this.invBtn.Click += new System.EventHandler(this.invBtn_Click);
            // 
            // chkBtn
            // 
            this.chkBtn.Location = new System.Drawing.Point(648, 22);
            this.chkBtn.Name = "chkBtn";
            this.chkBtn.Size = new System.Drawing.Size(75, 23);
            this.chkBtn.TabIndex = 5;
            this.chkBtn.Text = "Checkout";
            this.chkBtn.UseVisualStyleBackColor = true;
            this.chkBtn.Click += new System.EventHandler(this.chkBtn_Click);
            // 
            // snrBtn
            // 
            this.snrBtn.Location = new System.Drawing.Point(514, 22);
            this.snrBtn.Name = "snrBtn";
            this.snrBtn.Size = new System.Drawing.Size(121, 23);
            this.snrBtn.TabIndex = 4;
            this.snrBtn.Text = "Search and Rescue";
            this.snrBtn.UseVisualStyleBackColor = true;
            this.snrBtn.Click += new System.EventHandler(this.snrBtn_Click);
            // 
            // ratBtn
            // 
            this.ratBtn.Location = new System.Drawing.Point(429, 22);
            this.ratBtn.Name = "ratBtn";
            this.ratBtn.Size = new System.Drawing.Size(75, 23);
            this.ratBtn.TabIndex = 3;
            this.ratBtn.Text = "Rations";
            this.ratBtn.UseVisualStyleBackColor = true;
            this.ratBtn.Click += new System.EventHandler(this.ratBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "AFC Rescue Traders";
            // 
            // kitBtn
            // 
            this.kitBtn.Location = new System.Drawing.Point(341, 22);
            this.kitBtn.Name = "kitBtn";
            this.kitBtn.Size = new System.Drawing.Size(75, 23);
            this.kitBtn.TabIndex = 1;
            this.kitBtn.Text = "First Aid Kit";
            this.kitBtn.UseVisualStyleBackColor = true;
            this.kitBtn.Click += new System.EventHandler(this.kitBtn_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 59);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1348, 746);
            this.mainpanel.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOPSummative2.Properties.Resources.Logo1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 805);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelHeader);
            this.MaximumSize = new System.Drawing.Size(1364, 844);
            this.MinimumSize = new System.Drawing.Size(1364, 844);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kitBtn;
        private System.Windows.Forms.Button invBtn;
        private System.Windows.Forms.Button chkBtn;
        private System.Windows.Forms.Button snrBtn;
        private System.Windows.Forms.Button ratBtn;
        private System.Windows.Forms.Panel mainpanel;
    }
}

