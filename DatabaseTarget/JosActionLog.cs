using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosActionLog
    {
        public uint Id { get; set; }
        public string MessageLanguageKey { get; set; }
        public string Message { get; set; }
        public DateTime LogDate { get; set; }
        public string Extension { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public string IpAddress { get; set; }
    }
}
