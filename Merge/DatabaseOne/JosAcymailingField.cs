using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAcymailingField
    {
        public ushort Fieldid { get; set; }
        public string Fieldname { get; set; }
        public string Namekey { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public byte Published { get; set; }
        public ushort? Ordering { get; set; }
        public string Options { get; set; }
        public byte Core { get; set; }
        public byte Required { get; set; }
        public byte Backend { get; set; }
        public byte Frontcomp { get; set; }
        public string Default { get; set; }
        public byte? Listing { get; set; }
        public byte Frontlisting { get; set; }
        public byte Frontjoomlaprofile { get; set; }
        public byte Frontjoomlaregistration { get; set; }
        public byte Joomlaprofile { get; set; }
        public string Access { get; set; }
        public int Fieldcat { get; set; }
        public sbyte? Listingfilter { get; set; }
        public sbyte? Frontlistingfilter { get; set; }
        public sbyte? Frontform { get; set; }
    }
}
