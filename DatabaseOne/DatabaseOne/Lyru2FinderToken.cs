using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2FinderToken
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
