using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingListsub
    {
        public ushort Listid { get; set; }
        public int Subid { get; set; }
        public int? Subdate { get; set; }
        public int? Unsubdate { get; set; }
        public sbyte Status { get; set; }
    }
}
