using System;
using System.Text;
using access_system.Entities;
using access_system.Enums;

namespace access_system.IServices
{
    class RoomServic : IRoomServic
    {
        public RoomEntity Room { get; set; }
        public ILockServic LockServic { get; set; }

        public RoomServic(RoomEntity room, ILockServic lockServic)
        {
            Room = room;
            LockServic = lockServic;
        }

        public RoomServic(ILockServic lockServic)
        {
            LockServic = lockServic;
        }

        public void AddUserWithUniqAccessForRoom(UserEntity user)
        {
            LockServic.Lock = Room.RoomLock;
            LockServic.AddUserWithUniqAccess(user);
        }

        public LogEntryEntity LoginAttempt(UserEntity user)
        {
            return new LogEntryEntity(user, Room, LockServic.CheckUserAccess(user), DateTime.Now);
        }

        public void AddAccesModifierForRoom(UserTypes type)
        {
            LockServic.Lock = Room.RoomLock;
            LockServic.AddAccesModifier(type);
        }

        public string GetInfoAboutRoom()
        {
            StringBuilder roomInfo = new StringBuilder();
            roomInfo.Append("room: " + Room.RoomName + " floor:" + Room.FloorNumber + " roomNumber:" + Room.RoomName);
            return roomInfo.ToString();
        }
    }
}
