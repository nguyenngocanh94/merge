using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosTemplateStyle
    {
        public int Id { get; set; }
        public string Template { get; set; }
        public byte ClientId { get; set; }
        public string Home { get; set; }
        public string Title { get; set; }
        public string Params { get; set; }
    }
}
