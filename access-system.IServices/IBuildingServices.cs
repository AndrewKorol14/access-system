using access_system.Entities;
using access_system.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.IServices
{
    public interface IBuildingServices
    {
        BuildingEntity GetBuilding(string wayToFile);

        void SetBuilding(string directoryForSave, BuildingEntity buildingToWriteToFile);

        void AddRoomDescription(int floorNumber, int roomNumber, RoomTypes roomType, string roomName);

        void AddUserWithUniqAccessForRoom(UserEntity user, int roomNumber, int floorNumber);

        void AddAccesModifierForRoom(UserTypes type, int roomNumber, int floorNumber);

        void SaveBuildingToFile(IBuildingServices reader, string pathToFile);

        string EmulateEntrance(int userId, int floorNumber, int roomNumber);

        bool CreateElectronicPass(PassBlocking passStatus, int cardNumber);

        bool AddUserToSystem(string FirsName, string LastName, int uniqeID);

        bool AddPassForUser(int passNumber, int userId);

        void ChangePassBlockingStatus(int passNumber, PassBlocking newStatus);

        UserEntity GetUser(int UserId);
    }
}
