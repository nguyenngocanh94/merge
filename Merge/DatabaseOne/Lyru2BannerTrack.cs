using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2BannerTrack
    {
        public DateTime TrackDate { get; set; }
        public uint TrackType { get; set; }
        public uint BannerId { get; set; }
        public uint Count { get; set; }
    }
}
