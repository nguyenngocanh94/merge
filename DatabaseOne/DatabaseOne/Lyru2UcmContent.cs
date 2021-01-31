using System;
using DatabaseOne.Extensions;

#nullable disable

namespace DatabaseOne.DatabaseOne
{
    public partial class Lyru2UcmContent
    {
        public int CoreContentId { get; set; }
        public string CoreTypeAlias { get; set; }
        public string CoreTitle { get; set; }
        public string CoreAlias { get; set; }
        public string CoreBody { get; set; }
        public int CoreState { get; set; }
        public string CoreCheckedOutTime { get; set; }
        public int CoreCheckedOutUserId { get; set; }
        public int CoreAccess { get; set; }
        public string CoreParams { get; set; }
        public byte CoreFeatured { get; set; }
        public string CoreMetadata { get; set; }
        public int CoreCreatedUserId { get; set; }
        public string CoreCreatedByAlias { get; set; }
        public DateTime CoreCreatedTime { get; set; }
        public int CoreModifiedUserId { get; set; }
        public DateTime CoreModifiedTime { get; set; }
        public string CoreLanguage { get; set; }
        public DateTime CorePublishUp { get; set; }
        public DateTime CorePublishDown { get; set; }
        public int? CoreContentItemId { get; set; }
        public int? AssetId { get; set; }
        public string CoreImages { get; set; }
        public string CoreUrls { get; set; }
        public int CoreHits { get; set; }
        public int CoreVersion { get; set; }
        public int CoreOrdering { get; set; }
        public string CoreMetakey { get; set; }
        public string CoreMetadesc { get; set; }
        public int CoreCatid { get; set; }
        public string CoreXreference { get; set; }
        public int? CoreTypeId { get; set; }
    }
}
