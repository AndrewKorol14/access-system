namespace access_system
{
    partial class SecurityPostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityPostForm));
            this.createCardButton = new System.Windows.Forms.Button();
            this.emulateEntranceButton = new System.Windows.Forms.Button();
            this.lockCardButton = new System.Windows.Forms.Button();
            this.showLogButton = new System.Windows.Forms.Button();
            this.showPassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createCardButton
            // 
            this.createCardButton.BackColor = System.Drawing.Color.DarkOrange;
            this.createCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.createCardButton.ForeColor = System.Drawing.Color.Black;
            this.createCardButton.Location = new System.Drawing.Point(266, 12);
            this.createCardButton.Name = "createCardButton";
            this.createCardButton.Size = new System.Drawing.Size(139, 38);
            this.createCardButton.TabIndex = 0;
            this.createCardButton.Text = "Create card";
            this.createCardButton.UseVisualStyleBackColor = false;
            this.createCardButton.Click += new System.EventHandler(this.createCardButton_Click);
            // 
            // emulateEntranceButton
            // 
            this.emulateEntranceButton.BackColor = System.Drawing.Color.DarkOrange;
            this.emulateEntranceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.emulateEntranceButton.ForeColor = System.Drawing.Color.Black;
            this.emulateEntranceButton.Location = new System.Drawing.Point(265, 310);
            this.emulateEntranceButton.Name = "emulateEntranceButton";
            this.emulateEntranceButton.Size = new System.Drawing.Size(139, 37);
            this.emulateEntranceButton.TabIndex = 1;
            this.emulateEntranceButton.Text = "Emulate entrance";
            this.emulateEntranceButton.UseVisualStyleBackColor = false;
            this.emulateEntranceButton.Click += new System.EventHandler(this.emulateEntranceButton_Click);
            // 
            // lockCardButton
            // 
            this.lockCardButton.BackColor = System.Drawing.Color.DarkOrange;
            this.lockCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lockCardButton.ForeColor = System.Drawing.Color.Black;
            this.lockCardButton.Location = new System.Drawing.Point(266, 82);
            this.lockCardButton.Name = "lockCardButton";
            this.lockCardButton.Size = new System.Drawing.Size(138, 37);
            this.lockCardButton.TabIndex = 2;
            this.lockCardButton.Text = "Lock/Unlock card";
            this.lockCardButton.UseVisualStyleBackColor = false;
            this.lockCardButton.Click += new System.EventHandler(this.lockCardButton_Click);
            // 
            // showLogButton
            // 
            this.showLogButton.BackColor = System.Drawing.Color.DarkOrange;
            this.showLogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.showLogButton.ForeColor = System.Drawing.Color.Black;
            this.showLogButton.Location = new System.Drawing.Point(266, 159);
            this.showLogButton.Name = "showLogButton";
            this.showLogButton.Size = new System.Drawing.Size(138, 37);
            this.showLogButton.TabIndex = 3;
            this.showLogButton.Text = "Show visiting log";
            this.showLogButton.UseVisualStyleBackColor = false;
            this.showLogButton.Click += new System.EventHandler(this.showLogButton_Click);
            // 
            // showPassButton
            // 
            this.showPassButton.BackColor = System.Drawing.Color.DarkOrange;
            this.showPassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.showPassButton.ForeColor = System.Drawing.Color.Black;
            this.showPassButton.Location = new System.Drawing.Point(266, 242);
            this.showPassButton.Name = "showPassButton";
            this.showPassButton.Size = new System.Drawing.Size(138, 41);
            this.showPassButton.TabIndex = 4;
            this.showPassButton.Text = "Show all electronic pass";
            this.showPassButton.UseVisualStyleBackColor = false;
            this.showPassButton.Click += new System.EventHandler(this.showPassButton_Click);
            // 
            // SecurityPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 359);
            this.Controls.Add(this.showPassButton);
            this.Controls.Add(this.showLogButton);
            this.Controls.Add(this.lockCardButton);
            this.Controls.Add(this.emulateEntranceButton);
            this.Controls.Add(this.createCardButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecurityPostForm";
            this.Text = "Security post";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecurityPostForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createCardButton;
        private System.Windows.Forms.Button emulateEntranceButton;
        private System.Windows.Forms.Button lockCardButton;
        private System.Windows.Forms.Button showLogButton;
        private System.Windows.Forms.Button showPassButton;
    }
}