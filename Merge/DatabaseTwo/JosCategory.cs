using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosCategory
    {
        public int Id { get; set; }
        public uint AssetId { get; set; }
        public uint ParentId { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public uint Level { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public uint CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public uint Access { get; set; }
        public string Params { get; set; }
        public string Metadesc { get; set; }
        public string Metakey { get; set; }
        public string Metadata { get; set; }
        public uint CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public uint ModifiedUserId { get; set; }
        public DateTime ModifiedTime { get; set; }
        public uint Hits { get; set; }
        public string Language { get; set; }
        public uint Version { get; set; }
    }
}
