using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAllvideoshareVideo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public int Catid { get; set; }
        public string Category { get; set; }
        public string User { get; set; }
        public string Type { get; set; }
        public string Streamer { get; set; }
        public sbyte Dvr { get; set; }
        public string Token { get; set; }
        public string Video { get; set; }
        public string Hd { get; set; }
        public string Hls { get; set; }
        public string Thumb { get; set; }
        public string Preview { get; set; }
        public string Thirdparty { get; set; }
        public sbyte Featured { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string Metadescription { get; set; }
        public int Views { get; set; }
        public string Access { get; set; }
        public int Ordering { get; set; }
        public sbyte Published { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
