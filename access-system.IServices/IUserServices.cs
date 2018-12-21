using access_system.Entities;

namespace access_system.IServices
{
    public interface IUserServices
    {
        UserEntity User { get; set; }

        void AddPassForUser(ElectronicPassEntity electronicPass);

        string GetUserInfo();
    }
}
