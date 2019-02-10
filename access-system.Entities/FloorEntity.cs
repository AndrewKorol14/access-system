using System.Collections.Generic;
using access_system.Enums;

namespace access_system.Entities
{
   public class FloorEntity
    {
        public List<RoomEntity> Rooms { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }

        public FloorEntity(int floorNumber, int roomsNumber)
        {
            RoomNumber = roomsNumber;
            FloorNumber = floorNumber;
            Rooms = new List<RoomEntity>();
            for (int i = 0; i <= roomsNumber; i++)
            {
                Rooms.Add(new RoomEntity(i, floorNumber, null, RoomTypes.RoomTypeIsNotDefined));
            }
        }
    }
}
