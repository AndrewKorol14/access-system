using System;

namespace access_system.Entities
{
    public class LogEntryEntity
    {
        public UserEntity User { get; set; }
        private RoomEntity Room { get; set; }
        public bool LoginResult { get; private set; }
        private DateTime LoginAttemptTime { get; set; }
    }
}
