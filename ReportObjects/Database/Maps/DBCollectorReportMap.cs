﻿using CsvHelper.Configuration;

namespace AppDynamics.Dexter.ReportObjects
{
    public class DBCollectorReportMap : ClassMap<DBCollector>
    {
        public DBCollectorReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.CollectorName).Index(i); i++;
            Map(m => m.CollectorType).Index(i); i++;

            Map(m => m.CollectorStatus).Index(i); i++;

            Map(m => m.AgentName).Index(i); i++;

            Map(m => m.Host).Index(i); i++;
            Map(m => m.Port).Index(i); i++;
            Map(m => m.UserName).Index(i); i++;
            Map(m => m.Role).Index(i); i++;

            Map(m => m.Calls).Index(i); i++;
            Map(m => m.ExecTime).Index(i); i++;
            Map(m => m.ExecTimeSpan).Index(i); i++;

            Map(m => m.From).Index(i); i++;
            Map(m => m.To).Index(i); i++;
            Map(m => m.FromUtc).Index(i); i++;
            Map(m => m.ToUtc).Index(i); i++;
            Map(m => m.Duration).Index(i); i++;

            Map(m => m.ConfigID).Index(i); i++;
            Map(m => m.CollectorID).Index(i); i++;

            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
            Map(m => m.CollectorLink).Index(i); i++;
        }
    }
}
