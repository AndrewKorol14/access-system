namespace access_system
{
    partial class VisitingLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitingLogForm));
            this.visitingLogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // visitingLogLabel
            // 
            this.visitingLogLabel.AutoSize = true;
            this.visitingLogLabel.Location = new System.Drawing.Point(175, 104);
            this.visitingLogLabel.Name = "visitingLogLabel";
            this.visitingLogLabel.Size = new System.Drawing.Size(0, 13);
            this.visitingLogLabel.TabIndex = 0;
            // 
            // VisitingLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.visitingLogLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisitingLogForm";
            this.Text = "Visiting Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisitingLogForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label visitingLogLabel;
    }
}