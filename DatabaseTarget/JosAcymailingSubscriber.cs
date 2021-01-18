using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosAcymailingSubscriber
    {
        public uint Subid { get; set; }
        public string Email { get; set; }
        public uint Userid { get; set; }
        public string Name { get; set; }
        public uint? Created { get; set; }
        public sbyte Confirmed { get; set; }
        public sbyte Enabled { get; set; }
        public sbyte Accept { get; set; }
        public string Ip { get; set; }
        public sbyte Html { get; set; }
        public string Key { get; set; }
        public uint ConfirmedDate { get; set; }
        public string ConfirmedIp { get; set; }
        public uint LastopenDate { get; set; }
        public uint LastclickDate { get; set; }
        public string LastopenIp { get; set; }
        public uint LastsentDate { get; set; }
        public string Source { get; set; }
        public string Filterflags { get; set; }
    }
}
