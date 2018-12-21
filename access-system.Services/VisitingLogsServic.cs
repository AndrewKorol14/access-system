using access_system.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using access_system.Entities;

namespace Services
{
    class VisitingLogsServic : IVisitingLogsServic
    {
        public VisitingLogEntity VisitingLog { get; set; }
        public ILogsEntryServic LogsEntryServic { get; set; }

        public VisitingLogsServic(ILogsEntryServic logsEntryServic)
        {
            LogsEntryServic = logsEntryServic;
        }
    

        public void AddLogsEntry(LogEntryEntity logsEntry)
        {
            VisitingLog.LogsEntries.Add(logsEntry);
        }

        public List<string> GetLogsInformation()
        {
            List<string> logsInformation = new List<string>();
            foreach (LogEntryEntity nextEntry in VisitingLog.LogsEntries)
            {
                LogsEntryServic.LogEntry = nextEntry;
                logsInformation.Add(LogsEntryServic.GetInfoAboutLogEntry());
            }
            return logsInformation;
        }
    }
}
