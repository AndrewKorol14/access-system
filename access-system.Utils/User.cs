using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.Utils
{
    /// <summary>
    /// Provides a user description in the system.
    /// </summary>
    public class User
    {
        private string FirsName;
        private string LastName;
        private List<ElectronicPass> electronicPasses;
        private readonly int uniqeID;

        public User(string FirsName, string LastName, List<ElectronicPass> electronicPasses, int uniqeID)
        {
            this.electronicPasses = electronicPasses;
            this.FirsName = FirsName;
            this.LastName = LastName;
            this.uniqeID = uniqeID;
        }

        public User(string FirsName, string LastName, ElectronicPass electronicPass, int uniqeID)
        {
            this.FirsName = FirsName;
            this.LastName = LastName;
            this.uniqeID = uniqeID;
            electronicPasses = new List<ElectronicPass>();
            electronicPasses.Add(electronicPass);
        }

        /// <summary>
        /// Add user additional card
        /// </summary>
        /// <param name="electronicPass"></param>
        public void AddPassForUser(ElectronicPass electronicPass)
        {
            electronicPasses.Add(electronicPass);
        }
    }
}
