using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosK2Rating
    {
        public int ItemId { get; set; }
        public uint RatingSum { get; set; }
        public uint RatingCount { get; set; }
        public string Lastip { get; set; }
    }
}
