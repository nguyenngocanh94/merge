using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosTemplateStyle
    {
        public uint Id { get; set; }
        public string Template { get; set; }
        public byte ClientId { get; set; }
        public string Home { get; set; }
        public string Title { get; set; }
        public string Params { get; set; }
    }
}
