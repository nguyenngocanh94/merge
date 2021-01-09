using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosSpmedium
    {
        public ulong Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public string Thumb { get; set; }
        public string Alt { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public long ModifiedBy { get; set; }
    }
}
