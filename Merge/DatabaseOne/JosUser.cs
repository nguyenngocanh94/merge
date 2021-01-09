using System;
using System.Collections.Generic;
using Merge.Extensions;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosUser : EntityUtilities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Usertype { get; set; }
        public sbyte Block { get; set; }
        public sbyte? SendEmail { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastvisitDate { get; set; }
        public string Activation { get; set; }
        public string Params { get; set; }
        public DateTime LastResetTime { get; set; }
        public int ResetCount { get; set; }
        public string OtpKey { get; set; }
        public string Otep { get; set; }
        public sbyte RequireReset { get; set; }
    }
}
