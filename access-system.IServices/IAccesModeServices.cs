using access_system.Entities;
using access_system.Enums;

namespace access_system.IServices
{
    public interface IAccesModeServices
    {
        AccessModeEntity AccessMode { get; set; }

        void AddTypeOfUser(UserTypes type);

        void DeletTepeOfUser(UserTypes type);

        bool СheckTypeAvailability(UserTypes type);
    }
}
