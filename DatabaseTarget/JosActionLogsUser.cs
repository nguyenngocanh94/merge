using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosActionLogsUser
    {
        public uint UserId { get; set; }
        public byte Notify { get; set; }
        public string Extensions { get; set; }
    }
}
