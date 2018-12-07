using System.Collections.Generic;
using access_system.Enums;

namespace access_system.Entities
{
    class AccessModeEntity
    {
        private List<UserTypes> _typesUsersWithAccess;

        public AccessModeEntity()
        {
            _typesUsersWithAccess = new List<UserTypes>();
        }
    }
}
