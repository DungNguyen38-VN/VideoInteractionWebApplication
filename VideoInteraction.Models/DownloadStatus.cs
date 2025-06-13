using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.Models
{
    public static class DownloadStatus
    {
        public const int Failed = -1;
        public const int NotStarted = 0;
        public const int InProgress = 1;
        public const int Completed = 2;
        public const int OnAlarm = 3;

        public static string GetStatusString(int status)
        {
            return status switch
            {
                Failed => "Failed",
                NotStarted => "Not Started",
                InProgress => "In Progress",
                Completed => "Completed",
                OnAlarm => "OnAlarm",
                _ => "Unknown"
            };
        }
    }
}
