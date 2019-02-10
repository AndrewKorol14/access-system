using access_system.Entities;
using access_system.Enums;

namespace access_system.IServices
{
    public interface ILockServic
    {
        LockEntity Lock { get; set; }

        void AddAccesModifier(UserTypes type);

        void AddUserWithUniqAccess(int userId);

        bool CheckUserAccess(UserEntity user);
    }
}
