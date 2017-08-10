﻿using CsvHelper.Configuration;

namespace AppDynamics.OfflineData.ReportObjects
{
    public class TierMetricReportMap : CsvClassMap<EntityTier>
    {
        public TierMetricReportMap()
        {
            int i = 0;
            Map(m => m.Controller).Index(i); i++;
            Map(m => m.ApplicationName).Index(i); i++;
            Map(m => m.TierName).Index(i); i++;
            Map(m => m.TierType).Index(i); i++;
            Map(m => m.AgentType).Index(i); i++;
            Map(m => m.ART).Index(i); i++;
            Map(m => m.TimeTotal).Index(i); i++;
            Map(m => m.Calls).Index(i); i++;
            Map(m => m.CPM).Index(i); i++;
            Map(m => m.Errors).Index(i); i++;
            Map(m => m.EPM).Index(i); i++;
            Map(m => m.Exceptions).Index(i); i++;
            Map(m => m.EXCPM).Index(i); i++;
            Map(m => m.HttpErrors).Index(i); i++;
            Map(m => m.HTTPEPM).Index(i); i++;
            Map(m => m.ErrorsPercentage).Index(i); i++;
            Map(m => m.HasActivity).Index(i); i++;
            Map(m => m.From).Index(i); i++;
            Map(m => m.To).Index(i); i++;
            Map(m => m.FromUtc).Index(i); i++;
            Map(m => m.ToUtc).Index(i); i++;
            Map(m => m.Duration).Index(i); i++;
            Map(m => m.ApplicationID).Index(i); i++;
            Map(m => m.TierID).Index(i); i++;
            Map(m => m.ControllerLink).Index(i); i++;
            Map(m => m.ApplicationLink).Index(i); i++;
            Map(m => m.TierLink).Index(i); i++;
            Map(m => m.MetricLink).Index(i); i++;
        }
    }
}
