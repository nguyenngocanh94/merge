using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2Language
    {
        public uint LangId { get; set; }
        public string LangCode { get; set; }
        public string Title { get; set; }
        public string TitleNative { get; set; }
        public string Sef { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public string Sitename { get; set; }
        public int Published { get; set; }
        public uint Access { get; set; }
        public int Ordering { get; set; }
    }
}
