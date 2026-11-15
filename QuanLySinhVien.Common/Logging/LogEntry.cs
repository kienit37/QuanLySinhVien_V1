using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Common.Logging
{
    public class LogEntry
    {
        public DateTimeOffset Timestamp { get; set; }

        public string Level { get; set; } = "";

        public string Action { get; set; } = "";

        public string Username { get; set; } = "";

        public string Message { get; set; } = "";

        public long? DurationMs { get; set; }

        public string? ExceptionType { get; set; }

        public string? ErrorId { get; set; }
    }
}
