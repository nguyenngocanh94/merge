using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosDjimageslider
    {
        public int Id { get; set; }
        public int Catid { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public string Params { get; set; }
    }
}
