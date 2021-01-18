using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosViewlevel
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public int Ordering { get; set; }
        public string Rules { get; set; }
    }
}
