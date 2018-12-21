using System;
using System.Windows.Forms;

namespace access_system
{
    public partial class SingleRoom : Form
    {
        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;

        private int _roomNumber;
        private int _floorNumber;

        public RoomForm roomForm;

        public SingleRoom(string title, string floorNumber, RoomForm roomForm)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximizeBox = false;

            this.roomForm = roomForm;
            this.Text = title;
            _roomNumber = Int32.Parse(title.Split(' ')[1]);
            roomNumberLabel2.Text = _roomNumber.ToString();
            _floorNumber = Int32.Parse(floorNumber.Split(' ')[1]);
            floorNumberLabel.Text = _floorNumber.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SingleRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            roomForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            roomForm.Show();
            Hide();
        }
    }
}
