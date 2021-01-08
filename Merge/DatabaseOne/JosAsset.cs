using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAsset
    {
        public uint Id { get; set; }
        public int ParentId { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public uint Level { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Rules { get; set; }
    }
}
