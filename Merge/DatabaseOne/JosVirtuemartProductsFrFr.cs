using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVirtuemartProductsFrFr : EntityUtilities
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
