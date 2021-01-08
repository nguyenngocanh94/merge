using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2Newsfeed
    {
        public int Catid { get; set; }
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Link { get; set; }
        public bool Published { get; set; }
        public uint Numarticles { get; set; }
        public uint CacheTime { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public sbyte Rtl { get; set; }
        public uint Access { get; set; }
        public string Language { get; set; }
        public string Params { get; set; }
        public DateTime Created { get; set; }
        public uint CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public DateTime Modified { get; set; }
        public uint ModifiedBy { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public string Metadata { get; set; }
        public string Xreference { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public string Description { get; set; }
        public uint Version { get; set; }
        public uint Hits { get; set; }
        public string Images { get; set; }
    }
}
