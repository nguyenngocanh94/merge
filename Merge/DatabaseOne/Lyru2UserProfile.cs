using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2UserProfile
    {
        public int UserId { get; set; }
        public string ProfileKey { get; set; }
        public string ProfileValue { get; set; }
        public int Ordering { get; set; }
    }
}
