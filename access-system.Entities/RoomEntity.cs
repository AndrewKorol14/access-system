using access_system.Enums;

namespace access_system.Entities
{
    public class RoomEntity
    {
        public int RoomNumber { get; private set; }
        public int FloorNumber { get; private set; }
        public string RoomName { get; set; }
        public RoomTypes RoomType { get; set; }
        private LockEntity RoomLock { get; set; }

        public RoomEntity(int roomNumber, int floorNumber, string roomName, RoomTypes roomType)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
            RoomName = roomName;
            RoomType = roomType;
            RoomLock = LockCreator.CreateLockForspecificRoomType(roomType);
        }
    }
}
