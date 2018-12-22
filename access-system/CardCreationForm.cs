using access_system.Enums;
using Services;
using System;
using System.Windows.Forms;

namespace access_system
{
    public partial class CardCreationForm : Form
    {
        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;

        private int userID;

        public BuildingService buildingService;

        public SecurityPostForm spf;

        public CardCreationForm(BuildingService buildingService, SecurityPostForm spf)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximizeBox = false;

            this.buildingService = buildingService;

            this.spf = spf;
        }

        private void allField_Filled(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != String.Empty && userSurnameTextBox.Text != String.Empty && idTextBox.Text != String.Empty && userPositionComboBox.Text != String.Empty)
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }

        private void CardCreationForm_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            userID = Int32.Parse(idTextBox.Text);
            switch (userPositionComboBox.Text)
            {
                case "Administration": buildingService.AddUserToSystem(userNameTextBox.Text, userSurnameTextBox.Text, userID, UserTypes.Administration); break;
                case "Security": buildingService.AddUserToSystem(userNameTextBox.Text, userSurnameTextBox.Text, userID, UserTypes.Security); break;
                case "Staff": buildingService.AddUserToSystem(userNameTextBox.Text, userSurnameTextBox.Text, userID, UserTypes.ServiceStaff); break;
                case "Student": buildingService.AddUserToSystem(userNameTextBox.Text, userSurnameTextBox.Text, userID, UserTypes.Student); break;
                case "Teacher": buildingService.AddUserToSystem(userNameTextBox.Text, userSurnameTextBox.Text, userID, UserTypes.Teacher); break;
            }
            spf.Show();
            Close();
        }

        private void CardCreationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            spf.Show();
        }
    }
}
