using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosRevsliderStaticSlide
    {
        public int Id { get; set; }
        public int SliderId { get; set; }
        public string Params { get; set; }
        public string Layers { get; set; }
    }
}
