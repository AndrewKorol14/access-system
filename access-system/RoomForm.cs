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
    public partial class RoomForm : Form
    {
        private int roomNumber;
        private string floor;

        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;
        private readonly int roomButtonHeight = 30;
        private readonly int roomButtonWidth = 200;

        private Panel panel;

        private Label floorNumberLabel;

        private Button backButton;

        private Building BuildingForm { get; set; }

        private SingleRoom singleRoomForm;

        public RoomForm(int roomNumber, string floor, Building buildingForm)
        {
            this.roomNumber = roomNumber;
            this.floor = floor;
            BuildingForm = buildingForm;

            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximizeBox = false;

            panel = new Panel();
            panel.Location = new Point(0, 0);
            panel.Size = new Size(windowWidth, windowHeight);
            panel.BackColor = Color.Transparent;
            this.Controls.Add(panel);

            floorNumberLabel = new Label();
            floorNumberLabel.ForeColor = Color.Black;
            floorNumberLabel.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold);
            floorNumberLabel.BackColor = Color.Transparent;
            floorNumberLabel.Text = floor;
            floorNumberLabel.Top = 10;
            floorNumberLabel.Size = new Size(floorNumberLabel.PreferredWidth, floorNumberLabel.PreferredHeight);
            floorNumberLabel.Left = (Size.Width - floorNumberLabel.Width) / 2;
            floorNumberLabel.Name = "floorNumberLabel";

            int top = floorNumberLabel.Location.Y + floorNumberLabel.Height + 7;
            int left = (Size.Width - roomButtonWidth * 2 - 100) / 2;
            int secondLeft = left + roomButtonWidth + 100;
            for(int i = 0; i < roomNumber; i++)
            {
                Button button = new Button();
                button.Width = roomButtonWidth;
                button.Height = roomButtonHeight;
                button.Top = top;
                button.BackColor = Color.DarkOrange;
                button.Text = "Room " + i;
                button.Name = "room" + i + "Button";
                button.Click += roomButton_Click;
                if (i % 2 == 0)
                {                    
                    button.Left = left;
                    panel.Controls.Add(button);
                }
                else
                {
                    button.Left = secondLeft;
                    panel.Controls.Add(button);
                    top += button.Height + 7;
                }
                if (i == roomNumber - 1)
                {
                    top += 60;
                    backButton = new Button();
                    backButton.Width = roomButtonWidth;
                    backButton.Height = roomButtonHeight;
                    backButton.Top = top;
                    backButton.Left = secondLeft;
                    backButton.BackColor = Color.Salmon;
                    backButton.Text = "Back";
                    backButton.Name = "backButton";
                    backButton.Click += backButton_Click;
                    panel.Controls.Add(backButton);
                }                
            }
            this.Controls.Add(panel);
            panel.Controls.Add(floorNumberLabel);                    
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BuildingForm.Show();
            Hide();
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != null)
            {
                SingleRoom singleRoom = new SingleRoom(this, button.Text);
                singleRoom.Show();
                Hide();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            //this.Controls.Add(panel);
            //panel.Controls.Add(floorNumberLabel);
            // Controls.Add(floorNumberLabel);
        }

        private void RoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
