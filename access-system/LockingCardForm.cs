using Services;
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
    public partial class LockingCardForm : Form
    {
        public BuildingService buildingService;

        public SecurityPostForm spf;

        public LockingCardForm(BuildingService buildingService, SecurityPostForm spf)
        {
            InitializeComponent();
            this.buildingService = buildingService;
            this.spf = spf;
        }

        private void LockingCardForm_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            spf.Show();
            Hide();
        }

        private void LockingCardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            spf.Show();
        }

        private void userComboBox_TextChanged(object sender, EventArgs e)
        {
            if (userComboBox.Text != String.Empty)
            {
                saveButton.Enabled = true;
                string[] separators = { ", " };
                var userFieldsArray = userComboBox.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                positionLabel.Text = userFieldsArray[1];
                var userNameArray = userFieldsArray[0].Split(' ');
                nameLabel.Text = userNameArray[0];
                surnameLabel.Text = userNameArray[1];
            }
            else
            {
                saveButton.Enabled = false;
            }
        }
    }
}
