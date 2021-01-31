using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosFinderLink
    {
        public int LinkId { get; set; }
        public string Url { get; set; }
        public string Route { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Indexdate { get; set; }
        public string Md5sum { get; set; }
        public int? Published { get; set; }
        public int? State { get; set; }
        public int? Access { get; set; }
        public string Language { get; set; }
        public DateTime PublishStartDate { get; set; }
        public DateTime PublishEndDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double ListPrice { get; set; }
        public double SalePrice { get; set; }
        public int TypeId { get; set; }
        public byte[] Object { get; set; }
    }
}
