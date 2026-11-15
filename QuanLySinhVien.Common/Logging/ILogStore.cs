using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Common.Logging
{
    public interface ILogStore
    {
        void Save(LogEntry log);
    }
}
