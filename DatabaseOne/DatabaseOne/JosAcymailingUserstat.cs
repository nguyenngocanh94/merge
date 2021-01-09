using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingUserstat
    {
        public int Mailid { get; set; }
        public int Subid { get; set; }
        public byte Html { get; set; }
        public byte Sent { get; set; }
        public int Senddate { get; set; }
        public byte Open { get; set; }
        public int Opendate { get; set; }
        public sbyte Bounce { get; set; }
        public sbyte Fail { get; set; }
        public string Ip { get; set; }
        public string Browser { get; set; }
        public byte? BrowserVersion { get; set; }
        public byte? IsMobile { get; set; }
        public string MobileOs { get; set; }
        public string UserAgent { get; set; }
        public string Bouncerule { get; set; }
    }
}
