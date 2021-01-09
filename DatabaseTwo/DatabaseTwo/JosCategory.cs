using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosCategory
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public int ParentId { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public int Level { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Access { get; set; }
        public string Params { get; set; }
        public string Metadesc { get; set; }
        public string Metakey { get; set; }
        public string Metadata { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int Hits { get; set; }
        public string Language { get; set; }
        public int Version { get; set; }
    }
}
