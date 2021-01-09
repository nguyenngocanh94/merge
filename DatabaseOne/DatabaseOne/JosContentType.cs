using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
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
