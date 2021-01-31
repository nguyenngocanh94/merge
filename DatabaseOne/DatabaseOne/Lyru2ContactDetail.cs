using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
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
        public int Published { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public string Params { get; set; }
        public int UserId { get; set; }
        public int Catid { get; set; }
        public int Access { get; set; }
        public string Mobile { get; set; }
        public string Webpage { get; set; }
        public string Sortname1 { get; set; }
        public string Sortname2 { get; set; }
        public string Sortname3 { get; set; }
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
        public int Hits { get; set; }
    }
}
