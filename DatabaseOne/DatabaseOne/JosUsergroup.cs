using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosUsergroup
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int Lft { get; set; }
        public int Rgt { get; set; }
        public string Title { get; set; }
    }
}
