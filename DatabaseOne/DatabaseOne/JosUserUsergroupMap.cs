using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosUserUsergroupMap : EntityUtilities
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}
