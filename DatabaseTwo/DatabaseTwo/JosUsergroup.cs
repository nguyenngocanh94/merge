using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
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
