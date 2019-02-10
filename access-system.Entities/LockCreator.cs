using access_system.Entities;
using access_system.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class LockCreator
    {
        public static LockEntity CreateLockForspecificRoomType(RoomTypes roomtype)
        {
            LockEntity roomLock = new LockEntity();

            switch (roomtype)
            {
                case RoomTypes.Classroom:
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Student);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Teacher);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Security);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Administration);
                    break;

                case RoomTypes.GeneralPurpose:
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Administration);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Security);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.ServiceStaff);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Student);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Teacher);
                    break;

                case RoomTypes.Laboratory:
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Administration);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Security);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Teacher);
                    break;

                case RoomTypes.LectureRoom:
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Administration);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Security);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Teacher);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Student);
                    break;

                case RoomTypes.OfficeSpace:
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Administration);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Security);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Teacher);
                    break;

                case RoomTypes.StaffOnly:
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Administration);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.Security);
                    roomLock.CategoriesWithAccess.TypesUsersWithAccess.Add(UserTypes.ServiceStaff);
                    break;
            }

            return roomLock;
        }
    }
}
