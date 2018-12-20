using System.Collections.Generic;

namespace access_system.Entities
{
    public class BuildingEntity
    {
        public string Name { get; set; }
        public  List<FloorEntity> Floors { get; set; }
        public int FloorNumber { get;}
        public int RoomsNumber { get;}
        private VisitingLogEntity VisitingLogs;
        private SecurityPostEntity SecurityPost;

        public BuildingEntity(int floorNumber, int roomsNumber)
        {
            if (floorNumber < 1 || roomsNumber <= 0 || floorNumber > 15 || roomsNumber > 15)
            {
                throw new System.ArgumentException("Invalid number of floors or rooms");
            }
            SecurityPost = new SecurityPostEntity();
            VisitingLogs = new VisitingLogEntity();
            RoomsNumber = roomsNumber;
            FloorNumber = floorNumber;
            Floors = new List<FloorEntity>();
            for (int i = 0; i <= floorNumber; i++)
            {
                Floors.Add(new FloorEntity(i, roomsNumber));
            }
        }
    }
}
