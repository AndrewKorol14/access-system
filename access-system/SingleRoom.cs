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
    public partial class SingleRoom : Form
    {
        private readonly int windowHeight = 460;
        private readonly int windowWidth = 710;

        private int _left = 540;
        private int _top = 5 + 5;
        _top = floorNumberLabel.Location.Y;

        public SingleRoom(RoomForm roomForm, string roomName)
        {
            InitializeComponent();
            Text = roomName;

            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximizeBox = false;


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
            Environment.Exit(Environment.ExitCode);
        }
    }
}
