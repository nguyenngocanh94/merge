using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosAllvideoshareAdvert
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Method { get; set; }
        public string Video { get; set; }
        public string Link { get; set; }
        public int Impressions { get; set; }
        public int Clicks { get; set; }
        public sbyte Published { get; set; }
    }
}
