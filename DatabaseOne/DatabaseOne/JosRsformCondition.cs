using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosRsformCondition
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Action { get; set; }
        public int Block { get; set; }
        public int ComponentId { get; set; }
        public string Condition { get; set; }
        public string LangCode { get; set; }
    }
}
