namespace access_system
{
    partial class ElectronicPassesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectronicPassesForm));
            this.electronicPassesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // electronicPassesLabel
            // 
            this.electronicPassesLabel.AutoSize = true;
            this.electronicPassesLabel.Location = new System.Drawing.Point(253, 104);
            this.electronicPassesLabel.Name = "electronicPassesLabel";
            this.electronicPassesLabel.Size = new System.Drawing.Size(35, 13);
            this.electronicPassesLabel.TabIndex = 0;
            this.electronicPassesLabel.Text = "label1";
            // 
            // ElectronicPassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this.electronicPassesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElectronicPassesForm";
            this.Text = "Electronic Passes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElectronicPassesForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label electronicPassesLabel;
    }
}