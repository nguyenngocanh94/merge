using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosField
    {
        public uint Id { get; set; }
        public uint AssetId { get; set; }
        public string Context { get; set; }
        public uint GroupId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string DefaultValue { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public bool Required { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public string Params { get; set; }
        public string Fieldparams { get; set; }
        public string Language { get; set; }
        public DateTime CreatedTime { get; set; }
        public uint CreatedUserId { get; set; }
        public DateTime ModifiedTime { get; set; }
        public uint ModifiedBy { get; set; }
        public int Access { get; set; }
    }
}
