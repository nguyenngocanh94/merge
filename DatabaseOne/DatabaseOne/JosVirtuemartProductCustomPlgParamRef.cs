using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartProductCustomPlgParamRef
    {
        public int Id { get; set; }
        public int VirtuemartProductId { get; set; }
        public int VirtuemartCustomId { get; set; }
        public int Val { get; set; }
        public double Intval { get; set; }
    }
}
