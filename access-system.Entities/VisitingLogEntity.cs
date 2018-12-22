using System.Collections.Generic;

namespace access_system.Entities
{
    public class VisitingLogEntity
    {
        public List<LogEntryEntity> LogsEntries { get; set; }

        public VisitingLogEntity()
        {
            LogsEntries = new List<LogEntryEntity>();
        }
    }
}
