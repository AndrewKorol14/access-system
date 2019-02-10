using access_system.Utils.Readers;
using System.Collections.Generic;

namespace access_system.Utils.BuildingAndComponents
{
    internal class VisitingLogs
    {
        private List<LogsEntry> logsEntryes;

        public void AddLogsEntry(LogsEntry logsEntry)
        {
            logsEntryes.Add(logsEntry);
        }

        public List<string> GetLogsInformation()
        {
            List<string> logsInformation = new List<string>();
            foreach(LogsEntry nextEntry in logsEntryes)
            {
                logsInformation.Add(nextEntry.ToString());
            }
            return logsInformation;
        }

        public void WriteLogsToFile(IReader reader, string filePath)
        {
            reader.WriteToFile<VisitingLogs>(filePath, this);
        }
    }
}
