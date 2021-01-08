using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAimysitemap
    {
        public uint Id { get; set; }
        public byte[] Url { get; set; }
        public string Title { get; set; }
        public float Priority { get; set; }
        public long Mtime { get; set; }
        public string Lang { get; set; }
        public bool State { get; set; }
        public bool Lock { get; set; }
        public string Changefreq { get; set; }
    }
}
