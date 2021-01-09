using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosContentType
    {
        public int TypeId { get; set; }
        public string TypeTitle { get; set; }
        public string TypeAlias { get; set; }
        public string Table { get; set; }
        public string Rules { get; set; }
        public string FieldMappings { get; set; }
        public string Router { get; set; }
        public string ContentHistoryOptions { get; set; }
    }
}
