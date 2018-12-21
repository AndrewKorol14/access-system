using access_system.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using access_system.Entities;

namespace Services
{
    class UserServices : IUserServices
    {
        public UserEntity User { get; set; }

        public void AddPassForUser(ElectronicPassEntity electronicPass)
        {
            User.ElectronicPasses.Add(electronicPass);
        }

        public string GetUserInfo()
        {
            StringBuilder userInfo = new StringBuilder();
            userInfo.Append("FirstName:" + User.FirsName);
            userInfo.Append("LastName" + User.LastName);
            userInfo.Append("UserType:" + User.UserType.ToString());
            return userInfo.ToString();
        }
    }
}
