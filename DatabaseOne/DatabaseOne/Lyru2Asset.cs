using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2Asset
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Rules { get; set; }
    }
}
