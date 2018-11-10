namespace access_system
{
    partial class SingleRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Floor number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(277, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "__";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "__";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(277, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(277, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Access mode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(285, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Room type:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(285, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Special ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(421, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 26);
            this.comboBox2.TabIndex = 15;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Black;
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Security",
            "Administration",
            "Teacher",
            "Student",
            "Staff"});
            this.checkedListBox1.Location = new System.Drawing.Point(421, 244);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(121, 80);
            this.checkedListBox1.TabIndex = 16;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.Color.Black;
            this.checkedListBox2.ForeColor = System.Drawing.Color.White;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "123456",
            "789015",
            "154631",
            "626623",
            "689899"});
            this.checkedListBox2.Location = new System.Drawing.Point(421, 348);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(143, 61);
            this.checkedListBox2.TabIndex = 17;
            // 
            // SingleRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(743, 442);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleRoom";
            this.Text = "Room #";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}