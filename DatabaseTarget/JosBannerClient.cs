using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosBannerClient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Extrainfo { get; set; }
        public sbyte State { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public string Metakey { get; set; }
        public sbyte OwnPrefix { get; set; }
        public string MetakeyPrefix { get; set; }
        public sbyte PurchaseType { get; set; }
        public sbyte TrackClicks { get; set; }
        public sbyte TrackImpressions { get; set; }
    }
}
