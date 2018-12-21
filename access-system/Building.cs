using access_system;
using access_system.Entities;
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
    public partial class Building : Form
    {
        private int floorsNumber;
        private int roomsNumber;

        private readonly int buttonWidth = 364;
        private readonly int buttonHeight = 30;
        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;

        public BuildingService buildingService;

       // private access_system.Utils.BuildingAndComponents.Building buildingModel;

        public Building(BuildingEntity buildingEntity, BuildingService buildingService)
        {
            this.floorsNumber = buildingEntity.FloorNumber;
            this.roomsNumber = buildingEntity.RoomsNumber;
            //this.buildingModel = buildingModel;
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);            
            this.MaximizeBox = false;
            this.buildingService = buildingService;
        }

        private void Building_Load(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Location = new Point(0, 0);
            panel.Size = new Size(windowWidth, windowHeight);
            panel.BackColor = Color.Transparent;               
            this.Controls.Add(panel);            
            int top = 10;
            int left = (Size.Width - buttonWidth) / 2;
            for(int i = 0; i < floorsNumber; i++)
            {
                Button button = new Button();
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                button.Left = left;
                button.Top = top;
                button.BackColor = Color.DarkOrange;
                button.Text = "Floor " + i;
                button.Name = "floor" + i + "Button";
                button.Click += floorButton_Click;
                panel.Controls.Add(button);
                top += button.Height + 7; 
            }
            panel.AutoScroll = true;
        }
        //SetError on controller for errors
        private void floorButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if(button != null)
            {
                RoomForm roomForm = new RoomForm(roomsNumber, button.Text, this);
                roomForm.Show();
                Hide();
            }
        }

        private void Building_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
