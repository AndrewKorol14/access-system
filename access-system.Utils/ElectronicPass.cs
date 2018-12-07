using access_system.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.Utils
{
    /// <summary>
    /// Description of the electronic pass
    /// </summary>
    public class ElectronicPass
    {
        public PassBlocking BlockingStatus { get; private set; }
        public int CardNumber { get; private set; }

        public ElectronicPass(PassBlocking blockingStatus, int cardNumber)
        {
            BlockingStatus = blockingStatus;
            CardNumber = cardNumber;
        }

        /// <summary>
        /// Chanhed card blocking status on new
        /// </summary>
        /// <param name="newStatus"></param>
        public void СhangeСardStatus(PassBlocking newStatus)
        {
            BlockingStatus = newStatus;
        }
    }
}
