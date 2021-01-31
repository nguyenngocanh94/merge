﻿using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAimysitemap
    {
        public int Id { get; set; }
        public byte[] Url { get; set; }
        public string Title { get; set; }
        public float Priority { get; set; }
        public long Mtime { get; set; }
        public string Lang { get; set; }
        public int State { get; set; }
        public int Lock { get; set; }
        public string Changefreq { get; set; }
    }
}
