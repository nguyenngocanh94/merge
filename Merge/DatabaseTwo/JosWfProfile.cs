using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosWfProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Users { get; set; }
        public string Types { get; set; }
        public string Components { get; set; }
        public sbyte Area { get; set; }
        public string Device { get; set; }
        public string Rows { get; set; }
        public string Plugins { get; set; }
        public sbyte Published { get; set; }
        public int Ordering { get; set; }
        public sbyte CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public string Params { get; set; }
    }
}
