using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosActionLogConfig
    {
        public uint Id { get; set; }
        public string TypeTitle { get; set; }
        public string TypeAlias { get; set; }
        public string IdHolder { get; set; }
        public string TitleHolder { get; set; }
        public string TableName { get; set; }
        public string TextPrefix { get; set; }
    }
}
