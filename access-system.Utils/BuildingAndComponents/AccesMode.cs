using access_system.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.Utils.BuildingAndComponents
{
    class AccesMode
    {
        private List<UserTypes> typesUsersWithAccess;

        public void AddTypeOfUser(UserTypes type)
        {
            typesUsersWithAccess.Add(type);
        }

        public void DeletTepeOfUser(UserTypes type)
        {
            if(typesUsersWithAccess.Contains(type))
            {
                //не помню точно как оно правильно рабботает ннадо чекнуть а ноут садиться 
                typesUsersWithAccess.Remove(type);
            }
        }

        public bool СheckTypeAvailability(UserTypes type)
        {
            return typesUsersWithAccess.Contains(type);
        }
    }
}
