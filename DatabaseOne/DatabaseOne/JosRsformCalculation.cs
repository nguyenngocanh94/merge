using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosRsformCalculation
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public string Total { get; set; }
        public string Expression { get; set; }
        public int Ordering { get; set; }
    }
}
