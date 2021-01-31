using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosWeblink
    {
        public int Id { get; set; }
        public int Catid { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int Hits { get; set; }
        public int State { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public int Access { get; set; }
        public string Params { get; set; }
        public string Language { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public string Metadata { get; set; }
        public byte Featured { get; set; }
        public string Xreference { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public int Version { get; set; }
        public string Images { get; set; }
    }
}
