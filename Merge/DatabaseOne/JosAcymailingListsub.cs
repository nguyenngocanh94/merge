using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAcymailingListsub
    {
        public ushort Listid { get; set; }
        public uint Subid { get; set; }
        public uint? Subdate { get; set; }
        public uint? Unsubdate { get; set; }
        public sbyte Status { get; set; }
    }
}
