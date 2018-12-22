using access_system.IServices;
using System.Linq;
using access_system.Entities;
using access_system.Enums;
using IRepositories;
using System;
using Repositories;

namespace Services
{
    public class BuildingService : IBuildingServic
    {
        
        public IBuildingRepositore Repositore { get; set; }
        public IFloorServic FloorServic { get; set; }
        public IVisitingLogsServic VisitingLogsServic { get; set; }
        public ISecurityPostServic SecurityPostServic { get; set; }
        public IAccesModeServices AccesModeServices { get; set; }
        public ILockServic LockServic { get; set; }
        public ILogsEntryServic LogsEntryServic { get; set; }
        public IRoomServic RoomServic { get; set; }
        public IUserServices UserServices { get; set; }

        public BuildingEntity Building { get; set; }

        public BuildingService(BuildingEntity building)
        {
            Repositore = new JsonBuildingRepositore();
            AccesModeServices = new AccesModeServices();
            LockServic = new LockServices(AccesModeServices);
            RoomServic = new RoomServic(LockServic);
            FloorServic = new FloorServic(RoomServic);
            UserServices = new UserServices();
            LogsEntryServic = new LogsEntryServic(UserServices, RoomServic);
            VisitingLogsServic = new VisitingLogsServic(LogsEntryServic);
            SecurityPostServic = new SecurityPostServic(UserServices);
        }

        public BuildingService(IBuildingRepositore repositore)
        {
            Repositore = repositore;
            AccesModeServices = new AccesModeServices();
            LockServic = new LockServices(AccesModeServices);
            RoomServic = new RoomServic(LockServic);
            FloorServic = new FloorServic(RoomServic);
            UserServices = new UserServices();
            LogsEntryServic = new LogsEntryServic(UserServices, RoomServic);
            VisitingLogsServic = new VisitingLogsServic(LogsEntryServic);
            SecurityPostServic = new SecurityPostServic(UserServices);
        }

        public void AddAccesModifierForRoom(UserTypes type, int roomNumber, int floorNumber)
        {
            FloorServic.Floor = Building.Floors[floorNumber];
            FloorServic.AddAccesModifierForRoom(type, roomNumber);          
        }

        public bool AddPassForUser(int passNumber, int userId)
        {
            SecurityPostServic.SecurityPost = Building.SecurityPost;
            return SecurityPostServic.AddPassForUser(passNumber, userId);
        }

        public void AddRoomDescription(int floorNumber, int roomNumber, RoomTypes roomType, string roomName)
        {
            FloorServic.Floor = Building.Floors[floorNumber];
            FloorServic.AddRoomDescription(roomNumber, roomType, roomName);
        }

        public bool AddUserToSystem(string FirsName, string LastName, int uniqeID, UserTypes type)
        {
            SecurityPostServic.SecurityPost = Building.SecurityPost;
            return SecurityPostServic.AddUserToSystem(FirsName, LastName, uniqeID, type);
        }

        public void AddUserWithUniqAccessForRoom(UserEntity user, int roomNumber, int floorNumber)
        {
            FloorServic.Floor = Building.Floors[floorNumber];
            FloorServic.AddUserWithUniqAccessForRoom(user, roomNumber);           
        }

        public void ChangePassBlockingStatus(int passNumber, PassBlocking newStatus)
        {
            SecurityPostServic.SecurityPost = Building.SecurityPost;
            SecurityPostServic.ChangePassBlockingStatus(passNumber, newStatus);
        }

        public bool CreateElectronicPass(PassBlocking passStatus, int cardNumber)
        {
            SecurityPostServic.SecurityPost = Building.SecurityPost;
            return SecurityPostServic.CreateElectronicPass(passStatus, cardNumber);
        }

        public string EmulateEntrance(int userId, int floorNumber, int roomNumber)
        {
            if (floorNumber <= Building.FloorNumber && roomNumber <= Building.RoomsNumber && floorNumber >= 0 && roomNumber >= 0)
            {
                LogEntryEntity entry;
                FloorServic.Floor = Building.Floors[floorNumber];
                VisitingLogsServic.VisitingLog = Building.VisitingLogs;
                entry = FloorServic.EmulateEntranceToRoom(GetUserById(userId), roomNumber);
                VisitingLogsServic.AddLogsEntry(entry);
                LogsEntryServic.LogEntry = entry;
                return LogsEntryServic.GetInfoAboutLogEntry();
            }
            throw new System.ArgumentException("Unable to simulate input with given parameters");
        }

        public UserEntity GetUserById(int userId)
        {
            SecurityPostServic.SecurityPost = Building.SecurityPost;
            return SecurityPostServic.GetUser(userId);
        }

        public void SetBuilding(BuildingEntity building)
        {
            Building = building;
        }

        public void SaveBuildingToFile(string pathToFile)
        {
            Repositore.SetBuilding(pathToFile, Building);
        }

        public void GetBuilding(string wayToFile)
        {
            Building = Repositore.GetBuilding(wayToFile);
        }
    }
}
