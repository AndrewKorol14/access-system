using access_system.Entities;
using access_system.Enums;
using access_system.IServices;

namespace Services
{
    class LockServices : ILockServic
    {
        public LockEntity Lock { get; set; }
        public IAccesModeServices AccesModeServices { get; set; }

        public LockServices(LockEntity lockEntety, IAccesModeServices accesModeServices)
        {
            Lock = lockEntety;
            AccesModeServices = accesModeServices;
        }

        public LockServices(IAccesModeServices accesModeServices)
        {
            AccesModeServices = accesModeServices;
        }

        public void AddAccesModifier(UserTypes type)
        {
            AccesModeServices.AccessMode = Lock.CategoriesWithAccess;
            AccesModeServices.AddTypeOfUser(type);
        }

        public void AddUserWithUniqAccess(UserEntity user)
        {
            AccesModeServices.AccessMode = Lock.CategoriesWithAccess;
            Lock.UsersWhithUniqueAccess.Add(user.UniqeID);
        }

        public bool CheckUserAccess(UserEntity user)
        {
            bool allPassblock = true;
            AccesModeServices.AccessMode = Lock.CategoriesWithAccess;

            foreach (ElectronicPassEntity nextPass in user.ElectronicPasses)
            {
                if (nextPass.BlockingStatus == PassBlocking.Unlocked)
                {
                    allPassblock = false;
                    break;
                }
            }
            if (allPassblock)
            {
                return false;
            }
            if (AccesModeServices.СheckTypeAvailability(user.UserType))
            {
                return true;
            }
            if (Lock.UsersWhithUniqueAccess.Contains(user.UniqeID))
            {
                return true;
            }

            return false;
        }
    }
}
