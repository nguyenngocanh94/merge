using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosJcommentsSmily
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Alias { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Published { get; set; }
        public int Ordering { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
    }
}
