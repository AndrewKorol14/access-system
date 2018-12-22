using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace access_system
{
    public partial class ElectronicPassesForm : Form
    {
        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;
        private readonly int backButtonWidth = 100;
        private readonly int backButtonHeight = 30;

        public SecurityPostForm spf;

        private Button backButton;

        public ElectronicPassesForm(SecurityPostForm spf)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximizeBox = false;

            this.spf = spf;

            //electronicPassesLabel.Text = ;

            backButton = new Button();
            backButton.Width = backButtonWidth;
            backButton.Height = backButtonHeight;
            backButton.BackColor = Color.Salmon;
            backButton.Left = 500;
            backButton.Top = electronicPassesLabel.Top + electronicPassesLabel.Height + 50;
            backButton.Text = "Back";
            backButton.Click += backButton_Click;
            this.Controls.Add(backButton);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            spf.Show();
            Close();
        }

        private void ElectronicPassesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            spf.Show();
        }
    }
}
