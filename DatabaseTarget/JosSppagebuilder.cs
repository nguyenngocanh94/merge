using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosSppagebuilder
    {
        public ulong Id { get; set; }
        public int AssetId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Extension { get; set; }
        public string ExtensionView { get; set; }
        public long ViewId { get; set; }
        public bool Active { get; set; }
        public sbyte Published { get; set; }
        public int Catid { get; set; }
        public int Access { get; set; }
        public int Ordering { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public long ModifiedBy { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public string Attribs { get; set; }
        public string OgTitle { get; set; }
        public string OgImage { get; set; }
        public string OgDescription { get; set; }
        public string Language { get; set; }
        public long Hits { get; set; }
        public string Css { get; set; }
    }
}
