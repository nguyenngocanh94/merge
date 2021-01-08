using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosJcommentsBlacklist
    {
        public uint Id { get; set; }
        public string Ip { get; set; }
        public uint Userid { get; set; }
        public DateTime Created { get; set; }
        public uint CreatedBy { get; set; }
        public DateTime Expire { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public string Editor { get; set; }
    }
}
