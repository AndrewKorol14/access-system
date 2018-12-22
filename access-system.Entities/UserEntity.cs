﻿using access_system.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.Entities
{
    public  class UserEntity
    {
        public string FirsName { get; private set; }
        public string LastName { get; private set; }
        public List<ElectronicPassEntity> ElectronicPasses { get; private set; }
        public int UniqeID { get; private set; }
        public UserTypes UserType { get; private set; }

        public UserEntity(string FirsName, string LastName, int uniqeID, UserTypes type)
        {
            this.FirsName = FirsName;
            this.LastName = LastName;
            UniqeID = uniqeID;
            UserType = type;
            ElectronicPasses = new List<ElectronicPassEntity>();
        }
    }
}
