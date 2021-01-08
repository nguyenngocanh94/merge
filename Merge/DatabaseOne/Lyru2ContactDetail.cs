using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2ContactDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string ConPosition { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Misc { get; set; }
        public string Image { get; set; }
        public string EmailTo { get; set; }
        public byte DefaultCon { get; set; }
        public bool Published { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public string Params { get; set; }
        public int UserId { get; set; }
        public int Catid { get; set; }
        public uint Access { get; set; }
        public string Mobile { get; set; }
        public string Webpage { get; set; }
        public string Sortname1 { get; set; }
        public string Sortname2 { get; set; }
        public string Sortname3 { get; set; }
        public string Language { get; set; }
        public DateTime Created { get; set; }
        public uint CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public DateTime Modified { get; set; }
        public uint ModifiedBy { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public string Metadata { get; set; }
        public byte Featured { get; set; }
        public string Xreference { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public uint Version { get; set; }
        public uint Hits { get; set; }
    }
}
