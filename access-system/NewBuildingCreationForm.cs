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
        private bool isFloorNumberBoxFill = false;
        private bool isRoomNumberBoxFill = false;

        public NewBuildingCreationForm()
        {
            InitializeComponent();
        }

        private void floorNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if(floorNumberTextBox.Text.Length == 0)
            {
                createButton.Enabled = false;
            }
            else
            {
                createButton.Enabled = true;
            }
        }

        private void roomNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (roomNumberTextBox.Text.Length == 0)
            {
                createButton.Enabled = false;
            }
            else
            {
                createButton.Enabled = true;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
