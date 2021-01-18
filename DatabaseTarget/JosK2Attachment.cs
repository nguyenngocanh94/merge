using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosK2Attachment
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Filename { get; set; }
        public string Title { get; set; }
        public string TitleAttribute { get; set; }
        public int Hits { get; set; }
    }
}
