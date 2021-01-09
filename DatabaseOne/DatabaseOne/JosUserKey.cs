using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosUserKey
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
        public string Series { get; set; }
        public sbyte Invalid { get; set; }
        public string Time { get; set; }
        public string Uastring { get; set; }
    }
}
