using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosContentRating
    {
        public int ContentId { get; set; }
        public uint RatingSum { get; set; }
        public uint RatingCount { get; set; }
        public string Lastip { get; set; }
    }
}
