using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosUserUsergroupMap : EntityUtilities
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}
