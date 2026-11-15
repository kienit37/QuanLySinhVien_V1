using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Common.Logging
{
    public class LogSettings
    {
        public bool EnableLogging { get; set; } = true;

        public LogLevel MinimumLevel { get; set; }
            = LogLevel.Information;

        public int RetentionDays { get; set; } = 30;

        public long SlowOperationThresholdMs { get; set; }
            = 1000;
    }
}

