using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosNbordersMailsended
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string OrderPrefix { get; set; }
        public int? OrderNo { get; set; }
        public int? OrderMailed { get; set; }
        public int? DnMailed { get; set; }
        public int? OrderGenerated { get; set; }
        public int? DnGenerated { get; set; }
        public int? OrderDate { get; set; }
        public int? OrderLastchanged { get; set; }
    }
}
