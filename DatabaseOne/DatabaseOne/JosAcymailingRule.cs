using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingRule
    {
        public ushort Ruleid { get; set; }
        public string Name { get; set; }
        public short? Ordering { get; set; }
        public string Regex { get; set; }
        public string ExecutedOn { get; set; }
        public string ActionMessage { get; set; }
        public string ActionUser { get; set; }
        public byte Published { get; set; }
    }
}
