using access_system.IServices;
using System.Text;
using access_system.Entities;

namespace Services
{
    class LogsEntryServic : ILogsEntryServic
    {
        public LogEntryEntity LogEntry { get; set; }
        public IUserServices UserService { get; set; }
        public IRoomServic RoomServic { get; set; }

        public LogsEntryServic(IUserServices userServic, IRoomServic roomServic)
        {
            RoomServic = roomServic;
            UserService = userServic;
        }

        public string GetInfoAboutLogEntry()
        {
            UserService.User = LogEntry.User;
            RoomServic.Room = LogEntry.Room;
            StringBuilder entryRecord = new StringBuilder();
            entryRecord.Append("User: ");
            entryRecord.Append(UserService.GetUserInfo());
            entryRecord.Append("  Attempted to enter" + RoomServic.GetInfoAboutRoom());
            entryRecord.Append("  At: " + LogEntry.LoginAttemptTime.ToString());
            if (LogEntry.LoginResult)
            {
                entryRecord.Append("  User was allowed access");
            }
            else
            {
                entryRecord.Append("  User was denied access");
            }

            return entryRecord.ToString();
        }
    }
}
