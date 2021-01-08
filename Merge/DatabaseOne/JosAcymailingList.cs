using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAcymailingList
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ushort? Ordering { get; set; }
        public ushort Listid { get; set; }
        public sbyte? Published { get; set; }
        public uint? Userid { get; set; }
        public string Alias { get; set; }
        public string Color { get; set; }
        public sbyte Visible { get; set; }
        public int? Welmailid { get; set; }
        public int? Unsubmailid { get; set; }
        public string Type { get; set; }
        public string AccessSub { get; set; }
        public string AccessManage { get; set; }
        public string Languages { get; set; }
        public string Startrule { get; set; }
        public string Category { get; set; }
    }
}
