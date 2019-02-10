namespace access_system
{
    partial class CardCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardCreationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userSurnameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.userPositionComboBox = new System.Windows.Forms.ComboBox();
            this.passCodeTextBox = new System.Windows.Forms.TextBox();
            this.passCodeLabel = new System.Windows.Forms.Label();
            this.lockCheckBox = new System.Windows.Forms.CheckBox();
            this.lockLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(216, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(216, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "User surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(234, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(325, 59);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.userNameTextBox.TabIndex = 3;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.allField_Filled);
            // 
            // userSurnameTextBox
            // 
            this.userSurnameTextBox.Location = new System.Drawing.Point(325, 107);
            this.userSurnameTextBox.Name = "userSurnameTextBox";
            this.userSurnameTextBox.Size = new System.Drawing.Size(137, 20);
            this.userSurnameTextBox.TabIndex = 4;
            this.userSurnameTextBox.TextChanged += new System.EventHandler(this.allField_Filled);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(325, 199);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(137, 20);
            this.idTextBox.TabIndex = 5;
            this.idTextBox.TextChanged += new System.EventHandler(this.allField_Filled);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(267, 315);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 32);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(216, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "User position:";
            // 
            // userPositionComboBox
            // 
            this.userPositionComboBox.BackColor = System.Drawing.Color.White;
            this.userPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userPositionComboBox.FormattingEnabled = true;
            this.userPositionComboBox.Items.AddRange(new object[] {
            "Administration",
            "Security",
            "Staff",
            "Student",
            "Teacher"});
            this.userPositionComboBox.Location = new System.Drawing.Point(325, 150);
            this.userPositionComboBox.Name = "userPositionComboBox";
            this.userPositionComboBox.Size = new System.Drawing.Size(137, 21);
            this.userPositionComboBox.TabIndex = 10;
            this.userPositionComboBox.SelectedIndexChanged += new System.EventHandler(this.allField_Filled);
            // 
            // passCodeTextBox
            // 
            this.passCodeTextBox.Location = new System.Drawing.Point(325, 244);
            this.passCodeTextBox.Name = "passCodeTextBox";
            this.passCodeTextBox.Size = new System.Drawing.Size(137, 20);
            this.passCodeTextBox.TabIndex = 11;
            // 
            // passCodeLabel
            // 
            this.passCodeLabel.AutoSize = true;
            this.passCodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.passCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passCodeLabel.ForeColor = System.Drawing.Color.Black;
            this.passCodeLabel.Location = new System.Drawing.Point(220, 245);
            this.passCodeLabel.Name = "passCodeLabel";
            this.passCodeLabel.Size = new System.Drawing.Size(67, 15);
            this.passCodeLabel.TabIndex = 12;
            this.passCodeLabel.Text = "Pass code:";
            // 
            // lockCheckBox
            // 
            this.lockCheckBox.AutoSize = true;
            this.lockCheckBox.Location = new System.Drawing.Point(351, 286);
            this.lockCheckBox.Name = "lockCheckBox";
            this.lockCheckBox.Size = new System.Drawing.Size(15, 14);
            this.lockCheckBox.TabIndex = 13;
            this.lockCheckBox.UseVisualStyleBackColor = true;
            // 
            // lockLabel
            // 
            this.lockLabel.AutoSize = true;
            this.lockLabel.BackColor = System.Drawing.Color.Transparent;
            this.lockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lockLabel.ForeColor = System.Drawing.Color.Black;
            this.lockLabel.Location = new System.Drawing.Point(231, 286);
            this.lockLabel.Name = "lockLabel";
            this.lockLabel.Size = new System.Drawing.Size(53, 15);
            this.lockLabel.TabIndex = 14;
            this.lockLabel.Text = "Locking:";
            // 
            // CardCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 359);
            this.Controls.Add(this.lockLabel);
            this.Controls.Add(this.lockCheckBox);
            this.Controls.Add(this.passCodeLabel);
            this.Controls.Add(this.passCodeTextBox);
            this.Controls.Add(this.userPositionComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.userSurnameTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardCreationForm";
            this.Text = "Card creation ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CardCreationForm_FormClosing);
            this.Load += new System.EventHandler(this.CardCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox userSurnameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox userPositionComboBox;
        private System.Windows.Forms.TextBox passCodeTextBox;
        private System.Windows.Forms.Label passCodeLabel;
        private System.Windows.Forms.CheckBox lockCheckBox;
        private System.Windows.Forms.Label lockLabel;
    }
}