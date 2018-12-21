using System;

namespace access_system.Entities
{
    public class LogEntryEntity
    {
        public UserEntity User { get; set; }
        public RoomEntity Room { get; set; }
        public bool LoginResult { get; private set; }
        public DateTime LoginAttemptTime { get; set; }

        public LogEntryEntity(UserEntity user, RoomEntity room, bool loginResult, DateTime loginAttemptTime)
        {
            User = user;
            Room = room;
            LoginAttemptTime = loginAttemptTime;
            LoginResult = loginResult;
        }
    }
}
