using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAmpzStat
    {
        public uint Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Network { get; set; }
        public string Position { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
    }
}
