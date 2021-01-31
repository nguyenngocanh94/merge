using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosNextendSmartsliderSlide
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Slider { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public int Published { get; set; }
        public int First { get; set; }
        public string Slide { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string Background { get; set; }
        public string Params { get; set; }
        public int Ordering { get; set; }
        public int Generator { get; set; }
    }
}
