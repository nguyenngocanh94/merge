using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
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
