using access_system.Utils.Enums;

namespace access_system.Utils.BuildingAndComponents
{
    internal static class LockCreator
    {
        public static Lock CreateLockForspecificRoomType(RoomTypes roomtype)
        {
            Lock roomLock = new Lock();

            switch (roomtype)
            {
                case RoomTypes.Classroom:
                    roomLock.AddAccesModifier(UserTypes.Student);
                    roomLock.AddAccesModifier(UserTypes.Teacher);
                    roomLock.AddAccesModifier(UserTypes.Security);
                    roomLock.AddAccesModifier(UserTypes.Administration);
                    break;

                case RoomTypes.GeneralPurpose:
                    roomLock.AddAccesModifier(UserTypes.Administration);
                    roomLock.AddAccesModifier(UserTypes.Security);
                    roomLock.AddAccesModifier(UserTypes.ServiceStaff);
                    roomLock.AddAccesModifier(UserTypes.Student);
                    roomLock.AddAccesModifier(UserTypes.Teacher);
                    break;

                case RoomTypes.Laboratory:
                    roomLock.AddAccesModifier(UserTypes.Administration);
                    roomLock.AddAccesModifier(UserTypes.Security);
                    roomLock.AddAccesModifier(UserTypes.Teacher);
                    break;

                case RoomTypes.LectureRoom:
                    roomLock.AddAccesModifier(UserTypes.Administration);
                    roomLock.AddAccesModifier(UserTypes.Security);
                    roomLock.AddAccesModifier(UserTypes.Teacher);
                    roomLock.AddAccesModifier(UserTypes.Student);
                    break;

                case RoomTypes.OfficeSpace:
                    roomLock.AddAccesModifier(UserTypes.Administration);
                    roomLock.AddAccesModifier(UserTypes.Security);
                    roomLock.AddAccesModifier(UserTypes.Teacher);
                    break;

                case RoomTypes.StaffOnly:
                    roomLock.AddAccesModifier(UserTypes.Administration);
                    roomLock.AddAccesModifier(UserTypes.Security);
                    roomLock.AddAccesModifier(UserTypes.ServiceStaff);
                    break;
            }

            return roomLock;
        }
    }
}
