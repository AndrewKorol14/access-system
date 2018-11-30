using access_system.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.Utils.BuildingAndComponents
{
    class Room
    {
        private int roomNumber;
        private int floorNumber;
        private string roomName;
        private RoomTypes roomType;
        private Lock roomLock;

        public Room(int roomNumber, int floorNumber, string roomName, RoomTypes roomType)
        {
            this.floorNumber = floorNumber;
            this.roomNumber = roomNumber;
            this.roomName = roomName;
            this.roomType = roomType;
            roomLock = LockCreator.CreateLockForspecificRoomType(roomType);
        }
    }
}
