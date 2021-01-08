using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAcymailingQueue
    {
        public uint Senddate { get; set; }
        public uint Subid { get; set; }
        public uint Mailid { get; set; }
        public byte? Priority { get; set; }
        public byte Try { get; set; }
        public string Paramqueue { get; set; }
    }
}
