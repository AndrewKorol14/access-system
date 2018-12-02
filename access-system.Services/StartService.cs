using access_system.Entities.UI;
using access_system.IServices;
using IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StartService: IStartService
    {
        private IStartRepository _startRepository;

        public StartService(IStartRepository startRepository)
        {
            _startRepository = startRepository;
        }

        public StartFormEntity GetData()
        {
            return _startRepository.GetData();
        }
    }
}
