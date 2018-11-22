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
        private PassBlocking blockingStatus;
        private readonly int cardNumber;

        public ElectronicPass(PassBlocking blockingStatus, int cardNumber)
        {
            this.blockingStatus = blockingStatus;
            this.cardNumber = cardNumber;
        }

        /// <summary>
        /// Chanhed card blocking status on new
        /// </summary>
        /// <param name="newStatus"></param>
        public void СhangeСardStatus(PassBlocking newStatus)
        {
            blockingStatus = newStatus;
        }
    }
}
