using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAllvideoshareCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Parent { get; set; }
        public string Type { get; set; }
        public string Thumb { get; set; }
        public string Access { get; set; }
        public int Ordering { get; set; }
        public string Metakeywords { get; set; }
        public string Metadescription { get; set; }
        public sbyte Published { get; set; }
    }
}
