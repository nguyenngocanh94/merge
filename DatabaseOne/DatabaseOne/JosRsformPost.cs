using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosRsformPost
    {
        public int FormId { get; set; }
        public int Enabled { get; set; }
        public int Method { get; set; }
        public string Fields { get; set; }
        public int Silent { get; set; }
        public string Url { get; set; }
    }
}
