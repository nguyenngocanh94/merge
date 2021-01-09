using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2UpdateSite
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
