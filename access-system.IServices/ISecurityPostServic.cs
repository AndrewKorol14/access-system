using access_system.Entities;
using access_system.Enums;

namespace access_system.IServices
{
    public interface ISecurityPostServic
    {
        SecurityPostEntity SecurityPost { get; set;}

        bool CreateElectronicPass(PassBlocking passStatus, int cardNumber);

        bool AddUserToSystem(string FirsName, string LastName, int uniqeID);

        bool AddPassForUser(int passNumber, int userId);

        void ChangePassBlockingStatus(int passNumber, PassBlocking newStatus);

        UserEntity GetUser(int UserId);
    }
}
