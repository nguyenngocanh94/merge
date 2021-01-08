using System;
using System.Collections.Generic;

#nullable disable

namespace Merge.DatabaseOne
{
    public partial class JosAcymailingMail
    {
        public uint Mailid { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Altbody { get; set; }
        public sbyte? Published { get; set; }
        public uint? Senddate { get; set; }
        public uint? Created { get; set; }
        public string Fromname { get; set; }
        public string Fromemail { get; set; }
        public string Replyname { get; set; }
        public string Replyemail { get; set; }
        public string Type { get; set; }
        public sbyte Visible { get; set; }
        public uint? Userid { get; set; }
        public string Alias { get; set; }
        public string Attach { get; set; }
        public sbyte Html { get; set; }
        public short Tempid { get; set; }
        public string Key { get; set; }
        public string Frequency { get; set; }
        public string Params { get; set; }
        public uint? Sentby { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public string Filter { get; set; }
        public string Language { get; set; }
        public string Abtesting { get; set; }
        public string Thumb { get; set; }
        public string Summary { get; set; }
        public string Favicon { get; set; }
        public string Bccaddresses { get; set; }
    }
}
