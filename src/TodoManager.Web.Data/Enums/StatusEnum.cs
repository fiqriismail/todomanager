using System;
using System.Collections.Generic;
using System.Text;

namespace TodoManager.Web.Data.Enums
{
    public class StatusEnum
    {
        public enum Status
        {
            New = 0,
            InProgress = 1,
            Completed = 2,
            Cancelled = 3
        }
    }
}
