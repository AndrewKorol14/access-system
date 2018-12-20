using access_system.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using access_system.Entities;
using access_system.Enums;
using IRepositories;

namespace Services
{
    public class BuildingService : IBuildingServices
    {
        private BuildingEntity buildingEntity;
        private IBuildingRepositore repositore;

        public BuildingService(IBuildingRepositore repositore)
        {
            this.repositore = repositore;
        }

        public void AddAccesModifierForRoom(UserTypes type, int roomNumber, int floorNumber)
        {
            buildingEntity.Floors[floorNumber].Rooms[roomNumber].RoomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(type);
        }

        public bool AddPassForUser(int passNumber, int userId)
        {
            
        }

        public void AddRoomDescription(int floorNumber, int roomNumber, RoomTypes roomType, string roomName)
        {
            buildingEntity.Floors[floorNumber].Rooms[roomNumber].RoomName = roomName;
            buildingEntity.Floors[floorNumber].Rooms[roomNumber].RoomType = roomType;
        }

        public bool AddUserToSystem(string FirsName, string LastName, int uniqeID)
        {
            throw new NotImplementedException();
        }

        public void AddUserWithUniqAccessForRoom(UserEntity user, int roomNumber, int floorNumber)
        {
            buildingEntity.Floors[floorNumber].Rooms[roomNumber].RoomLock.UsersWhithUniqueAccess.Add(user.UniqeID);
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

        public UserEntity GetUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public void SetBuilding(string directoryForSave, BuildingEntity buildingToWriteToFile)
        {
            throw new NotImplementedException();
        }

        public void SaveBuildingToFile(string pathToFile)
        {
            repositore.SetBuilding(pathToFile, buildingEntity);
        }

        void IBuildingServices.GetBuilding(string wayToFile)
        {
            buildingEntity = repositore.GetBuilding(wayToFile);
        }
    }
}
