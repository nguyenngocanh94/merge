using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartProductCustomPlgIstraxxDownload : EntityUtilities, IHiddenParam
    {
        public int Id { get; set; }
        public int? VirtuemartOrderItemId { get; set; }
        public string ClientIp { get; set; }
        public bool? Errorcode { get; set; }
        public string Message { get; set; }
        public int? VirtuemartProductId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
        
        public int GetHidden()
        {
            // always be in the first
            if (Message.Contains("media_id "))
            {
                string message2 = Message.Substring(13, Message.Length-13);
                int indexOfSpace = message2.IndexOf(" ", StringComparison.Ordinal);
                
                string mediaQuery = message2.Substring(0, indexOfSpace);
                int mediaId = int.Parse(mediaQuery);
                return mediaId;
            }

            return 0;
        }

        public void SetHidden(int goInt, int plus)
        {
            if (goInt!= 0)
            {
                var replace = Message.Replace(goInt.ToString(), (goInt + plus).ToString());
                Message = replace;
            }
        }
    }
}
