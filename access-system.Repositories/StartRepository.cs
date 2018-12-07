using access_system.Entities;
using access_system.Entities.UI;
using IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StartRepository: IStartRepository
    {
        public StartFormEntity GetData()
        {
            return new StartFormEntity
            {
                WelcomeWord = "Welcome!!!"
            };
        }
    }
}
