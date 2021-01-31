using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosNewsfeed
    {
        public int Catid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Link { get; set; }
        public int Published { get; set; }
        public int Numarticles { get; set; }
        public int CacheTime { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public sbyte Rtl { get; set; }
        public int Access { get; set; }
        public string Language { get; set; }
        public string Params { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public string Metadata { get; set; }
        public string Xreference { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public string Description { get; set; }
        public int Version { get; set; }
        public int Hits { get; set; }
        public string Images { get; set; }
    }
}
