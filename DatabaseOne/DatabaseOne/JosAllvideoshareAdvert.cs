using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
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
