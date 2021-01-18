using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseTarget
{
    public partial class JosUcmContent
    {
        public uint CoreContentId { get; set; }
        public string CoreTypeAlias { get; set; }
        public string CoreTitle { get; set; }
        public string CoreAlias { get; set; }
        public string CoreBody { get; set; }
        public bool CoreState { get; set; }
        public string CoreCheckedOutTime { get; set; }
        public uint CoreCheckedOutUserId { get; set; }
        public uint CoreAccess { get; set; }
        public string CoreParams { get; set; }
        public byte CoreFeatured { get; set; }
        public string CoreMetadata { get; set; }
        public uint CoreCreatedUserId { get; set; }
        public string CoreCreatedByAlias { get; set; }
        public DateTime CoreCreatedTime { get; set; }
        public uint CoreModifiedUserId { get; set; }
        public DateTime CoreModifiedTime { get; set; }
        public string CoreLanguage { get; set; }
        public DateTime CorePublishUp { get; set; }
        public DateTime CorePublishDown { get; set; }
        public uint CoreContentItemId { get; set; }
        public uint AssetId { get; set; }
        public string CoreImages { get; set; }
        public string CoreUrls { get; set; }
        public uint CoreHits { get; set; }
        public uint CoreVersion { get; set; }
        public int CoreOrdering { get; set; }
        public string CoreMetakey { get; set; }
        public string CoreMetadesc { get; set; }
        public uint CoreCatid { get; set; }
        public string CoreXreference { get; set; }
        public uint CoreTypeId { get; set; }
    }
}
