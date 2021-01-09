using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosSpsimpleportfolioItem
    {
        public ulong Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public int Catid { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string Tagids { get; set; }
        public string Url { get; set; }
        public sbyte Published { get; set; }
        public string Language { get; set; }
        public int Access { get; set; }
        public int Ordering { get; set; }
        public long CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
        public long CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
    }
}
