namespace access_system
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.newBuildingButton = new System.Windows.Forms.Button();
            this.openBuildingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newBuildingButton
            // 
            this.newBuildingButton.BackColor = System.Drawing.Color.DarkOrange;
            this.newBuildingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newBuildingButton.ForeColor = System.Drawing.Color.Black;
            this.newBuildingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBuildingButton.Location = new System.Drawing.Point(156, 167);
            this.newBuildingButton.Name = "newBuildingButton";
            this.newBuildingButton.Size = new System.Drawing.Size(122, 58);
            this.newBuildingButton.TabIndex = 1;
            this.newBuildingButton.Text = "New building";
            this.newBuildingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newBuildingButton.UseVisualStyleBackColor = false;
            this.newBuildingButton.Click += new System.EventHandler(this.newBuildingButton_Click);
            // 
            // openBuildingButton
            // 
            this.openBuildingButton.BackColor = System.Drawing.Color.DarkOrange;
            this.openBuildingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.openBuildingButton.ForeColor = System.Drawing.Color.Black;
            this.openBuildingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openBuildingButton.Location = new System.Drawing.Point(440, 167);
            this.openBuildingButton.Name = "openBuildingButton";
            this.openBuildingButton.Size = new System.Drawing.Size(132, 58);
            this.openBuildingButton.TabIndex = 2;
            this.openBuildingButton.Text = "Open building";
            this.openBuildingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openBuildingButton.UseVisualStyleBackColor = false;
            this.openBuildingButton.Click += new System.EventHandler(this.openBuildingButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(694, 421);
            this.Controls.Add(this.openBuildingButton);
            this.Controls.Add(this.newBuildingButton);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "Access system v1.0.0";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newBuildingButton;
        private System.Windows.Forms.Button openBuildingButton;
    }
}

