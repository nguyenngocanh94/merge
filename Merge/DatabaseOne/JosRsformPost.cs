using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformPost
    {
        public int FormId { get; set; }
        public bool Enabled { get; set; }
        public bool Method { get; set; }
        public string Fields { get; set; }
        public bool Silent { get; set; }
        public string Url { get; set; }
    }
}
