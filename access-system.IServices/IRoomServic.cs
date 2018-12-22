using access_system.Entities;
using access_system.Enums;

namespace access_system.IServices
{
    public interface IRoomServic
    {
        RoomEntity Room { get; set; }

        LogEntryEntity LoginAttempt(UserEntity user);

        string GetInfoAboutRoom();

        void AddAccesModifierForRoom(UserTypes type);

        void AddUserWithUniqAccessForRoom(int userId);
    }
}
