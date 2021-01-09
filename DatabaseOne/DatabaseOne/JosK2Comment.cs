using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class JosK2Comment
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }
        public string CommentEmail { get; set; }
        public string CommentUrl { get; set; }
        public int Published { get; set; }
    }
}
