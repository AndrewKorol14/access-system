using access_system.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_system.IServices
{
    public interface IVisitingLogsServic
    {
        VisitingLogEntity VisitingLog { get; set; }

        void AddLogsEntry(LogEntryEntity logsEntry);

        List<string> GetLogsInformation();
    }
}
