using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosJcommentsSmily
    {
        public uint Id { get; set; }
        public string Code { get; set; }
        public string Alias { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public bool Published { get; set; }
        public uint Ordering { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
    }
}
