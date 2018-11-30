﻿using System;
using System.Text;

namespace access_system.Utils.BuildingAndComponents
{
    class LogsEntry
    {
        private User user;
        private Room room;
        public bool LoginResult { get; private set; }
        private DateTime loginAttemptTime;

        public LogsEntry(User user, Room room, bool loginResult, DateTime loginAttemptTime)
        {
            this.user = user;
            this.room = room;
            this.loginAttemptTime = loginAttemptTime;
            this.LoginResult = loginResult;
        }

        public override string ToString()
        {
            StringBuilder entryRecord = new StringBuilder();
            entryRecord.Append("User: ");
            entryRecord.Append(user.ToString());
            entryRecord.Append(" Attempted to enter the room :" + room.RoomName + " floor:"+ room.FloorNumber + " roomNumber:" + room.RoomName);
            entryRecord.Append("At:" + loginAttemptTime.ToString());
            if(LoginResult)
            {
                entryRecord.Append(" User was allowed access");
            }
            else
            {
                entryRecord.Append("user was denied access");
            }

            return entryRecord.ToString();
        }
    }
}
