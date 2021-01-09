using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2FinderTaxonomy
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Title { get; set; }
        public byte State { get; set; }
        public byte Access { get; set; }
        public byte Ordering { get; set; }
    }
}
