using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseTwo
{
    public partial class JosUserUsergroupMap : EntityUtilities
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}
