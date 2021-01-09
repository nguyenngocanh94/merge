using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2ContentRating
    {
        public int ContentId { get; set; }
        public int RatingSum { get; set; }
        public int RatingCount { get; set; }
        public string Lastip { get; set; }
    }
}
