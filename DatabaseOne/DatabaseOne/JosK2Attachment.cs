using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
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
