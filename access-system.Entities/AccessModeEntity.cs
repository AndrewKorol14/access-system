using System.Collections.Generic;
using access_system.Enums;

namespace access_system.Entities
{
    public class AccessModeEntity
    {
        public List<UserTypes> TypesUsersWithAccess { get; set; }

        public AccessModeEntity()
        {
            TypesUsersWithAccess = new List<UserTypes>();
        }
    }
}
