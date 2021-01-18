using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosBannerTrack
    {
        public DateTime TrackDate { get; set; }
        public uint TrackType { get; set; }
        public uint BannerId { get; set; }
        public uint Count { get; set; }
    }
}
