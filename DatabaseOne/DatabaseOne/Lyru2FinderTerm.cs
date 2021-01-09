using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2FinderTerm
    {
        public int TermId { get; set; }
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
