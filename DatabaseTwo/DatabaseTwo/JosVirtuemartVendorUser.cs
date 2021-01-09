using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartVendorUser
    {
        public int Id { get; set; }
        public int VirtuemartVendorId { get; set; }
        public int VirtuemartUserId { get; set; }
    }
}
