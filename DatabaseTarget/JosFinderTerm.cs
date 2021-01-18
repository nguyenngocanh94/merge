using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosFinderTerm
    {
        public uint TermId { get; set; }
        public string Term { get; set; }
        public string Stem { get; set; }
        public byte Common { get; set; }
        public byte Phrase { get; set; }
        public float Weight { get; set; }
        public string Soundex { get; set; }
        public int Links { get; set; }
        public string Language { get; set; }
    }
}
