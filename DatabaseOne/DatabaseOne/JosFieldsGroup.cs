using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosFieldsGroup
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public string Context { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public string Language { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public int ModifiedBy { get; set; }
        public int Access { get; set; }
    }
}
