using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosContent
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Introtext { get; set; }
        public string Fulltext { get; set; }
        public sbyte State { get; set; }
        public int Catid { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public string Images { get; set; }
        public string Urls { get; set; }
        public string Attribs { get; set; }
        public int Version { get; set; }
        public int Ordering { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public int Access { get; set; }
        public int Hits { get; set; }
        public string Metadata { get; set; }
        public byte Featured { get; set; }
        public string Language { get; set; }
        public string Xreference { get; set; }
        public string TitleAlias { get; set; }
        public string Sectionid { get; set; }
        public string Mask { get; set; }
        public string Parentid { get; set; }
    }
}
