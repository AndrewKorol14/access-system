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
    public partial class NewBuildingCreationForm : Form
    {
        private int floorNumber;
        private int roomNumber;

        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;        

        public NewBuildingCreationForm()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
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
            Building building = new Building(10, 3, new Utils.BuildingAndComponents.Building(10, 3));
            building.Show();
            Hide();
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
