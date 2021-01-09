using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2RedirectLink
    {
        public int Id { get; set; }
        public string OldUrl { get; set; }
        public string NewUrl { get; set; }
        public string Referer { get; set; }
        public string Comment { get; set; }
        public int Hits { get; set; }
        public sbyte Published { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public short Header { get; set; }
    }
}
