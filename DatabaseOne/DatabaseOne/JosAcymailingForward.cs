using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingForward
    {
        public int Subid { get; set; }
        public int Mailid { get; set; }
        public int Date { get; set; }
        public string Ip { get; set; }
        public int Nbforwarded { get; set; }
    }
}
