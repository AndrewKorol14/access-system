using System.Collections.Generic;
using access_system.Enums;

namespace access_system.Entities
{
    class FloorEntity
    {
        private List<RoomEntity> _rooms;
        private int FloorNumber { get; set; }
        private int RoomNumber { get; set; }

        public FloorEntity(int floorNumber, int roomsNumber)
        {
            RoomNumber = roomsNumber;
            FloorNumber = floorNumber;
            _rooms = new List<RoomEntity>();
            for (int i = 1; i <= roomsNumber; i++)
            {
                _rooms.Add(new RoomEntity(i, floorNumber, null, RoomTypes.RoomTypeIsNotDefined));
            }
        }
    }
}
