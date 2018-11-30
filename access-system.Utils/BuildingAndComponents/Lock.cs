using access_system.Utils.Enums;
using System.Collections.Generic;

namespace access_system.Utils.BuildingAndComponents
{
    class Lock
    {
        private AccesMode categoriesWithAccess;
        private List<int> usersWhithUniqueAccess;

        public Lock()
        {
            usersWhithUniqueAccess = new List<int>();
            categoriesWithAccess = new AccesMode();
        }

        public Lock(AccesMode categoriesWithAcces, List<int> usersWhithUniqueAcces)
        {
            categoriesWithAccess = categoriesWithAcces;
            usersWhithUniqueAccess = usersWhithUniqueAcces;
        }

        public void AddAccesModifier(UserTypes type)
        {
            categoriesWithAccess.AddTypeOfUser(type);
        }

        public void AddUserWithUniqAccess(User user)
        {
            usersWhithUniqueAccess.Add(user.UniqeID);
        }

        public bool CheckUserAccess(User user)
        {
            if(categoriesWithAccess.СheckTypeAvailability(user.UserType))
            {
                return true;
            }

            if(usersWhithUniqueAccess.Contains(user.UniqeID))
            {
                return true;
            }

            return false;
        }
    }
}
