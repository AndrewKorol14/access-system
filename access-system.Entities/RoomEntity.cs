using access_system.Enums;

namespace access_system.Entities
{
    public class RoomEntity
    {
        public int RoomNumber { get; private set; }
        public int FloorNumber { get; private set; }
        public string RoomName { get; set; }
        public RoomTypes RoomType { get; set; }
        public LockEntity RoomLock { get; set; }
    }
}
