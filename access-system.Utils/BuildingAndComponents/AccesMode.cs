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

        public AccesMode()
        {
            typesUsersWithAccess = new List<UserTypes>();
        }

        public void AddTypeOfUser(UserTypes type)
        {
            typesUsersWithAccess.Add(type);
        }

        public void DeletTepeOfUser(UserTypes type)
        {
            //ремув вернёт fols если не найдёт элемента но это не особо важно наверно
            typesUsersWithAccess.Remove(type);
        }

        public bool СheckTypeAvailability(UserTypes type)
        {
            return typesUsersWithAccess.Contains(type);
        }
    }
}
