using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAkProfile
    {
        public uint Id { get; set; }
        public string Description { get; set; }
        public string Configuration { get; set; }
        public string Filters { get; set; }
        public sbyte Quickicon { get; set; }
    }
}
