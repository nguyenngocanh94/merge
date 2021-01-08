using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAdmintoolsWafblacklist
    {
        public ulong Id { get; set; }
        public string Option { get; set; }
        public string View { get; set; }
        public string Task { get; set; }
        public string Query { get; set; }
        public string QueryType { get; set; }
        public string QueryContent { get; set; }
        public string Verb { get; set; }
        public sbyte Enabled { get; set; }
    }
}
