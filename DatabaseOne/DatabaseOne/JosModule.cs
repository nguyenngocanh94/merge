using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosModule
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Content { get; set; }
        public int Ordering { get; set; }
        public string Position { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public DateTime PublishUp { get; set; }
        public DateTime PublishDown { get; set; }
        public int Published { get; set; }
        public string Module { get; set; }
        public int Access { get; set; }
        public byte Showtitle { get; set; }
        public string Params { get; set; }
        public sbyte ClientId { get; set; }
        public string Language { get; set; }
    }
}
