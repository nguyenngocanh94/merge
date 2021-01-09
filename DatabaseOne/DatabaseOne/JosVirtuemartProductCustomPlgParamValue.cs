using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartProductCustomPlgParamValue
    {
        public int Id { get; set; }
        public int VirtuemartCustomId { get; set; }
        public string Value { get; set; }
        public int Status { get; set; }
        public int Published { get; set; }
        public int Ordering { get; set; }
    }
}
