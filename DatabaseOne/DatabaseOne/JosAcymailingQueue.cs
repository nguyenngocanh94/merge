using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingQueue
    {
        public int Senddate { get; set; }
        public int Subid { get; set; }
        public int Mailid { get; set; }
        public byte? Priority { get; set; }
        public byte Try { get; set; }
        public string Paramqueue { get; set; }
    }
}
