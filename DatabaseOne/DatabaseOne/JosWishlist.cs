using System;
using DatabaseOne.Extensions;


#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosWishlist : EntityUtilities
    {
        public int Id { get; set; }
        public int VirtuemartProductId { get; set; }
        public int Userid { get; set; }
    }
}
