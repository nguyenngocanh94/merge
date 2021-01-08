using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosK2Category
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int? Parent { get; set; }
        public int ExtraFieldsGroup { get; set; }
        public short Published { get; set; }
        public int Access { get; set; }
        public int Ordering { get; set; }
        public string Image { get; set; }
        public string Params { get; set; }
        public short Trash { get; set; }
        public string Plugins { get; set; }
        public string Language { get; set; }
    }
}
