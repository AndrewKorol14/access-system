using System;
using System.Windows.Forms;

namespace access_system
{
    public partial class EmulateEntranceForm : Form
    {
        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;

        public SecurityPostForm spf;

        public EmulateEntranceForm(SecurityPostForm spf)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximizeBox = false;

            this.spf = spf;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            spf.Show();
            Hide();
        }

        private void allFields_Filled(object sender, EventArgs e)
        {
            if(floorNumberTextBox.Text != String.Empty && roomNumberTextBox.Text != String.Empty && electronicPassComboBox.Text != String.Empty)
            {
                emulateButton.Enabled = true;
            }
            else
            {
                emulateButton.Enabled = false;
            }
        }

        private void EmulateEntranceForm_Load(object sender, EventArgs e)
        {
            emulateButton.Enabled = false;
        }

        private void EmulateEntranceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            spf.Show();
        }
    }
}
