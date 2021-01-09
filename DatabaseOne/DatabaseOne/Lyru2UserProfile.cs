using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2UserProfile
    {
        public int UserId { get; set; }
        public string ProfileKey { get; set; }
        public string ProfileValue { get; set; }
        public int Ordering { get; set; }
    }
}
