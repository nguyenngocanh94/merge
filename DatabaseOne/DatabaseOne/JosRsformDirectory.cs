﻿using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosRsformDirectory
    {
        public int FormId { get; set; }
        public string Filename { get; set; }
        public int Enablepdf { get; set; }
        public int Enablecsv { get; set; }
        public string ViewLayout { get; set; }
        public string ViewLayoutName { get; set; }
        public int ViewLayoutAutogenerate { get; set; }
        public string Css { get; set; }
        public string Js { get; set; }
        public string ListScript { get; set; }
        public string DetailsScript { get; set; }
        public string EmailsScript { get; set; }
        public string Groups { get; set; }
    }
}
