using access_system.Entities;
using access_system.Enums;
using access_system.IServices;

namespace Services
{
    public class AccesModeServices : IAccesModeServices
    {
        public AccessModeEntity AccessMode { get; set; }

        public AccesModeServices()
        {
            AccessMode = new AccessModeEntity();
        }

        public AccesModeServices(AccessModeEntity accessMode)
        {
            AccessMode = accessMode;
        }

        public void AddTypeOfUser(UserTypes type)
        {
           AccessMode.TypesUsersWithAccess.Add(type);
        }

        public void DeletTepeOfUser(UserTypes type)
        {
            AccessMode.TypesUsersWithAccess.Remove(type);
        }

        public bool СheckTypeAvailability(UserTypes type)
        {
            return AccessMode.TypesUsersWithAccess.Contains(type);
        }
    }
}
