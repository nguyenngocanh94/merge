using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAdmintoolsScanalert
    {
        public long AdmintoolsScanalertId { get; set; }
        public string Path { get; set; }
        public long ScanId { get; set; }
        public string Diff { get; set; }
        public int ThreatScore { get; set; }
        public sbyte Acknowledged { get; set; }
    }
}
