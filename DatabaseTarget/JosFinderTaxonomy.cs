using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosFinderTaxonomy
    {
        public uint Id { get; set; }
        public uint ParentId { get; set; }
        public string Title { get; set; }
        public byte State { get; set; }
        public byte Access { get; set; }
        public byte Ordering { get; set; }
    }
}
