using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace access_system
{
    public partial class EmulateEntranceForm : Form
    {
        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;
        
        public SecurityPostForm spf;

        public BuildingService bs;

        private List<int> passList;

        public EmulateEntranceForm(SecurityPostForm spf, BuildingService bs)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximizeBox = false;

            this.spf = spf;
            this.bs = bs;

            passList = bs.GetAllUserId();
            for(int i =0; i<passList.Count; i++)
            {
                electronicPassComboBox.Items.Add(passList[0]);
            }
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

        private void emulateButton_Click(object sender, EventArgs e)
        {
            bs.EmulateEntrance(Int32.Parse(electronicPassComboBox.Text), Int32.Parse(floorNumberTextBox.Text), Int32.Parse(roomNumberTextBox.Text));
            spf.Show();
            Hide();
        }
    }
}
