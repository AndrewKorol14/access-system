using access_system.Enums;
using Services;
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

        public BuildingService buildingService;

        public SingleRoom(string title, string floorNumber, RoomForm roomForm, BuildingService buildingService)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximumSize = new System.Drawing.Size(windowWidth, windowHeight);
            this.MaximizeBox = false;

            this.buildingService = buildingService;

            this.roomForm = roomForm;
            this.Text = title;
            _roomNumber = Int32.Parse(title.Split(' ')[1]);
            roomNumberLabel2.Text = _roomNumber.ToString();
            _floorNumber = Int32.Parse(floorNumber.Split(' ')[1]);
            floorNumberLabel.Text = _floorNumber.ToString();
            

            roomNameTextBox.Text = buildingService.Building.Floors[_floorNumber].Rooms[_roomNumber].RoomName;
            roomTypeComboBox.Text = buildingService.Building.Floors[_floorNumber].Rooms[_roomNumber].RoomType.ToString();
            //accessModeCheckedListBox[""].Select();
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
            if(roomNameTextBox.Text != String.Empty)
            {
                switch(roomNameTextBox.Text)
                {
                    case "Office": buildingService.AddRoomDescription(_floorNumber, _roomNumber, RoomTypes.OfficeSpace, roomNameTextBox.Text); break;
                    case "Staff Only": buildingService.AddRoomDescription(_floorNumber, _roomNumber, RoomTypes.StaffOnly, roomNameTextBox.Text); break;
                    case "Laboratory": buildingService.AddRoomDescription(_floorNumber, _roomNumber, RoomTypes.Laboratory, roomNameTextBox.Text); break;
                    case "Lection Room": buildingService.AddRoomDescription(_floorNumber, _roomNumber, RoomTypes.LectureRoom, roomNameTextBox.Text); break;
                    case "Classroom": buildingService.AddRoomDescription(_floorNumber, _roomNumber, RoomTypes.Classroom, roomNameTextBox.Text); break;
                    case "General": buildingService.AddRoomDescription(_floorNumber, _roomNumber, RoomTypes.GeneralPurpose, roomNameTextBox.Text); break;
                    default: buildingService.AddRoomDescription(_floorNumber, _roomNumber, RoomTypes.RoomTypeIsNotDefined, roomNameTextBox.Text); break;
                }
                buildingService.AddUserWithUniqAccessForRoom(accessModeCheckedListBox.SelectedIndex, _roomNumber, _floorNumber);               
            }            
            roomForm.Show();
            Hide();
        }
    }
}
