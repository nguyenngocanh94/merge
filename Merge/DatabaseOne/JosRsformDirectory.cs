using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosRsformDirectory
    {
        public int FormId { get; set; }
        public string Filename { get; set; }
        public bool Enablepdf { get; set; }
        public bool Enablecsv { get; set; }
        public string ViewLayout { get; set; }
        public string ViewLayoutName { get; set; }
        public bool ViewLayoutAutogenerate { get; set; }
        public string Css { get; set; }
        public string Js { get; set; }
        public string ListScript { get; set; }
        public string DetailsScript { get; set; }
        public string EmailsScript { get; set; }
        public string Groups { get; set; }
    }
}
