using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosVminvoice3Template
    {
        public int ConfigId { get; set; }
        public string Document { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public string Params { get; set; }
        public int LastTemplateChange { get; set; }
    }
}
