using access_system.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.Utils.BuildingAndComponents
{
    class SecurityPost
    {
        List<User> users;
        List<ElectronicPass> electronicPasses;

        public SecurityPost()
        {
            users = new List<User>();
            electronicPasses = new List<ElectronicPass>();
        }

        public bool CreateElectronicPass(PassBlocking passStatus, int cardNumber)
        {
            foreach (ElectronicPass nextPass in electronicPasses)
            {
                if(nextPass.CardNumber == cardNumber)
                {
                    return false;
                }
            }            
            electronicPasses.Add(new ElectronicPass(passStatus, cardNumber));
            return true;
        }

        public bool AddUserToSystem(string FirsName, string LastName, int uniqeID)
        {
            foreach (User nextUser in users)
            {
                if(nextUser.UniqeID == uniqeID)
                {
                    return false;
                }
            }
            users.Add(new User(FirsName, LastName, uniqeID));
            return true;
        }

        public bool AddPassForUser(int passNumber, int userId)
        {
            foreach (User nextUser in users)
            {
                foreach(ElectronicPass nextPass in nextUser.ElectronicPasses)
                {
                    if(nextPass.CardNumber == passNumber)
                    {
                        return false;
                    }
                }
            }

            foreach (User nextUser in users)
            {
                if(nextUser.UniqeID == userId)
                {
                    nextUser.AddPassForUser(electronicPasses.Where(next => next.CardNumber == passNumber).Single());
                }
            }
            return true;
        }
    }
}
