using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartProductsEnGb : EntityUtilities, ISlug
    {
        public int VirtuemartProductId { get; set; }
        public string ProductSDesc { get; set; }
        public string ProductDesc { get; set; }
        public string ProductName { get; set; }
        public string Metadesc { get; set; }
        public string Metakey { get; set; }
        public string Customtitle { get; set; }
        public string Slug { get; set; }
    }
}
