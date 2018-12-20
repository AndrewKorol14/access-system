using access_system.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using access_system.Entities;
using access_system.Enums;

namespace Services
{
    class BuildingService : IBuildingServices
    {
        private BuildingEntity buildingEntity;

        public void AddAccesModifierForRoom(UserTypes type, int roomNumber, int floorNumber)
        {
            throw new NotImplementedException();
        }

        public bool AddPassForUser(int passNumber, int userId)
        {
            throw new NotImplementedException();
        }

        public void AddRoomDescription(int floorNumber, int roomNumber, RoomTypes roomType, string roomName)
        {
            throw new NotImplementedException();
        }

        public bool AddUserToSystem(string FirsName, string LastName, int uniqeID)
        {
            throw new NotImplementedException();
        }

        public void AddUserWithUniqAccessForRoom(UserEntity user, int roomNumber, int floorNumber)
        {
            throw new NotImplementedException();
        }

        public void ChangePassBlockingStatus(int passNumber, PassBlocking newStatus)
        {
            throw new NotImplementedException();
        }

        public bool CreateElectronicPass(PassBlocking passStatus, int cardNumber)
        {
            throw new NotImplementedException();
        }

        public string EmulateEntrance(int userId, int floorNumber, int roomNumber)
        {
            throw new NotImplementedException();
        }

        public BuildingEntity GetBuilding(string wayToFile)
        {
            throw new NotImplementedException();
        }

        public UserEntity GetUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public void SaveBuildingToFile(IBuildingServices reader, string pathToFile)
        {
            throw new NotImplementedException();
        }

        public void SetBuilding(string directoryForSave, BuildingEntity buildingToWriteToFile)
        {
            throw new NotImplementedException();
        }
    }
}
