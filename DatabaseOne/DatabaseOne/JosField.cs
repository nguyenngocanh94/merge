using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosField
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public string Context { get; set; }
        public int GroupId { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string DefaultValue { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string Description { get; set; }
        public bool State { get; set; }
        public bool Required { get; set; }
        public int CheckedOut { get; set; }
        public DateTime CheckedOutTime { get; set; }
        public int Ordering { get; set; }
        public string Params { get; set; }
        public string Fieldparams { get; set; }
        public string Language { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime ModifiedTime { get; set; }
        public int ModifiedBy { get; set; }
        public int Access { get; set; }
    }
}
