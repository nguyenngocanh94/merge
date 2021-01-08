using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class Lyru2FinderTokensAggregate
    {
        public uint TermId { get; set; }
        public string MapSuffix { get; set; }
        public string Term { get; set; }
        public string Stem { get; set; }
        public byte Common { get; set; }
        public byte Phrase { get; set; }
        public float TermWeight { get; set; }
        public byte Context { get; set; }
        public float ContextWeight { get; set; }
        public float TotalWeight { get; set; }
        public string Language { get; set; }
    }
}
