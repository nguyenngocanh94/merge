using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAcymailingFilter
    {
        public uint Filid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? Published { get; set; }
        public uint? Lasttime { get; set; }
        public string Trigger { get; set; }
        public string Report { get; set; }
        public string Action { get; set; }
        public string Filter { get; set; }
    }
}
