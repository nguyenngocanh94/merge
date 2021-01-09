using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosAllvideoshareLicensing
    {
        public int Id { get; set; }
        public string Licensekey { get; set; }
        public string Type { get; set; }
        public string Logo { get; set; }
        public string Logoposition { get; set; }
        public int Logoalpha { get; set; }
        public string Logotarget { get; set; }
        public sbyte Displaylogo { get; set; }
    }
}
