using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosNbordersTemplate
    {
        public int Id { get; set; }
        public string TemplateHeader { get; set; }
        public string TemplateBody { get; set; }
        public string TemplateFooter { get; set; }
        public string TemplateDefault { get; set; }
    }
}
