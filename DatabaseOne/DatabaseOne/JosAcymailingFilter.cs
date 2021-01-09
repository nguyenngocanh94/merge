using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingFilter
    {
        public int Filid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte? Published { get; set; }
        public int? Lasttime { get; set; }
        public string Trigger { get; set; }
        public string Report { get; set; }
        public string Action { get; set; }
        public string Filter { get; set; }
    }
}
