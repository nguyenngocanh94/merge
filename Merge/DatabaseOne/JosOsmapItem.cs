using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosOsmapItem
    {
        public string Uid { get; set; }
        public int Itemid { get; set; }
        public string View { get; set; }
        public int SitemapId { get; set; }
        public string Properties { get; set; }
    }
}
