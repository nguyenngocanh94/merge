using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosOsmapSitemap
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Introtext { get; set; }
        public string Metadesc { get; set; }
        public string Metakey { get; set; }
        public string Attribs { get; set; }
        public string Selections { get; set; }
        public string ExcludedItems { get; set; }
        public int? IsDefault { get; set; }
        public int? State { get; set; }
        public int? Access { get; set; }
        public DateTime Created { get; set; }
        public int? CountXml { get; set; }
        public int? CountHtml { get; set; }
        public int? ViewsXml { get; set; }
        public int? ViewsHtml { get; set; }
        public int? LastvisitXml { get; set; }
        public int? LastvisitHtml { get; set; }
    }
}
