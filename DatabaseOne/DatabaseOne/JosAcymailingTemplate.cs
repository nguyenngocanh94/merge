using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAcymailingTemplate
    {
        public ushort Tempid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string Altbody { get; set; }
        public int? Created { get; set; }
        public sbyte Published { get; set; }
        public sbyte Premium { get; set; }
        public ushort? Ordering { get; set; }
        public string Namekey { get; set; }
        public string Styles { get; set; }
        public string Subject { get; set; }
        public string Stylesheet { get; set; }
        public string Fromname { get; set; }
        public string Fromemail { get; set; }
        public string Replyname { get; set; }
        public string Replyemail { get; set; }
        public string Thumb { get; set; }
        public string Readmore { get; set; }
        public string Access { get; set; }
        public string Category { get; set; }
    }
}
