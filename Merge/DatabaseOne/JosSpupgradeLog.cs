using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosSpupgradeLog
    {
        public uint Id { get; set; }
        public uint TablesId { get; set; }
        public string Note { get; set; }
        public sbyte State { get; set; }
        public uint SourceId { get; set; }
        public uint DestinationId { get; set; }
        public DateTime Created { get; set; }
        public string Data { get; set; }
    }
}
