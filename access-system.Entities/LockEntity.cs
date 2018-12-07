using System.Collections.Generic;

namespace access_system.Entities
{
    class LockEntity
    {
        private AccessModeEntity _categoriesWithAccess;
        private List<int> _usersWhithUniqueAccess;

        public LockEntity()
        {
            _usersWhithUniqueAccess = new List<int>();
            _categoriesWithAccess = new AccessModeEntity();
        }

        public LockEntity(AccessModeEntity categoriesWithAcces, List<int> usersWhithUniqueAcces)
        {
            _categoriesWithAccess = categoriesWithAcces;
            _usersWhithUniqueAccess = usersWhithUniqueAcces;
        }
    }
}
