using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformConditionDetail
    {
        public int Id { get; set; }
        public int ConditionId { get; set; }
        public int ComponentId { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
    }
}
