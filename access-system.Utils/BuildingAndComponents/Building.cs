using access_system.Utils.Enums;
using access_system.Utils.Readers;
using System.Collections.Generic;

namespace access_system.Utils.BuildingAndComponents
{
    public class Building
    {
        private string name;
        private List<Floor> floors;
        private int floorNumber;
        private int roomsNumber;
        private VisitingLogs visitingLogs;
        private SecurityPost securityPost;

        public Building(int floorNumber, int roomsNumber)
        {
            if(floorNumber < 1 || roomsNumber <=0 || floorNumber > 15 || roomsNumber > 15)
            {
                throw new System.ArgumentException("Invalid number of floors or rooms");
            }
            securityPost = new SecurityPost();
            visitingLogs = new VisitingLogs();
            this.roomsNumber = roomsNumber;
            this.floorNumber = floorNumber;
            floors = new List<Floor>();
            for(int i = 0; i <= floorNumber; i++)
            {
                floors.Add(new Floor(i, roomsNumber));
            }
        }

        public void AddRoomDescription(int floorNumber ,int roomNumber, RoomTypes roomType, string roomName)
        {
            floors[floorNumber].AddRoomDescription(roomNumber, roomType, roomName);
        }

        public void AddUserWithUniqAccessForRoom(User user, int roomNumber, int floorNumber)
        {
            floors[floorNumber].AddUserWithUniqAccessForRoom(user, roomNumber);
        }

        public void AddAccesModifierForRoom(UserTypes type, int roomNumber, int floorNumber)
        {
            floors[floorNumber].AddAccesModifierForRoom(type,roomNumber);
        }

        public void SaveBuildingToFile(IReader reader, string pathToFile)
        {
            reader.WriteToFile<Building>(pathToFile, this);
        }

        public void WriteLogsToFile(IReader reader, string pathForFile)
        {
            visitingLogs.WriteLogsToFile(reader, pathForFile);
        }

        public string EmulateEntrance(int userId, int floorNumber, int roomNumber)
        {
            if (floorNumber <= this.floorNumber && roomNumber <= roomsNumber && floorNumber >= 0 && roomsNumber >= 0)
            {
                LogsEntry entry;
                entry = floors[floorNumber].EmulateEntranceToRoom(securityPost.GetUser(userId), roomNumber);
                visitingLogs.AddLogsEntry(entry);
                return entry.ToString();              
            }
            throw new System.ArgumentException("Unable to simulate input with given parameters");
        }
    }
}
