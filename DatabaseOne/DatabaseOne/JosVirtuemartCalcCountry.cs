using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosVirtuemartCalcCountry
    {
        public int Id { get; set; }
        public ushort VirtuemartCalcId { get; set; }
        public ushort VirtuemartCountryId { get; set; }
    }
}
