using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAdmintoolsWaftemplate
    {
        public ulong AdmintoolsWaftemplateId { get; set; }
        public string Reason { get; set; }
        public string Language { get; set; }
        public string Subject { get; set; }
        public string Template { get; set; }
        public sbyte Enabled { get; set; }
        public byte EmailNum { get; set; }
        public byte EmailNumfreq { get; set; }
        public string EmailFreq { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public long ModifiedBy { get; set; }
    }
}
