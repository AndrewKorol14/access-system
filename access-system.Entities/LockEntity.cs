using System.Collections.Generic;

namespace access_system.Entities
{
    public class LockEntity
    {
        public AccessModeEntity CategoriesWithAccess { get; set; }
        public List<int> UsersWhithUniqueAccess { get; set; }

        public LockEntity(AccessModeEntity categoriesWithAcces, List<int> usersWhithUniqueAcces)
        {
            CategoriesWithAccess = categoriesWithAcces;
            UsersWhithUniqueAccess = usersWhithUniqueAcces;
        }
    }
}
