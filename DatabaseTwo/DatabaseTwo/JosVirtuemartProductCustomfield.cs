using System;
using System.Collections.Generic;
using DatabaseTwo.Extensions;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class JosVirtuemartProductCustomfield : EntityUtilities, IHiddenParam
    {
        public int VirtuemartCustomfieldId { get; set; }
        public int VirtuemartProductId { get; set; }
        public int VirtuemartCustomId { get; set; }
        public string CustomfieldValue { get; set; }
        public int Disabler { get; set; }
        public int Override { get; set; }
        public string CustomfieldParams { get; set; }
        public decimal? CustomfieldPrice { get; set; }
        public string ProductSku { get; set; }
        public string ProductGtin { get; set; }
        public string ProductMpn { get; set; }
        public int? Published { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime LockedOn { get; set; }
        public int LockedBy { get; set; }
        public int Ordering { get; set; }
        public int GetHidden()
        {
            // always be in the first
            if (CustomfieldParams.Contains("media_id="))
            {
                int index = CustomfieldParams.IndexOf("|", StringComparison.Ordinal);
                if (index<0)
                {
                    index = CustomfieldParams.IndexOf(",", StringComparison.Ordinal);
                    if (index < 0)
                    {
                        index = CustomfieldParams.Length;
                    }
                }
                string mediaQuery = CustomfieldParams.Substring(0, index);
                int mediaId = int.Parse(mediaQuery.Substring(10, mediaQuery.Length - 11));
                return mediaId;
            }

            return 0;
        }

        public void SetHidden(int goInt, int plus)
        {
            if (goInt!= 0)
            {
                var replace = CustomfieldParams.Replace(goInt.ToString(), (goInt + plus).ToString());
                CustomfieldParams = replace;
            }
        }
    }
}
