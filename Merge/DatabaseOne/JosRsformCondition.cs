using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformCondition
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Action { get; set; }
        public bool Block { get; set; }
        public int ComponentId { get; set; }
        public string Condition { get; set; }
        public string LangCode { get; set; }
    }
}
