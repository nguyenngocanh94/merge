using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosK2Rating
    {
        public int ItemId { get; set; }
        public int RatingSum { get; set; }
        public int RatingCount { get; set; }
        public string Lastip { get; set; }
    }
}
