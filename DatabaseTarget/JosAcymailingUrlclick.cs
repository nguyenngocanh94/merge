using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosAcymailingUrlclick
    {
        public uint Urlid { get; set; }
        public uint Mailid { get; set; }
        public ushort Click { get; set; }
        public uint Subid { get; set; }
        public uint Date { get; set; }
        public string Ip { get; set; }
    }
}
