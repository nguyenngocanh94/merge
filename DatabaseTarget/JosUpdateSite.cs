using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosUpdateSite
    {
        public int UpdateSiteId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public int? Enabled { get; set; }
        public long? LastCheckTimestamp { get; set; }
        public string ExtraQuery { get; set; }
    }
}
