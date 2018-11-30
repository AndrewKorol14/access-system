using access_system.Utils.Enums;
using System.Collections.Generic;

namespace access_system.Utils.BuildingAndComponents
{
    class Floor
    {
        private List<Room> rooms;
        private int floorNumber;
        private int roomNumber;

        public Floor(int floorNumber, int roomNumber)
        {
            this.roomNumber = roomNumber; 
            this.floorNumber = floorNumber;
            for(int i = 1; i <= roomNumber; i++)
            {
                rooms.Add(new Room(i, floorNumber, null, RoomTypes.RoomTypeIsNotDefined));
            }
        }

        public void AddRoomDescription(int roomNumber, RoomTypes roomType, string roomName)
        {
            rooms[roomNumber - 1].RoomType = roomType;
            rooms[roomNumber - 1].RoomName = roomName;
        }

        public void AddUserWithUniqAccessForRoom(User user, int roomNumber)
        {
            rooms[roomNumber - 1].AddUserWithUniqAccessForRoom(user);
        }

        public void AddAccesModifierForRoom(UserTypes type, int roomNumber)
        {
            rooms[roomNumber - 1].AddAccesModifierForRoom(type);
        }
    }
}
