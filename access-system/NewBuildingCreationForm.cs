using access_system.Entities;
using System;
using System.Windows.Forms;

namespace access_system
{
    public partial class NewBuildingCreationForm : Form
    {
        private int _floorNumber;
        private int _roomNumber;

        private readonly int _windowHeight = 460;
        private readonly int _windowWidth = 710;        

        public NewBuildingCreationForm()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(_windowWidth, _windowHeight);
            this.MaximumSize = new System.Drawing.Size(_windowWidth, _windowHeight);
            this.MaximizeBox = false;
        }

        private void floorAndRoomNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if(floorNumberTextBox.Text.Length != 0 && roomNumberTextBox.Text.Length != 0)
            {
                createButton.Enabled = true;                
            }
            else
            {
                createButton.Enabled = false;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                BuildingEntity buildingEntity = new BuildingEntity(_floorNumber, _roomNumber);
                Building building = new Building(buildingEntity);
                SecurityPostForm spf = new SecurityPostForm();
                building.Show();                
                spf.Show();
                Hide();
                /*if (Validator.CheckWhetherDigitIsEnteredInField(floorNumberTextBox.Text) && Validator.CheckWhetherDigitIsEnteredInField(roomNumberTextBox.Text))
                {
                    _floorNumber = Int32.Parse(floorNumberTextBox.Text);
                    _roomNumber = Int32.Parse(roomNumberTextBox.Text);
                    Building building = new Building(_floorNumber, _roomNumber, new Utils.BuildingAndComponents.Building(_floorNumber, _roomNumber));
                    SecurityPostForm spf = new SecurityPostForm();
                    building.L
                    building.Show();
                    Hide();
                }
                else
                {
                    string messageTitle = "Input error";
                    string message = "You enter invalid parameters. Please, input correct values";
                    MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, messageTitle, messageBoxButtons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        floorNumberTextBox.Clear();
                        roomNumberTextBox.Clear();
                    }
                }*/
            }
            catch(ArgumentException ex)
            {
                string messageTitle = "Invalid number of floors or rooms";
                string message = "You enter invalid number of floors or rooms. Please, input correct values";
                MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, messageTitle, messageBoxButtons, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    floorNumberTextBox.Clear();
                    roomNumberTextBox.Clear();
                }
            }
        }

        private void NewBuildingCreationForm_Load(object sender, EventArgs e)
        {
            createButton.Enabled = false;
        }

        private void createButton_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}