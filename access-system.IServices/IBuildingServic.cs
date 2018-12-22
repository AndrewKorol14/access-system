using access_system.Entities;
using access_system.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.IServices
{
    public interface IBuildingServic
    {
        BuildingEntity Building { get;  set;}

        void GetBuilding(string wayToFile);

        void AddRoomDescription(int floorNumber, int roomNumber, RoomTypes roomType, string roomName);

        void AddUserWithUniqAccessForRoom(UserEntity user, int roomNumber, int floorNumber);

        void AddAccesModifierForRoom(UserTypes type, int roomNumber, int floorNumber);

        void SaveBuildingToFile(string pathToFile);

        string EmulateEntrance(int userId, int floorNumber, int roomNumber);

        bool CreateElectronicPass(PassBlocking passStatus, int cardNumber);

        bool AddUserToSystem(string FirsName, string LastName, int uniqeID, UserTypes type);

        bool AddPassForUser(int passNumber, int userId);

        void ChangePassBlockingStatus(int passNumber, PassBlocking newStatus);
    }
}
