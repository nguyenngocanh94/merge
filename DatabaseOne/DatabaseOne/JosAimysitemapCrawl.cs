using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAimysitemapCrawl
    {
        public byte[] Url { get; set; }
        public int Crawled { get; set; }
        public int Index { get; set; }
        public string Title { get; set; }
        public long Mtime { get; set; }
        public string Lang { get; set; }
    }
}
