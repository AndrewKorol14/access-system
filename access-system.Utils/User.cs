using access_system.Utils.Enums;
using System.Collections.Generic;

namespace access_system.Utils
{
    /// <summary>
    /// Provides a user description in the system.
    /// </summary>
    public class User
    {
        public string FirsName { get; private set; }
        public string LastName { get; private set; }
        public List<ElectronicPass> ElectronicPasses { get; private set; }
        public int UniqeID { get; private set; }
        public UserTypes UserType { get; private set; }

        public User(string FirsName, string LastName, List<ElectronicPass> electronicPasses, int uniqeID)
        {
            ElectronicPasses = electronicPasses;
            this.FirsName = FirsName;
            this.LastName = LastName;
            UniqeID = uniqeID;
        }

        public User(string FirsName, string LastName, ElectronicPass electronicPass, int uniqeID)
        {
            this.FirsName = FirsName;
            this.LastName = LastName;
            UniqeID = uniqeID;
            ElectronicPasses = new List<ElectronicPass>();
            ElectronicPasses.Add(electronicPass);
        }

        /// <summary>
        /// Add user additional card
        /// </summary>
        /// <param name="electronicPass"></param>
        public void AddPassForUser(ElectronicPass electronicPass)
        {
            ElectronicPasses.Add(electronicPass);
        }
    }
}
