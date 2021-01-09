using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingUrlclick
    {
        public int Urlid { get; set; }
        public int Mailid { get; set; }
        public ushort Click { get; set; }
        public int Subid { get; set; }
        public int Date { get; set; }
        public string Ip { get; set; }
    }
}
