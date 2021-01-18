using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosAllvideoshareConfig
    {
        public int Id { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
        public decimal ImageRatio { get; set; }
        public int Playerid { get; set; }
        public string Layout { get; set; }
        public int Relatedvideoslimit { get; set; }
        public sbyte Title { get; set; }
        public sbyte Description { get; set; }
        public sbyte Category { get; set; }
        public sbyte Views { get; set; }
        public sbyte Search { get; set; }
        public string CommentsType { get; set; }
        public string Fbappid { get; set; }
        public int CommentsPosts { get; set; }
        public string CommentsColor { get; set; }
        public sbyte AutoApproval { get; set; }
        public sbyte TypeYoutube { get; set; }
        public sbyte TypeVimeo { get; set; }
        public sbyte TypeRtmp { get; set; }
        public sbyte TypeHls { get; set; }
        public sbyte LoadBootstrapCss { get; set; }
        public sbyte LoadIcomoonFont { get; set; }
        public string CustomCss { get; set; }
        public sbyte ShowFeed { get; set; }
        public int FeedLimit { get; set; }
        public sbyte ShowGdprConsent { get; set; }
        public int ItemidVideo { get; set; }
        public sbyte IsPremium { get; set; }
        public sbyte MultiCategories { get; set; }
        public sbyte Popup { get; set; }
    }
}
