using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosUserProfile
    {
        public int UserId { get; set; }
        public string ProfileKey { get; set; }
        public string ProfileValue { get; set; }
        public int Ordering { get; set; }
    }
}
