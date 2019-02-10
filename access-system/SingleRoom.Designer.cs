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
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.accessModeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.specialIDCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.floorNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(247, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Floor number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room number:";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.roomNumberLabel.Location = new System.Drawing.Point(461, 79);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(0, 20);
            this.roomNumberLabel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(252, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(248, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Access mode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(262, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Room type:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(265, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Special ID:";
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "General",
            "Classroom",
            "Common Access",
            "Laboratory",
            "Lection Room",
            "Office",
            "Staff Only"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(391, 191);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.roomTypeComboBox.TabIndex = 15;
            // 
            // accessModeCheckedListBox
            // 
            this.accessModeCheckedListBox.BackColor = System.Drawing.Color.White;
            this.accessModeCheckedListBox.ForeColor = System.Drawing.Color.Black;
            this.accessModeCheckedListBox.FormattingEnabled = true;
            this.accessModeCheckedListBox.Items.AddRange(new object[] {
            "Security",
            "Administration",
            "Teacher",
            "Student",
            "Staff"});
            this.accessModeCheckedListBox.Location = new System.Drawing.Point(391, 245);
            this.accessModeCheckedListBox.Name = "accessModeCheckedListBox";
            this.accessModeCheckedListBox.Size = new System.Drawing.Size(121, 68);
            this.accessModeCheckedListBox.TabIndex = 16;
            // 
            // specialIDCheckedListBox
            // 
            this.specialIDCheckedListBox.BackColor = System.Drawing.Color.White;
            this.specialIDCheckedListBox.ForeColor = System.Drawing.Color.Black;
            this.specialIDCheckedListBox.FormattingEnabled = true;
            this.specialIDCheckedListBox.Items.AddRange(new object[] {
            "123456",
            "789015",
            "154631",
            "626623",
            "689899"});
            this.specialIDCheckedListBox.Location = new System.Drawing.Point(391, 344);
            this.specialIDCheckedListBox.Name = "specialIDCheckedListBox";
            this.specialIDCheckedListBox.Size = new System.Drawing.Size(143, 52);
            this.specialIDCheckedListBox.TabIndex = 17;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.Location = new System.Drawing.Point(391, 146);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(121, 21);
            this.roomNameTextBox.TabIndex = 18;
            // 
            // floorNumberLabel
            // 
            this.floorNumberLabel.AutoSize = true;
            this.floorNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.floorNumberLabel.Location = new System.Drawing.Point(388, 28);
            this.floorNumberLabel.Name = "floorNumberLabel";
            this.floorNumberLabel.Size = new System.Drawing.Size(41, 15);
            this.floorNumberLabel.TabIndex = 19;
            this.floorNumberLabel.Text = "label3";
            // 
            // roomNumberLabel2
            // 
            this.roomNumberLabel2.AutoSize = true;
            this.roomNumberLabel2.BackColor = System.Drawing.Color.Transparent;
            this.roomNumberLabel2.Location = new System.Drawing.Point(388, 84);
            this.roomNumberLabel2.Name = "roomNumberLabel2";
            this.roomNumberLabel2.Size = new System.Drawing.Size(24, 15);
            this.roomNumberLabel2.TabIndex = 20;
            this.roomNumberLabel2.Text = "lab";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(563, 28);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 32);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // SingleRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(743, 419);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.roomNumberLabel2);
            this.Controls.Add(this.floorNumberLabel);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.specialIDCheckedListBox);
            this.Controls.Add(this.accessModeCheckedListBox);
            this.Controls.Add(this.roomTypeComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleRoom";
            this.Text = "Room #";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleRoom_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
        private System.Windows.Forms.CheckedListBox accessModeCheckedListBox;
        private System.Windows.Forms.CheckedListBox specialIDCheckedListBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.Label floorNumberLabel;
        private System.Windows.Forms.Label roomNumberLabel2;
        private System.Windows.Forms.Button saveButton;
    }
}