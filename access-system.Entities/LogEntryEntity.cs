using System;

namespace access_system.Entities
{
    class LogEntryEntity
    {
        //private User _user;
        private RoomEntity Room { get; set; }
        public bool LoginResult { get; private set; }
        private DateTime LoginAttemptTime { get; set; }

        public LogEntryEntity(/*User user,*/ RoomEntity room, bool loginResult, DateTime loginAttemptTime)
        {
           // this.user = user;
            Room = room;
            LoginAttemptTime = loginAttemptTime;
            LoginResult = loginResult;
        }
    }
}
