using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosFinderToken
    {
        public string Term { get; set; }
        public string Stem { get; set; }
        public byte Common { get; set; }
        public byte Phrase { get; set; }
        public float Weight { get; set; }
        public byte Context { get; set; }
        public string Language { get; set; }
    }
}
