namespace access_system
{
    partial class LockingCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockingCardForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.lockCheckBox = new System.Windows.Forms.CheckBox();
            this.lockLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(227, 99);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 17);
            this.nameLabel.TabIndex = 1;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.surnameLabel.ForeColor = System.Drawing.Color.Black;
            this.surnameLabel.Location = new System.Drawing.Point(423, 99);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(0, 17);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.BackColor = System.Drawing.Color.Transparent;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.positionLabel.ForeColor = System.Drawing.Color.Black;
            this.positionLabel.Location = new System.Drawing.Point(227, 155);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(0, 17);
            this.positionLabel.TabIndex = 3;
            // 
            // lockCheckBox
            // 
            this.lockCheckBox.AutoSize = true;
            this.lockCheckBox.Location = new System.Drawing.Point(366, 214);
            this.lockCheckBox.Name = "lockCheckBox";
            this.lockCheckBox.Size = new System.Drawing.Size(15, 14);
            this.lockCheckBox.TabIndex = 4;
            this.lockCheckBox.UseVisualStyleBackColor = true;
            // 
            // lockLabel
            // 
            this.lockLabel.AutoSize = true;
            this.lockLabel.BackColor = System.Drawing.Color.Transparent;
            this.lockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lockLabel.ForeColor = System.Drawing.Color.Black;
            this.lockLabel.Location = new System.Drawing.Point(208, 214);
            this.lockLabel.Name = "lockLabel";
            this.lockLabel.Size = new System.Drawing.Size(77, 15);
            this.lockLabel.TabIndex = 5;
            this.lockLabel.Text = "Lock/Unlock:";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(545, 310);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 37);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(319, 270);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 34);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // userComboBox
            // 
            this.userComboBox.BackColor = System.Drawing.Color.White;
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Items.AddRange(new object[] {
            "Ivan Ivanov, Student"});
            this.userComboBox.Location = new System.Drawing.Point(209, 39);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(299, 21);
            this.userComboBox.TabIndex = 12;
            this.userComboBox.TextChanged += new System.EventHandler(this.userComboBox_TextChanged);
            // 
            // LockingCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 359);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.lockLabel);
            this.Controls.Add(this.lockCheckBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LockingCardForm";
            this.Text = "Locking/Unlocking Card";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LockingCardForm_FormClosing);
            this.Load += new System.EventHandler(this.LockingCardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.CheckBox lockCheckBox;
        private System.Windows.Forms.Label lockLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox userComboBox;
    }
}