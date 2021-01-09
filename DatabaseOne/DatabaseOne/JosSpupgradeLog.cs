using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosSpupgradeLog
    {
        public int Id { get; set; }
        public int TablesId { get; set; }
        public string Note { get; set; }
        public sbyte State { get; set; }
        public int SourceId { get; set; }
        public int DestinationId { get; set; }
        public DateTime Created { get; set; }
        public string Data { get; set; }
    }
}
