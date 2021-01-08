using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2FinderTaxonomy
    {
        public uint Id { get; set; }
        public uint ParentId { get; set; }
        public string Title { get; set; }
        public byte State { get; set; }
        public byte Access { get; set; }
        public byte Ordering { get; set; }
    }
}
