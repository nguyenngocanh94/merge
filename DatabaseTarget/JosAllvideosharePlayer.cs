using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosAllvideosharePlayer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Ratio { get; set; }
        public sbyte Loop { get; set; }
        public sbyte Autostart { get; set; }
        public int Buffer { get; set; }
        public int Volumelevel { get; set; }
        public string Stretch { get; set; }
        public sbyte Controlbar { get; set; }
        public sbyte Playlist { get; set; }
        public sbyte Durationdock { get; set; }
        public sbyte Timerdock { get; set; }
        public sbyte Fullscreendock { get; set; }
        public sbyte Hddock { get; set; }
        public sbyte Embeddock { get; set; }
        public sbyte Sharedock { get; set; }
        public sbyte Facebookdock { get; set; }
        public sbyte Twitterdock { get; set; }
        public string Controlbaroutlinecolor { get; set; }
        public string Controlbarbgcolor { get; set; }
        public string Controlbaroverlaycolor { get; set; }
        public int Controlbaroverlayalpha { get; set; }
        public string Iconcolor { get; set; }
        public string Progressbarbgcolor { get; set; }
        public string Progressbarbuffercolor { get; set; }
        public string Progressbarseekcolor { get; set; }
        public string Volumebarbgcolor { get; set; }
        public string Volumebarseekcolor { get; set; }
        public string Playlistbgcolor { get; set; }
        public string Customplayerpage { get; set; }
        public string AdEngine { get; set; }
        public sbyte Preroll { get; set; }
        public sbyte Postroll { get; set; }
        public string VastUrl { get; set; }
        public string VpaidMode { get; set; }
        public int LivestreamAdInterval { get; set; }
        public sbyte Published { get; set; }
    }
}
