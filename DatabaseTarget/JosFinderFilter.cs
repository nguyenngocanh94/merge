using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosFinderFilter
    {
        public uint FilterId { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public bool? State { get; set; }
        public DateTime Created { get; set; }
        public uint CreatedBy { get; set; }
        public string CreatedByAlias { get; set; }
        public DateTime Modified { get; set; }
        public uint ModifiedBy { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public uint MapCount { get; set; }
        public string Data { get; set; }
        public string Params { get; set; }
    }
}
