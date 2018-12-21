using access_system.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using access_system.Entities;
using access_system.Enums;

namespace Services
{
    class SecurityPostServic : ISecurityPostServic
    {
        public SecurityPostEntity SecurityPost { get; set; }
        public IUserServices UserServices { get; set; }

        public SecurityPostServic(IUserServices userServices)
        {
            UserServices = userServices;
        }

        public bool AddPassForUser(int passNumber, int userId)
        {
            foreach (UserEntity nextUser in SecurityPost.Users)
            {
                foreach (ElectronicPassEntity nextPass in nextUser.ElectronicPasses)
                {
                    if (nextPass.CardNumber == passNumber)
                    {
                        return false;
                    }
                }
            }

            foreach (UserEntity nextUser in SecurityPost.Users)
            {
                if (nextUser.UniqeID == userId)
                {
                    UserServices.User = nextUser;
                    UserServices.AddPassForUser(nextUser.ElectronicPasses.Where(next => next.CardNumber == passNumber).Single());
                    break;
                }
            }
            return true;
        }

        public bool AddUserToSystem(string FirsName, string LastName, int uniqeID)
        {
            foreach (UserEntity nextUser in SecurityPost.Users)
            {
                if (nextUser.UniqeID == uniqeID)
                {
                    return false;
                }
            }
            SecurityPost.Users.Add(new UserEntity(FirsName, LastName, uniqeID));
            return true;
        }

        public void ChangePassBlockingStatus(int passNumber, PassBlocking newStatus)
        {
            foreach (ElectronicPassEntity nextPass in SecurityPost.ElectronicPasses)
            {
                if (nextPass.CardNumber == passNumber)
                {
                    nextPass.BlockingStatus = newStatus;
                    break;
                }
            }
        }

        public bool CreateElectronicPass(PassBlocking passStatus, int cardNumber)
        {
            foreach (ElectronicPassEntity nextPass in SecurityPost.ElectronicPasses)
            {
                if (nextPass.CardNumber == cardNumber)
                {
                    return false;
                }
            }
            SecurityPost.ElectronicPasses.Add(new ElectronicPassEntity(passStatus, cardNumber));
            return true;
        }

        public UserEntity GetUser(int UserId)
        {
            foreach (UserEntity nextUser in SecurityPost.Users)
            {
                if (nextUser.UniqeID == UserId)
                {
                    return nextUser;
                }
            }
            throw new System.ArgumentException("User with this ID not found");
        }
    }
}
