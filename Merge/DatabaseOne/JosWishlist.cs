using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosWishlist
    {
        public int Id { get; set; }
        public int VirtuemartProductId { get; set; }
        public int Userid { get; set; }
    }
}
