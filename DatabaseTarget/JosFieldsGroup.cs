using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosFieldsGroup
    {
        public uint Id { get; set; }
        public uint AssetId { get; set; }
        public string Context { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public string Params { get; set; }
        public string Language { get; set; }
        public DateTime Created { get; set; }
        public uint CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public uint ModifiedBy { get; set; }
        public int Access { get; set; }
    }
}
