using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2Usergroup
    {
        public uint Id { get; set; }
        public uint ParentId { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public string Title { get; set; }
    }
}
