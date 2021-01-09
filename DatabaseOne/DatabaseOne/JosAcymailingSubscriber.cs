using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingSubscriber
    {
        public int Subid { get; set; }
        public string Email { get; set; }
        public int Userid { get; set; }
        public string Name { get; set; }
        public int? Created { get; set; }
        public sbyte Confirmed { get; set; }
        public sbyte Enabled { get; set; }
        public sbyte Accept { get; set; }
        public string Ip { get; set; }
        public sbyte Html { get; set; }
        public string Key { get; set; }
        public int ConfirmedDate { get; set; }
        public string ConfirmedIp { get; set; }
        public int LastopenDate { get; set; }
        public int LastclickDate { get; set; }
        public string LastopenIp { get; set; }
        public int LastsentDate { get; set; }
        public string Source { get; set; }
    }
}
