using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosSppagebuilderSection
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Section { get; set; }
        public DateTime Created { get; set; }
        public long CreatedBy { get; set; }
    }
}
