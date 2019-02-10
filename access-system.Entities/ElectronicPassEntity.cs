using access_system.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.Entities
{
    public class ElectronicPassEntity
    {
        public PassBlocking BlockingStatus { get; set; }
        public int CardNumber { get; set; }

        public ElectronicPassEntity(PassBlocking blockingStatus, int cardNumber)
        {
            BlockingStatus = blockingStatus;
            CardNumber = cardNumber;
        }
    }
}
