using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosBanner
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public int Imptotal { get; set; }
        public int Impmade { get; set; }
        public int Clicks { get; set; }
        public string Clickurl { get; set; }
        public sbyte State { get; set; }
        public uint Catid { get; set; }
        public string Description { get; set; }
        public string Custombannercode { get; set; }
        public byte Sticky { get; set; }
        public int Ordering { get; set; }
        public string Metakey { get; set; }
        public string Params { get; set; }
        public bool OwnPrefix { get; set; }
        public string MetakeyPrefix { get; set; }
        public sbyte PurchaseType { get; set; }
        public sbyte TrackClicks { get; set; }
        public sbyte TrackImpressions { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public DateTime Reset { get; set; }
        public DateTime Created { get; set; }
        public string Language { get; set; }
        public uint CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public DateTime Modified { get; set; }
        public uint ModifiedBy { get; set; }
        public uint Version { get; set; }
    }
}
