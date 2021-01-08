using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2RedirectLink
    {
        public uint Id { get; set; }
        public string OldUrl { get; set; }
        public string NewUrl { get; set; }
        public string Referer { get; set; }
        public string Comment { get; set; }
        public uint Hits { get; set; }
        public sbyte Published { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public short Header { get; set; }
    }
}
