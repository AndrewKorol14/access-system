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
        public PassBlocking BlockingStatus { get; private set; }
        public int CardNumber { get; private set; }
    }
}
