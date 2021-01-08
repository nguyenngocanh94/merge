using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAcymailingHistory
    {
        public uint Subid { get; set; }
        public uint Date { get; set; }
        public string Ip { get; set; }
        public string Action { get; set; }
        public string Data { get; set; }
        public string Source { get; set; }
        public uint? Mailid { get; set; }
    }
}
