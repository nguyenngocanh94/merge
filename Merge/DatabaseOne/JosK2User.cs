using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosK2User
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
        public int Group { get; set; }
        public string Plugins { get; set; }
        public string Ip { get; set; }
        public string Hostname { get; set; }
        public string Notes { get; set; }
    }
}
