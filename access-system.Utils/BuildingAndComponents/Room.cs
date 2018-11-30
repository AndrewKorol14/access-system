using access_system.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.Utils.BuildingAndComponents
{
    internal class Room
    {
        public int RoomNumber { get; private set; }
        public int FloorNumber { get; private set; }
        public string RoomName { get; set; }
        public RoomTypes RoomType { get; private set; }
        private Lock roomLock;

        public Room(int roomNumber, int floorNumber, string roomName, RoomTypes roomType)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
            RoomName = roomName;
            RoomType = roomType;
            roomLock = LockCreator.CreateLockForspecificRoomType(roomType);
        }

        public LogsEntry LoginAttempt(User user)
        {
            return new LogsEntry(user, this, roomLock.CheckUserAccess(user), DateTime.Now);
        }
    }
}
