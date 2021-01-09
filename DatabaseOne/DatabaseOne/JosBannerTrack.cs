using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosBannerTrack
    {
        public DateTime TrackDate { get; set; }
        public int TrackType { get; set; }
        public int BannerId { get; set; }
        public int Count { get; set; }
    }
}
