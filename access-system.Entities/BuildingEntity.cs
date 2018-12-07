using System.Collections.Generic;

namespace access_system.Entities
{
    class BuildingEntity
    {
        private string Name { get; set; }
        private List<FloorEntity> _floors;
        private int FloorNumber { get; set; }
        private int RoomsNumber { get; set; }
        private VisitingLogEntity _visitingLogs;
        private SecurityPostEntity _securityPost;

        public BuildingEntity(int floorNumber, int roomsNumber)
        {
            if (floorNumber < 1 || roomsNumber <= 0 || floorNumber > 15 || roomsNumber > 15)
            {
                throw new System.ArgumentException("Invalid number of floors or rooms");
            }
            _securityPost = new SecurityPostEntity();
            _visitingLogs = new VisitingLogEntity();
            RoomsNumber = roomsNumber;
            FloorNumber = floorNumber;
            _floors = new List<FloorEntity>();
            for (int i = 0; i <= floorNumber; i++)
            {
                _floors.Add(new FloorEntity(i, roomsNumber));
            }
        }
    }
}
