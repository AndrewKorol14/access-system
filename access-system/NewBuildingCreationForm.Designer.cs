namespace access_system
{
    partial class NewBuildingCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBuildingCreationForm));
            this.floorNumberTextBox = new System.Windows.Forms.TextBox();
            this.enterDataMessageLabel = new System.Windows.Forms.Label();
            this.floorNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // floorNumberTextBox
            // 
            this.floorNumberTextBox.BackColor = System.Drawing.Color.Silver;
            this.floorNumberTextBox.Location = new System.Drawing.Point(388, 131);
            this.floorNumberTextBox.Name = "floorNumberTextBox";
            this.floorNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.floorNumberTextBox.TabIndex = 0;
            this.floorNumberTextBox.TextChanged += new System.EventHandler(this.floorNumberTextBox_TextChanged);
            // 
            // enterDataMessageLabel
            // 
            this.enterDataMessageLabel.AutoSize = true;
            this.enterDataMessageLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterDataMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterDataMessageLabel.ForeColor = System.Drawing.Color.Black;
            this.enterDataMessageLabel.Location = new System.Drawing.Point(57, 42);
            this.enterDataMessageLabel.Name = "enterDataMessageLabel";
            this.enterDataMessageLabel.Size = new System.Drawing.Size(384, 18);
            this.enterDataMessageLabel.TabIndex = 1;
            this.enterDataMessageLabel.Text = "Enter the number of floors and rooms on the floor";
            // 
            // floorNumberLabel
            // 
            this.floorNumberLabel.AutoSize = true;
            this.floorNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.floorNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.floorNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.floorNumberLabel.Location = new System.Drawing.Point(161, 132);
            this.floorNumberLabel.Name = "floorNumberLabel";
            this.floorNumberLabel.Size = new System.Drawing.Size(101, 15);
            this.floorNumberLabel.TabIndex = 2;
            this.floorNumberLabel.Text = "Number of floors:";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.roomNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.roomNumberLabel.Location = new System.Drawing.Point(118, 220);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(170, 15);
            this.roomNumberLabel.TabIndex = 3;
            this.roomNumberLabel.Text = "Number of rooms on the floor:";
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.BackColor = System.Drawing.Color.Silver;
            this.roomNumberTextBox.Location = new System.Drawing.Point(388, 216);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomNumberTextBox.TabIndex = 4;
            this.roomNumberTextBox.TextChanged += new System.EventHandler(this.roomNumberTextBox_TextChanged);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.DarkOrange;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.createButton.ForeColor = System.Drawing.Color.Black;
            this.createButton.Location = new System.Drawing.Point(279, 309);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(138, 35);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            this.createButton.Enter += new System.EventHandler(this.createButton_Click);
            // 
            // NewBuildingCreationForm
            // 
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(694, 423);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.floorNumberLabel);
            this.Controls.Add(this.enterDataMessageLabel);
            this.Controls.Add(this.floorNumberTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewBuildingCreationForm";
            this.Text = "Create new bulding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox floorNumberTextBox;
        private System.Windows.Forms.Label enterDataMessageLabel;
        private System.Windows.Forms.Label floorNumberLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.Button createButton;
    }
}