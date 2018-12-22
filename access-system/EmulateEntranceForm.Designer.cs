namespace access_system
{
    partial class EmulateEntranceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmulateEntranceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.floorNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.emulateButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.electronicPassComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose electronic pass:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(147, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter floor number:";
            // 
            // floorNumberTextBox
            // 
            this.floorNumberTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.floorNumberTextBox.Location = new System.Drawing.Point(345, 109);
            this.floorNumberTextBox.Name = "floorNumberTextBox";
            this.floorNumberTextBox.Size = new System.Drawing.Size(128, 20);
            this.floorNumberTextBox.TabIndex = 3;
            this.floorNumberTextBox.TextChanged += new System.EventHandler(this.allFields_Filled);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(147, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter room number:";
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.roomNumberTextBox.Location = new System.Drawing.Point(345, 178);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(128, 20);
            this.roomNumberTextBox.TabIndex = 5;
            this.roomNumberTextBox.TextChanged += new System.EventHandler(this.allFields_Filled);
            // 
            // emulateButton
            // 
            this.emulateButton.BackColor = System.Drawing.Color.DarkOrange;
            this.emulateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.emulateButton.ForeColor = System.Drawing.Color.Black;
            this.emulateButton.Location = new System.Drawing.Point(327, 256);
            this.emulateButton.Name = "emulateButton";
            this.emulateButton.Size = new System.Drawing.Size(146, 23);
            this.emulateButton.TabIndex = 7;
            this.emulateButton.Text = "Emulate";
            this.emulateButton.UseVisualStyleBackColor = false;
            this.emulateButton.Click += new System.EventHandler(this.emulateButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Salmon;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(494, 327);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 37);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // electronicPassComboBox
            // 
            this.electronicPassComboBox.BackColor = System.Drawing.Color.White;
            this.electronicPassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.electronicPassComboBox.FormattingEnabled = true;
            this.electronicPassComboBox.Location = new System.Drawing.Point(266, 59);
            this.electronicPassComboBox.Name = "electronicPassComboBox";
            this.electronicPassComboBox.Size = new System.Drawing.Size(299, 21);
            this.electronicPassComboBox.TabIndex = 11;
            // 
            // EmulateEntranceForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(694, 374);
            this.Controls.Add(this.electronicPassComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.emulateButton);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.floorNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmulateEntranceForm";
            this.Text = "Emulate entrance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmulateEntranceForm_FormClosing);
            this.Load += new System.EventHandler(this.EmulateEntranceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox floorNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.Button emulateButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox electronicPassComboBox;
    }
}