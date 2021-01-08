using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAimysitemapCrawl
    {
        public byte[] Url { get; set; }
        public bool Crawled { get; set; }
        public bool Index { get; set; }
        public string Title { get; set; }
        public long Mtime { get; set; }
        public string Lang { get; set; }
    }
}
