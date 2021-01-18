﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabaseTarget
{
    public partial class DatabaseTargetContext : DbContext
    {
        public DatabaseTargetContext()
        {
        }

        public DatabaseTargetContext(DbContextOptions<DatabaseTargetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JosActionLog> JosActionLogs { get; set; }
        public virtual DbSet<JosActionLogConfig> JosActionLogConfigs { get; set; }
        public virtual DbSet<JosActionLogsExtension> JosActionLogsExtensions { get; set; }
        public virtual DbSet<JosActionLogsUser> JosActionLogsUsers { get; set; }
        public virtual DbSet<JosAcymailingAction> JosAcymailingActions { get; set; }
        public virtual DbSet<JosAcymailingConfig> JosAcymailingConfigs { get; set; }
        public virtual DbSet<JosAcymailingField> JosAcymailingFields { get; set; }
        public virtual DbSet<JosAcymailingFilter> JosAcymailingFilters { get; set; }
        public virtual DbSet<JosAcymailingForward> JosAcymailingForwards { get; set; }
        public virtual DbSet<JosAcymailingGeolocation> JosAcymailingGeolocations { get; set; }
        public virtual DbSet<JosAcymailingHistory> JosAcymailingHistories { get; set; }
        public virtual DbSet<JosAcymailingList> JosAcymailingLists { get; set; }
        public virtual DbSet<JosAcymailingListcampaign> JosAcymailingListcampaigns { get; set; }
        public virtual DbSet<JosAcymailingListmail> JosAcymailingListmails { get; set; }
        public virtual DbSet<JosAcymailingListsub> JosAcymailingListsubs { get; set; }
        public virtual DbSet<JosAcymailingMail> JosAcymailingMails { get; set; }
        public virtual DbSet<JosAcymailingQueue> JosAcymailingQueues { get; set; }
        public virtual DbSet<JosAcymailingRule> JosAcymailingRules { get; set; }
        public virtual DbSet<JosAcymailingStat> JosAcymailingStats { get; set; }
        public virtual DbSet<JosAcymailingSubscriber> JosAcymailingSubscribers { get; set; }
        public virtual DbSet<JosAcymailingTag> JosAcymailingTags { get; set; }
        public virtual DbSet<JosAcymailingTagmail> JosAcymailingTagmails { get; set; }
        public virtual DbSet<JosAcymailingTemplate> JosAcymailingTemplates { get; set; }
        public virtual DbSet<JosAcymailingUrl> JosAcymailingUrls { get; set; }
        public virtual DbSet<JosAcymailingUrlclick> JosAcymailingUrlclicks { get; set; }
        public virtual DbSet<JosAcymailingUserstat> JosAcymailingUserstats { get; set; }
        public virtual DbSet<JosAkProfile> JosAkProfiles { get; set; }
        public virtual DbSet<JosAkStat> JosAkStats { get; set; }
        public virtual DbSet<JosAkStorage> JosAkStorages { get; set; }
        public virtual DbSet<JosAkeebaCommon> JosAkeebaCommons { get; set; }
        public virtual DbSet<JosAllvideoshareAdvert> JosAllvideoshareAdverts { get; set; }
        public virtual DbSet<JosAllvideoshareCategory> JosAllvideoshareCategories { get; set; }
        public virtual DbSet<JosAllvideoshareConfig> JosAllvideoshareConfigs { get; set; }
        public virtual DbSet<JosAllvideoshareLicensing> JosAllvideoshareLicensings { get; set; }
        public virtual DbSet<JosAllvideosharePlayer> JosAllvideosharePlayers { get; set; }
        public virtual DbSet<JosAllvideoshareVideo> JosAllvideoshareVideos { get; set; }
        public virtual DbSet<JosAsset> JosAssets { get; set; }
        public virtual DbSet<JosAssociation> JosAssociations { get; set; }
        public virtual DbSet<JosBanner> JosBanners { get; set; }
        public virtual DbSet<JosBannerClient> JosBannerClients { get; set; }
        public virtual DbSet<JosBannerTrack> JosBannerTracks { get; set; }
        public virtual DbSet<JosCategory> JosCategories { get; set; }
        public virtual DbSet<JosContactDetail> JosContactDetails { get; set; }
        public virtual DbSet<JosContent> JosContents { get; set; }
        public virtual DbSet<JosContentFrontpage> JosContentFrontpages { get; set; }
        public virtual DbSet<JosContentRating> JosContentRatings { get; set; }
        public virtual DbSet<JosContentType> JosContentTypes { get; set; }
        public virtual DbSet<JosContentitemTagMap> JosContentitemTagMaps { get; set; }
        public virtual DbSet<JosCoreLogSearch> JosCoreLogSearches { get; set; }
        public virtual DbSet<JosExtension> JosExtensions { get; set; }
        public virtual DbSet<JosField> JosFields { get; set; }
        public virtual DbSet<JosFieldsCategory> JosFieldsCategories { get; set; }
        public virtual DbSet<JosFieldsGroup> JosFieldsGroups { get; set; }
        public virtual DbSet<JosFieldsValue> JosFieldsValues { get; set; }
        public virtual DbSet<JosFinderFilter> JosFinderFilters { get; set; }
        public virtual DbSet<JosFinderLink> JosFinderLinks { get; set; }
        public virtual DbSet<JosFinderLinksTerms0> JosFinderLinksTerms0s { get; set; }
        public virtual DbSet<JosFinderLinksTerms1> JosFinderLinksTerms1s { get; set; }
        public virtual DbSet<JosFinderLinksTerms2> JosFinderLinksTerms2s { get; set; }
        public virtual DbSet<JosFinderLinksTerms3> JosFinderLinksTerms3s { get; set; }
        public virtual DbSet<JosFinderLinksTerms4> JosFinderLinksTerms4s { get; set; }
        public virtual DbSet<JosFinderLinksTerms5> JosFinderLinksTerms5s { get; set; }
        public virtual DbSet<JosFinderLinksTerms6> JosFinderLinksTerms6s { get; set; }
        public virtual DbSet<JosFinderLinksTerms7> JosFinderLinksTerms7s { get; set; }
        public virtual DbSet<JosFinderLinksTerms8> JosFinderLinksTerms8s { get; set; }
        public virtual DbSet<JosFinderLinksTerms9> JosFinderLinksTerms9s { get; set; }
        public virtual DbSet<JosFinderLinksTermsa> JosFinderLinksTermsas { get; set; }
        public virtual DbSet<JosFinderLinksTermsb> JosFinderLinksTermsbs { get; set; }
        public virtual DbSet<JosFinderLinksTermsc> JosFinderLinksTermscs { get; set; }
        public virtual DbSet<JosFinderLinksTermsd> JosFinderLinksTermsds { get; set; }
        public virtual DbSet<JosFinderLinksTermse> JosFinderLinksTermses { get; set; }
        public virtual DbSet<JosFinderLinksTermsf> JosFinderLinksTermsfs { get; set; }
        public virtual DbSet<JosFinderTaxonomy> JosFinderTaxonomies { get; set; }
        public virtual DbSet<JosFinderTaxonomyMap> JosFinderTaxonomyMaps { get; set; }
        public virtual DbSet<JosFinderTerm> JosFinderTerms { get; set; }
        public virtual DbSet<JosFinderTermsCommon> JosFinderTermsCommons { get; set; }
        public virtual DbSet<JosFinderToken> JosFinderTokens { get; set; }
        public virtual DbSet<JosFinderTokensAggregate> JosFinderTokensAggregates { get; set; }
        public virtual DbSet<JosFinderType> JosFinderTypes { get; set; }
        public virtual DbSet<JosJcomment> JosJcomments { get; set; }
        public virtual DbSet<JosJcommentsBlacklist> JosJcommentsBlacklists { get; set; }
        public virtual DbSet<JosJcommentsCustomBbcode> JosJcommentsCustomBbcodes { get; set; }
        public virtual DbSet<JosJcommentsMailq> JosJcommentsMailqs { get; set; }
        public virtual DbSet<JosJcommentsObject> JosJcommentsObjects { get; set; }
        public virtual DbSet<JosJcommentsReport> JosJcommentsReports { get; set; }
        public virtual DbSet<JosJcommentsSetting> JosJcommentsSettings { get; set; }
        public virtual DbSet<JosJcommentsSmily> JosJcommentsSmilies { get; set; }
        public virtual DbSet<JosJcommentsSubscription> JosJcommentsSubscriptions { get; set; }
        public virtual DbSet<JosJcommentsVersion> JosJcommentsVersions { get; set; }
        public virtual DbSet<JosJcommentsVote> JosJcommentsVotes { get; set; }
        public virtual DbSet<JosK2Attachment> JosK2Attachments { get; set; }
        public virtual DbSet<JosK2Category> JosK2Categories { get; set; }
        public virtual DbSet<JosK2Comment> JosK2Comments { get; set; }
        public virtual DbSet<JosK2ExtraField> JosK2ExtraFields { get; set; }
        public virtual DbSet<JosK2ExtraFieldsGroup> JosK2ExtraFieldsGroups { get; set; }
        public virtual DbSet<JosK2Item> JosK2Items { get; set; }
        public virtual DbSet<JosK2Log> JosK2Logs { get; set; }
        public virtual DbSet<JosK2Rating> JosK2Ratings { get; set; }
        public virtual DbSet<JosK2Tag> JosK2Tags { get; set; }
        public virtual DbSet<JosK2TagsXref> JosK2TagsXrefs { get; set; }
        public virtual DbSet<JosK2User> JosK2Users { get; set; }
        public virtual DbSet<JosK2UserGroup> JosK2UserGroups { get; set; }
        public virtual DbSet<JosLanguage> JosLanguages { get; set; }
        public virtual DbSet<JosMenu> JosMenus { get; set; }
        public virtual DbSet<JosMenuType> JosMenuTypes { get; set; }
        public virtual DbSet<JosMessage> JosMessages { get; set; }
        public virtual DbSet<JosMessagesCfg> JosMessagesCfgs { get; set; }
        public virtual DbSet<JosModule> JosModules { get; set; }
        public virtual DbSet<JosModulesMenu> JosModulesMenus { get; set; }
        public virtual DbSet<JosNbordersMailsended> JosNbordersMailsendeds { get; set; }
        public virtual DbSet<JosNbordersTemplate> JosNbordersTemplates { get; set; }
        public virtual DbSet<JosNewsfeed> JosNewsfeeds { get; set; }
        public virtual DbSet<JosOverrider> JosOverriders { get; set; }
        public virtual DbSet<JosPostinstallMessage> JosPostinstallMessages { get; set; }
        public virtual DbSet<JosPrivacyConsent> JosPrivacyConsents { get; set; }
        public virtual DbSet<JosPrivacyRequest> JosPrivacyRequests { get; set; }
        public virtual DbSet<JosRedirectLink> JosRedirectLinks { get; set; }
        public virtual DbSet<JosRevsliderStaticSlide> JosRevsliderStaticSlides { get; set; }
        public virtual DbSet<JosSchema> JosSchemas { get; set; }
        public virtual DbSet<JosSession> JosSessions { get; set; }
        public virtual DbSet<JosSpmedium> JosSpmedia { get; set; }
        public virtual DbSet<JosSppagebuilder> JosSppagebuilders { get; set; }
        public virtual DbSet<JosSppagebuilderAddon> JosSppagebuilderAddons { get; set; }
        public virtual DbSet<JosSppagebuilderIntegration> JosSppagebuilderIntegrations { get; set; }
        public virtual DbSet<JosSppagebuilderLanguage> JosSppagebuilderLanguages { get; set; }
        public virtual DbSet<JosSppagebuilderSection> JosSppagebuilderSections { get; set; }
        public virtual DbSet<JosTag> JosTags { get; set; }
        public virtual DbSet<JosTemplateStyle> JosTemplateStyles { get; set; }
        public virtual DbSet<JosUcmBase> JosUcmBases { get; set; }
        public virtual DbSet<JosUcmContent> JosUcmContents { get; set; }
        public virtual DbSet<JosUcmHistory> JosUcmHistories { get; set; }
        public virtual DbSet<JosUpdate> JosUpdates { get; set; }
        public virtual DbSet<JosUpdateSite> JosUpdateSites { get; set; }
        public virtual DbSet<JosUpdateSitesExtension> JosUpdateSitesExtensions { get; set; }
        public virtual DbSet<JosUser> JosUsers { get; set; }
        public virtual DbSet<JosUserKey> JosUserKeys { get; set; }
        public virtual DbSet<JosUserNote> JosUserNotes { get; set; }
        public virtual DbSet<JosUserProfile> JosUserProfiles { get; set; }
        public virtual DbSet<JosUserUsergroupMap> JosUserUsergroupMaps { get; set; }
        public virtual DbSet<JosUsergroup> JosUsergroups { get; set; }
        public virtual DbSet<JosUtf8Conversion> JosUtf8Conversions { get; set; }
        public virtual DbSet<JosViewlevel> JosViewlevels { get; set; }
        public virtual DbSet<JosVirtuemartAdminmenuentry> JosVirtuemartAdminmenuentries { get; set; }
        public virtual DbSet<JosVirtuemartCalc> JosVirtuemartCalcs { get; set; }
        public virtual DbSet<JosVirtuemartCalcCategory> JosVirtuemartCalcCategories { get; set; }
        public virtual DbSet<JosVirtuemartCalcCountry> JosVirtuemartCalcCountries { get; set; }
        public virtual DbSet<JosVirtuemartCalcManufacturer> JosVirtuemartCalcManufacturers { get; set; }
        public virtual DbSet<JosVirtuemartCalcShoppergroup> JosVirtuemartCalcShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartCalcState> JosVirtuemartCalcStates { get; set; }
        public virtual DbSet<JosVirtuemartCart> JosVirtuemartCarts { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesArAa> JosVirtuemartCategoriesArAas { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesDeDe> JosVirtuemartCategoriesDeDes { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesEnGb> JosVirtuemartCategoriesEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesEsE> JosVirtuemartCategoriesEsEs { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesFrFr> JosVirtuemartCategoriesFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesItIt> JosVirtuemartCategoriesItIts { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesRuRu> JosVirtuemartCategoriesRuRus { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesSqAl> JosVirtuemartCategoriesSqAls { get; set; }
        public virtual DbSet<JosVirtuemartCategory> JosVirtuemartCategories { get; set; }
        public virtual DbSet<JosVirtuemartCategoryCategory> JosVirtuemartCategoryCategories { get; set; }
        public virtual DbSet<JosVirtuemartCategoryMedia> JosVirtuemartCategoryMedias { get; set; }
        public virtual DbSet<JosVirtuemartConfig> JosVirtuemartConfigs { get; set; }
        public virtual DbSet<JosVirtuemartCountry> JosVirtuemartCountries { get; set; }
        public virtual DbSet<JosVirtuemartCoupon> JosVirtuemartCoupons { get; set; }
        public virtual DbSet<JosVirtuemartCurrency> JosVirtuemartCurrencies { get; set; }
        public virtual DbSet<JosVirtuemartCustom> JosVirtuemartCustoms { get; set; }
        public virtual DbSet<JosVirtuemartInvoice> JosVirtuemartInvoices { get; set; }
        public virtual DbSet<JosVirtuemartManufacturer> JosVirtuemartManufacturers { get; set; }
        public virtual DbSet<JosVirtuemartManufacturerMedia> JosVirtuemartManufacturerMedias { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesArAa> JosVirtuemartManufacturercategoriesArAas { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesDeDe> JosVirtuemartManufacturercategoriesDeDes { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesEnGb> JosVirtuemartManufacturercategoriesEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesEsE> JosVirtuemartManufacturercategoriesEsEs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesFrFr> JosVirtuemartManufacturercategoriesFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesItIt> JosVirtuemartManufacturercategoriesItIts { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesRuRu> JosVirtuemartManufacturercategoriesRuRus { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesSqAl> JosVirtuemartManufacturercategoriesSqAls { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategory> JosVirtuemartManufacturercategories { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersArAa> JosVirtuemartManufacturersArAas { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersDeDe> JosVirtuemartManufacturersDeDes { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersEnGb> JosVirtuemartManufacturersEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersEsE> JosVirtuemartManufacturersEsEs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersFrFr> JosVirtuemartManufacturersFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersItIt> JosVirtuemartManufacturersItIts { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersRuRu> JosVirtuemartManufacturersRuRus { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersSqAl> JosVirtuemartManufacturersSqAls { get; set; }
        public virtual DbSet<JosVirtuemartMedia> JosVirtuemartMedias { get; set; }
        public virtual DbSet<JosVirtuemartMigrationOldtonewId> JosVirtuemartMigrationOldtonewIds { get; set; }
        public virtual DbSet<JosVirtuemartModule> JosVirtuemartModules { get; set; }
        public virtual DbSet<JosVirtuemartOrder> JosVirtuemartOrders { get; set; }
        public virtual DbSet<JosVirtuemartOrderCalcRule> JosVirtuemartOrderCalcRules { get; set; }
        public virtual DbSet<JosVirtuemartOrderHistory> JosVirtuemartOrderHistories { get; set; }
        public virtual DbSet<JosVirtuemartOrderItem> JosVirtuemartOrderItems { get; set; }
        public virtual DbSet<JosVirtuemartOrderItemHistory> JosVirtuemartOrderItemHistories { get; set; }
        public virtual DbSet<JosVirtuemartOrderUserinfo> JosVirtuemartOrderUserinfos { get; set; }
        public virtual DbSet<JosVirtuemartOrderstate> JosVirtuemartOrderstates { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgAuthorizenet> JosVirtuemartPaymentPlgAuthorizenets { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgHeidelpay> JosVirtuemartPaymentPlgHeidelpays { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgMoneybookersAcc> JosVirtuemartPaymentPlgMoneybookersAccs { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgPaypal> JosVirtuemartPaymentPlgPaypals { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgPayzen> JosVirtuemartPaymentPlgPayzens { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgStandard> JosVirtuemartPaymentPlgStandards { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethod> JosVirtuemartPaymentmethods { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodShoppergroup> JosVirtuemartPaymentmethodShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsArAa> JosVirtuemartPaymentmethodsArAas { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsDeDe> JosVirtuemartPaymentmethodsDeDes { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsEnGb> JosVirtuemartPaymentmethodsEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsEsE> JosVirtuemartPaymentmethodsEsEs { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsFrFr> JosVirtuemartPaymentmethodsFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsItIt> JosVirtuemartPaymentmethodsItIts { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsRuRu> JosVirtuemartPaymentmethodsRuRus { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsSqAl> JosVirtuemartPaymentmethodsSqAls { get; set; }
        public virtual DbSet<JosVirtuemartPermgroup> JosVirtuemartPermgroups { get; set; }
        public virtual DbSet<JosVirtuemartProduct> JosVirtuemartProducts { get; set; }
        public virtual DbSet<JosVirtuemartProductCategory> JosVirtuemartProductCategories { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomPlgIstraxxDownload> JosVirtuemartProductCustomPlgIstraxxDownloads { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomPlgIstraxxDownloadSimple> JosVirtuemartProductCustomPlgIstraxxDownloadSimples { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomPlgParamRef> JosVirtuemartProductCustomPlgParamRefs { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomPlgParamValue> JosVirtuemartProductCustomPlgParamValues { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomPlgVm2tag> JosVirtuemartProductCustomPlgVm2tags { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomfield> JosVirtuemartProductCustomfields { get; set; }
        public virtual DbSet<JosVirtuemartProductManufacturer> JosVirtuemartProductManufacturers { get; set; }
        public virtual DbSet<JosVirtuemartProductMedia> JosVirtuemartProductMedias { get; set; }
        public virtual DbSet<JosVirtuemartProductPrice> JosVirtuemartProductPrices { get; set; }
        public virtual DbSet<JosVirtuemartProductRelation> JosVirtuemartProductRelations { get; set; }
        public virtual DbSet<JosVirtuemartProductShoppergroup> JosVirtuemartProductShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartProductsArAa> JosVirtuemartProductsArAas { get; set; }
        public virtual DbSet<JosVirtuemartProductsEnGb> JosVirtuemartProductsEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartProductsEsE> JosVirtuemartProductsEsEs { get; set; }
        public virtual DbSet<JosVirtuemartProductsFrFr> JosVirtuemartProductsFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartProductsItIt> JosVirtuemartProductsItIts { get; set; }
        public virtual DbSet<JosVirtuemartProductsRuRu> JosVirtuemartProductsRuRus { get; set; }
        public virtual DbSet<JosVirtuemartProductsSqAl> JosVirtuemartProductsSqAls { get; set; }
        public virtual DbSet<JosVirtuemartRating> JosVirtuemartRatings { get; set; }
        public virtual DbSet<JosVirtuemartRatingReview> JosVirtuemartRatingReviews { get; set; }
        public virtual DbSet<JosVirtuemartRatingVote> JosVirtuemartRatingVotes { get; set; }
        public virtual DbSet<JosVirtuemartShipmentPlgWeightCountry> JosVirtuemartShipmentPlgWeightCountries { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethod> JosVirtuemartShipmentmethods { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodShoppergroup> JosVirtuemartShipmentmethodShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodsArAa> JosVirtuemartShipmentmethodsArAas { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodsDeDe> JosVirtuemartShipmentmethodsDeDes { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodsEnGb> JosVirtuemartShipmentmethodsEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodsEsE> JosVirtuemartShipmentmethodsEsEs { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodsFrFr> JosVirtuemartShipmentmethodsFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodsItIt> JosVirtuemartShipmentmethodsItIts { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodsRuRu> JosVirtuemartShipmentmethodsRuRus { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodsSqAl> JosVirtuemartShipmentmethodsSqAls { get; set; }
        public virtual DbSet<JosVirtuemartShoppergroup> JosVirtuemartShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartState> JosVirtuemartStates { get; set; }
        public virtual DbSet<JosVirtuemartUserfield> JosVirtuemartUserfields { get; set; }
        public virtual DbSet<JosVirtuemartUserfieldValue> JosVirtuemartUserfieldValues { get; set; }
        public virtual DbSet<JosVirtuemartUserinfo> JosVirtuemartUserinfos { get; set; }
        public virtual DbSet<JosVirtuemartVendor> JosVirtuemartVendors { get; set; }
        public virtual DbSet<JosVirtuemartVendorMedia> JosVirtuemartVendorMedias { get; set; }
        public virtual DbSet<JosVirtuemartVendorUser> JosVirtuemartVendorUsers { get; set; }
        public virtual DbSet<JosVirtuemartVendorsArAa> JosVirtuemartVendorsArAas { get; set; }
        public virtual DbSet<JosVirtuemartVendorsDeDe> JosVirtuemartVendorsDeDes { get; set; }
        public virtual DbSet<JosVirtuemartVendorsEnGb> JosVirtuemartVendorsEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartVendorsFrFr> JosVirtuemartVendorsFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartVendorsItIt> JosVirtuemartVendorsItIts { get; set; }
        public virtual DbSet<JosVirtuemartVendorsRuRu> JosVirtuemartVendorsRuRus { get; set; }
        public virtual DbSet<JosVirtuemartVendorsSqAl> JosVirtuemartVendorsSqAls { get; set; }
        public virtual DbSet<JosVirtuemartVmuser> JosVirtuemartVmusers { get; set; }
        public virtual DbSet<JosVirtuemartVmuserShoppergroup> JosVirtuemartVmuserShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartWaitinguser> JosVirtuemartWaitingusers { get; set; }
        public virtual DbSet<JosVirtuemartWorldzone> JosVirtuemartWorldzones { get; set; }
        public virtual DbSet<JosWeblink> JosWeblinks { get; set; }
        public virtual DbSet<JosWfProfile> JosWfProfiles { get; set; }
        public virtual DbSet<JosWishlist> JosWishlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=db_store;user=root;password=password;port=13301;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.FromString("10.4.17-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JosActionLog>(entity =>
            {
                entity.ToTable("jos_action_logs");

                entity.HasIndex(e => new { e.Extension, e.ItemId }, "idx_extension_item_id");

                entity.HasIndex(e => e.UserId, "idx_user_id");

                entity.HasIndex(e => new { e.UserId, e.Extension }, "idx_user_id_extension");

                entity.HasIndex(e => new { e.UserId, e.LogDate }, "idx_user_id_logdate");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("extension")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasColumnName("ip_address")
                    .HasDefaultValueSql("'0.0.0.0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_id");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("log_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("message")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MessageLanguageKey)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("message_language_key")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<JosActionLogConfig>(entity =>
            {
                entity.ToTable("jos_action_log_config");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.IdHolder)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("id_holder")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TableName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("table_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TextPrefix)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("text_prefix")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TitleHolder)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title_holder")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TypeAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("type_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TypeTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("type_title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosActionLogsExtension>(entity =>
            {
                entity.ToTable("jos_action_logs_extensions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extension")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosActionLogsUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_action_logs_users");

                entity.HasIndex(e => e.Notify, "idx_notify");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("user_id");

                entity.Property(e => e.Extensions)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("extensions")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Notify)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("notify");
            });

            modelBuilder.Entity<JosAcymailingAction>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_action");

                entity.Property(e => e.ActionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action_id");

                entity.Property(e => e.Actions)
                    .HasColumnType("text")
                    .HasColumnName("actions")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Conditions)
                    .HasColumnType("text")
                    .HasColumnName("conditions")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConnectionMethod)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("connection_method")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeleteWrongEmails)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("delete_wrong_emails");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Frequency)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("frequency");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nextdate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("nextdate");

                entity.Property(e => e.Ordering)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ordering")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("password")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Port)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("port")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published");

                entity.Property(e => e.Report)
                    .HasColumnType("text")
                    .HasColumnName("report")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecureMethod)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("secure_method")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SelfSigned)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("self_signed");

                entity.Property(e => e.Server)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("server")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("userid");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("username")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAcymailingConfig>(entity =>
            {
                entity.HasKey(e => e.Namekey)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_config");

                entity.Property(e => e.Namekey)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("namekey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAcymailingField>(entity =>
            {
                entity.HasKey(e => e.Fieldid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_fields");

                entity.HasIndex(e => e.Namekey, "namekey")
                    .IsUnique();

                entity.HasIndex(e => new { e.Published, e.Ordering }, "orderingindex");

                entity.Property(e => e.Fieldid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("fieldid");

                entity.Property(e => e.Access)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("access")
                    .HasDefaultValueSql("'all'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Backend)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("backend")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Core)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("core");

                entity.Property(e => e.Default)
                    .HasColumnType("text")
                    .HasColumnName("default")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fieldcat)
                    .HasColumnType("int(11)")
                    .HasColumnName("fieldcat");

                entity.Property(e => e.Fieldname)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("fieldname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Frontcomp)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("frontcomp");

                entity.Property(e => e.Frontform)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("frontform")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Frontjoomlaprofile)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("frontjoomlaprofile");

                entity.Property(e => e.Frontjoomlaregistration)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("frontjoomlaregistration");

                entity.Property(e => e.Frontlisting)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("frontlisting");

                entity.Property(e => e.Frontlistingfilter)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("frontlistingfilter");

                entity.Property(e => e.Joomlaprofile)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("joomlaprofile");

                entity.Property(e => e.Listing)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("listing");

                entity.Property(e => e.Listingfilter)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("listingfilter");

                entity.Property(e => e.Namekey)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("namekey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Options)
                    .HasColumnType("text")
                    .HasColumnName("options")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ordering")
                    .HasDefaultValueSql("'99'");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Required)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("required");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAcymailingFilter>(entity =>
            {
                entity.HasKey(e => e.Filid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_filter");

                entity.Property(e => e.Filid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("filid");

                entity.Property(e => e.Action)
                    .HasColumnType("text")
                    .HasColumnName("action")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Daycron)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("daycron");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Filter)
                    .HasColumnType("text")
                    .HasColumnName("filter")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lasttime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("lasttime");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("published");

                entity.Property(e => e.Report)
                    .HasColumnType("text")
                    .HasColumnName("report")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Trigger)
                    .HasColumnType("text")
                    .HasColumnName("trigger")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAcymailingForward>(entity =>
            {
                entity.HasKey(e => new { e.Subid, e.Mailid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_acymailing_forward");

                entity.Property(e => e.Subid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("subid");

                entity.Property(e => e.Mailid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailid");

                entity.Property(e => e.Date)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("date");

                entity.Property(e => e.Ip)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nbforwarded)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("nbforwarded");
            });

            modelBuilder.Entity<JosAcymailingGeolocation>(entity =>
            {
                entity.HasKey(e => e.GeolocationId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_geolocation");

                entity.HasIndex(e => new { e.GeolocationIp, e.GeolocationCreated }, "geolocation_ip_created");

                entity.HasIndex(e => new { e.GeolocationSubid, e.GeolocationType }, "geolocation_type");

                entity.Property(e => e.GeolocationId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("geolocation_id");

                entity.Property(e => e.GeolocationCity)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_city")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeolocationContinent)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_continent")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeolocationCountry)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_country")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeolocationCountryCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_country_code")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeolocationCreated)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("geolocation_created");

                entity.Property(e => e.GeolocationIp)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_ip")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeolocationLatitude)
                    .HasPrecision(9, 6)
                    .HasColumnName("geolocation_latitude");

                entity.Property(e => e.GeolocationLongitude)
                    .HasPrecision(9, 6)
                    .HasColumnName("geolocation_longitude");

                entity.Property(e => e.GeolocationPostalCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_postal_code")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeolocationState)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_state")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeolocationStateCode)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_state_code")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeolocationSubid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("geolocation_subid");

                entity.Property(e => e.GeolocationTimezone)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_timezone")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GeolocationType)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("geolocation_type")
                    .HasDefaultValueSql("'subscription'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAcymailingHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_acymailing_history");

                entity.HasIndex(e => new { e.Action, e.Mailid }, "actionindex");

                entity.HasIndex(e => e.Date, "dateindex");

                entity.HasIndex(e => new { e.Subid, e.Date }, "subid");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("action")
                    .HasComment("different actions: created,modified,confirmed")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Date)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("date");

                entity.Property(e => e.Ip)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Mailid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailid");

                entity.Property(e => e.Source)
                    .HasColumnType("text")
                    .HasColumnName("source")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("subid");
            });

            modelBuilder.Entity<JosAcymailingList>(entity =>
            {
                entity.HasKey(e => e.Listid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_list");

                entity.HasIndex(e => new { e.Type, e.Ordering }, "typeorderingindex");

                entity.HasIndex(e => new { e.Type, e.Userid }, "typeuseridindex");

                entity.HasIndex(e => e.Userid, "useridindex");

                entity.Property(e => e.Listid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("listid");

                entity.Property(e => e.AccessManage)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("access_manage")
                    .HasDefaultValueSql("'none'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AccessSub)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("access_sub")
                    .HasDefaultValueSql("'all'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Alias)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("alias")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("category")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Color)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("color")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Languages)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("languages")
                    .HasDefaultValueSql("'all'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ordering")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published");

                entity.Property(e => e.Startrule)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("startrule")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("enum('list','campaign')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'list'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unsubmailid)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("unsubmailid");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("userid");

                entity.Property(e => e.Visible)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("visible")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Welmailid)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("welmailid");
            });

            modelBuilder.Entity<JosAcymailingListcampaign>(entity =>
            {
                entity.HasKey(e => new { e.Campaignid, e.Listid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_acymailing_listcampaign");

                entity.Property(e => e.Campaignid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("campaignid");

                entity.Property(e => e.Listid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("listid");
            });

            modelBuilder.Entity<JosAcymailingListmail>(entity =>
            {
                entity.HasKey(e => new { e.Listid, e.Mailid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_acymailing_listmail");

                entity.Property(e => e.Listid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("listid");

                entity.Property(e => e.Mailid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailid");
            });

            modelBuilder.Entity<JosAcymailingListsub>(entity =>
            {
                entity.HasKey(e => new { e.Listid, e.Subid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_acymailing_listsub");

                entity.HasIndex(e => new { e.Listid, e.Status }, "listidstatusindex");

                entity.HasIndex(e => e.Subid, "subidindex");

                entity.Property(e => e.Listid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("listid");

                entity.Property(e => e.Subid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("subid");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("status");

                entity.Property(e => e.Subdate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("subdate");

                entity.Property(e => e.Unsubdate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("unsubdate");
            });

            modelBuilder.Entity<JosAcymailingMail>(entity =>
            {
                entity.HasKey(e => e.Mailid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_mail");

                entity.HasIndex(e => e.Senddate, "senddate");

                entity.HasIndex(e => new { e.Type, e.Mailid }, "typemailidindex");

                entity.HasIndex(e => e.Userid, "useridindex");

                entity.Property(e => e.Mailid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailid");

                entity.Property(e => e.Abtesting)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("abtesting")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Alias)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("alias")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Altbody)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("altbody")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Attach)
                    .HasColumnType("text")
                    .HasColumnName("attach")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bccaddresses)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("bccaddresses")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("body")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created");

                entity.Property(e => e.Favicon)
                    .HasColumnType("text")
                    .HasColumnName("favicon")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Filter)
                    .HasColumnType("text")
                    .HasColumnName("filter")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Frequency)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("frequency")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fromemail)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("fromemail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fromname)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("fromname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Html)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("html")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Key)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("key")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("lastupdate");

                entity.Property(e => e.Metadesc)
                    .HasColumnType("text")
                    .HasColumnName("metadesc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .HasColumnType("text")
                    .HasColumnName("metakey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Params)
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Replyemail)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("replyemail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Replyname)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("replyname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Senddate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("senddate");

                entity.Property(e => e.Sentby)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sentby");

                entity.Property(e => e.Subject)
                    .HasColumnType("text")
                    .HasColumnName("subject")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("summary")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tempid)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("tempid");

                entity.Property(e => e.Thumb)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("thumb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("enum('news','autonews','followup','unsub','welcome','notification','joomlanotification','action','article')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'news'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("userid");

                entity.Property(e => e.Userlastupdate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("userlastupdate");

                entity.Property(e => e.Visible)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("visible")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosAcymailingQueue>(entity =>
            {
                entity.HasKey(e => new { e.Subid, e.Mailid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_acymailing_queue");

                entity.HasIndex(e => new { e.Senddate, e.Subid }, "listingindex");

                entity.HasIndex(e => e.Mailid, "mailidindex");

                entity.HasIndex(e => new { e.Priority, e.Senddate, e.Subid }, "orderingindex");

                entity.Property(e => e.Subid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("subid");

                entity.Property(e => e.Mailid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailid");

                entity.Property(e => e.Paramqueue)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("paramqueue")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.Senddate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("senddate");

                entity.Property(e => e.Try)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("try");
            });

            modelBuilder.Entity<JosAcymailingRule>(entity =>
            {
                entity.HasKey(e => e.Ruleid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_rules");

                entity.HasIndex(e => new { e.Published, e.Ordering }, "ordering");

                entity.Property(e => e.Ruleid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ruleid");

                entity.Property(e => e.ActionMessage)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("action_message")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ActionUser)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("action_user")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExecutedOn)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("executed_on")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("published");

                entity.Property(e => e.Regex)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("regex")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAcymailingStat>(entity =>
            {
                entity.HasKey(e => e.Mailid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_stats");

                entity.HasIndex(e => e.Senddate, "senddateindex");

                entity.Property(e => e.Mailid)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("mailid");

                entity.Property(e => e.Bouncedetails)
                    .HasColumnType("text")
                    .HasColumnName("bouncedetails")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bounceunique)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("bounceunique")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Clicktotal)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("clicktotal");

                entity.Property(e => e.Clickunique)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("clickunique")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Fail)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("fail")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Forward)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("forward")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Opentotal)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("opentotal");

                entity.Property(e => e.Openunique)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("openunique")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Senddate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("senddate");

                entity.Property(e => e.Senthtml)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("senthtml");

                entity.Property(e => e.Senttext)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("senttext");

                entity.Property(e => e.Unsub)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("unsub")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<JosAcymailingSubscriber>(entity =>
            {
                entity.HasKey(e => e.Subid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_subscriber");

                entity.HasIndex(e => e.Email, "email")
                    .IsUnique();

                entity.HasIndex(e => new { e.Enabled, e.Accept, e.Confirmed }, "queueindex");

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.Subid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("subid");

                entity.Property(e => e.Accept)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("accept")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Confirmed)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("confirmed");

                entity.Property(e => e.ConfirmedDate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("confirmed_date");

                entity.Property(e => e.ConfirmedIp)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("confirmed_ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Enabled)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Filterflags)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("filterflags")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Html)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("html")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Ip)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Key)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("key")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastclickDate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("lastclick_date");

                entity.Property(e => e.LastopenDate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("lastopen_date");

                entity.Property(e => e.LastopenIp)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("lastopen_ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastsentDate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("lastsent_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("source")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<JosAcymailingTag>(entity =>
            {
                entity.HasKey(e => e.Tagid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_tag");

                entity.HasIndex(e => e.Userid, "useridindex");

                entity.Property(e => e.Tagid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("tagid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<JosAcymailingTagmail>(entity =>
            {
                entity.HasKey(e => new { e.Tagid, e.Mailid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_acymailing_tagmail");

                entity.Property(e => e.Tagid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("tagid");

                entity.Property(e => e.Mailid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailid");
            });

            modelBuilder.Entity<JosAcymailingTemplate>(entity =>
            {
                entity.HasKey(e => e.Tempid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_template");

                entity.HasIndex(e => e.Namekey, "namekey")
                    .IsUnique();

                entity.HasIndex(e => e.Ordering, "orderingindex");

                entity.Property(e => e.Tempid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("tempid");

                entity.Property(e => e.Access)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("access")
                    .HasDefaultValueSql("'all'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Altbody)
                    .HasColumnType("longtext")
                    .HasColumnName("altbody")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Body)
                    .HasColumnType("longtext")
                    .HasColumnName("body")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("category")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fromemail)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("fromemail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fromname)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("fromname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Header)
                    .HasColumnType("longtext")
                    .HasColumnName("header")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Namekey)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("namekey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ordering")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Premium)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("premium");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Readmore)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("readmore")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Replyemail)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("replyemail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Replyname)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("replyname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Styles)
                    .HasColumnType("text")
                    .HasColumnName("styles")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Stylesheet)
                    .HasColumnType("text")
                    .HasColumnName("stylesheet")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subject)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("subject")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thumb)
                    .HasColumnType("varchar(250)")
                    .HasColumnName("thumb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAcymailingUrl>(entity =>
            {
                entity.HasKey(e => e.Urlid)
                    .HasName("PRIMARY");

                entity.ToTable("jos_acymailing_url");

                entity.HasIndex(e => e.Url, "url")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 250 });

                entity.Property(e => e.Urlid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("urlid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("url")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAcymailingUrlclick>(entity =>
            {
                entity.HasKey(e => new { e.Urlid, e.Mailid, e.Subid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("jos_acymailing_urlclick");

                entity.HasIndex(e => e.Date, "dateindex");

                entity.HasIndex(e => e.Mailid, "mailidindex");

                entity.HasIndex(e => e.Subid, "subidindex");

                entity.Property(e => e.Urlid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("urlid");

                entity.Property(e => e.Mailid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailid");

                entity.Property(e => e.Subid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("subid");

                entity.Property(e => e.Click)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("click");

                entity.Property(e => e.Date)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("date");

                entity.Property(e => e.Ip)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAcymailingUserstat>(entity =>
            {
                entity.HasKey(e => new { e.Mailid, e.Subid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_acymailing_userstats");

                entity.HasIndex(e => e.Senddate, "senddateindex");

                entity.HasIndex(e => e.Subid, "subidindex");

                entity.Property(e => e.Mailid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailid");

                entity.Property(e => e.Subid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("subid");

                entity.Property(e => e.Bounce)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("bounce");

                entity.Property(e => e.Bouncerule)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("bouncerule")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Browser)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("browser")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BrowserVersion)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("browser_version");

                entity.Property(e => e.Fail)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("fail");

                entity.Property(e => e.Html)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("html")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Ip)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsMobile)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("is_mobile");

                entity.Property(e => e.MobileOs)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mobile_os")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Open)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("open");

                entity.Property(e => e.Opendate)
                    .HasColumnType("int(11)")
                    .HasColumnName("opendate");

                entity.Property(e => e.Senddate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("senddate");

                entity.Property(e => e.Sent)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("sent")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserAgent)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_agent")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAkProfile>(entity =>
            {
                entity.ToTable("jos_ak_profiles");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Configuration)
                    .HasColumnType("longtext")
                    .HasColumnName("configuration")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Filters)
                    .HasColumnType("longtext")
                    .HasColumnName("filters")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Quickicon)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("quickicon")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosAkStat>(entity =>
            {
                entity.ToTable("jos_ak_stats");

                entity.HasIndex(e => new { e.Filesexist, e.Status }, "idx_fullstatus");

                entity.HasIndex(e => new { e.Status, e.Origin }, "idx_stale");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AbsolutePath)
                    .HasColumnType("longtext")
                    .HasColumnName("absolute_path")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Archivename)
                    .HasColumnType("longtext")
                    .HasColumnName("archivename")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Backupend)
                    .HasColumnType("timestamp")
                    .HasColumnName("backupend");

                entity.Property(e => e.Backupid)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("backupid")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Backupstart)
                    .HasColumnType("timestamp")
                    .HasColumnName("backupstart");

                entity.Property(e => e.Comment)
                    .HasColumnType("longtext")
                    .HasColumnName("comment")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Filesexist)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("filesexist")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Frozen).HasColumnName("frozen");

                entity.Property(e => e.Instep).HasColumnName("instep");

                entity.Property(e => e.Multipart)
                    .HasColumnType("int(11)")
                    .HasColumnName("multipart");

                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("origin")
                    .HasDefaultValueSql("'backend'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ProfileId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("profile_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.RemoteFilename)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("remote_filename")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("enum('run','fail','complete')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'run'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Tag)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tag")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TotalSize)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("total_size");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'full'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosAkStorage>(entity =>
            {
                entity.HasKey(e => e.Tag)
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.ToTable("jos_ak_storage");

                entity.Property(e => e.Tag)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tag")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Data)
                    .HasColumnType("longtext")
                    .HasColumnName("data")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("lastupdate")
                    .HasDefaultValueSql("current_timestamp()");
            });

            modelBuilder.Entity<JosAkeebaCommon>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PRIMARY");

                entity.ToTable("jos_akeeba_common");

                entity.Property(e => e.Key)
                    .HasColumnType("varchar(190)")
                    .HasColumnName("key")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosAllvideoshareAdvert>(entity =>
            {
                entity.ToTable("jos_allvideoshare_adverts");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5)")
                    .HasColumnName("id");

                entity.Property(e => e.Clicks)
                    .HasColumnType("int(10)")
                    .HasColumnName("clicks");

                entity.Property(e => e.Impressions)
                    .HasColumnType("int(10)")
                    .HasColumnName("impressions");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("link")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasColumnName("method")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Video)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("video")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAllvideoshareCategory>(entity =>
            {
                entity.ToTable("jos_allvideoshare_categories");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5)")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasColumnName("access")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadescription)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("metadescription")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakeywords)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("metakeywords")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(5)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Parent)
                    .HasColumnType("int(10)")
                    .HasColumnName("parent");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("slug")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thumb)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("thumb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAllvideoshareConfig>(entity =>
            {
                entity.ToTable("jos_allvideoshare_config");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5)")
                    .HasColumnName("id");

                entity.Property(e => e.AutoApproval)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("auto_approval");

                entity.Property(e => e.Category)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("category");

                entity.Property(e => e.Cols)
                    .HasColumnType("int(3)")
                    .HasColumnName("cols");

                entity.Property(e => e.CommentsColor)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasColumnName("comments_color")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommentsPosts)
                    .HasColumnType("int(3)")
                    .HasColumnName("comments_posts");

                entity.Property(e => e.CommentsType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("comments_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomCss)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("custom_css")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("description");

                entity.Property(e => e.Fbappid)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasColumnName("fbappid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FeedLimit)
                    .HasColumnType("int(10)")
                    .HasColumnName("feed_limit");

                entity.Property(e => e.ImageRatio)
                    .HasPrecision(16, 2)
                    .HasColumnName("image_ratio");

                entity.Property(e => e.IsPremium)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("is_premium");

                entity.Property(e => e.ItemidVideo)
                    .HasColumnType("int(5)")
                    .HasColumnName("itemid_video");

                entity.Property(e => e.Layout)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasColumnName("layout")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LoadBootstrapCss)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("load_bootstrap_css");

                entity.Property(e => e.LoadIcomoonFont)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("load_icomoon_font");

                entity.Property(e => e.MultiCategories)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("multi_categories");

                entity.Property(e => e.Playerid)
                    .HasColumnType("int(10)")
                    .HasColumnName("playerid");

                entity.Property(e => e.Popup)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("popup");

                entity.Property(e => e.Relatedvideoslimit)
                    .HasColumnType("int(3)")
                    .HasColumnName("relatedvideoslimit");

                entity.Property(e => e.Rows)
                    .HasColumnType("int(3)")
                    .HasColumnName("rows");

                entity.Property(e => e.Search)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("search");

                entity.Property(e => e.ShowFeed)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("show_feed");

                entity.Property(e => e.ShowGdprConsent)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("show_gdpr_consent");

                entity.Property(e => e.Title)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("title");

                entity.Property(e => e.TypeHls)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type_hls");

                entity.Property(e => e.TypeRtmp)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type_rtmp");

                entity.Property(e => e.TypeVimeo)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type_vimeo");

                entity.Property(e => e.TypeYoutube)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("type_youtube");

                entity.Property(e => e.Views)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("views");
            });

            modelBuilder.Entity<JosAllvideoshareLicensing>(entity =>
            {
                entity.ToTable("jos_allvideoshare_licensing");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5)")
                    .HasColumnName("id");

                entity.Property(e => e.Displaylogo)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("displaylogo");

                entity.Property(e => e.Licensekey)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("licensekey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("logo")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Logoalpha)
                    .HasColumnType("int(3)")
                    .HasColumnName("logoalpha");

                entity.Property(e => e.Logoposition)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("logoposition")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Logotarget)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("logotarget")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAllvideosharePlayer>(entity =>
            {
                entity.ToTable("jos_allvideoshare_players");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5)")
                    .HasColumnName("id");

                entity.Property(e => e.AdEngine)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("ad_engine")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Autostart)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("autostart");

                entity.Property(e => e.Buffer)
                    .HasColumnType("int(2)")
                    .HasColumnName("buffer");

                entity.Property(e => e.Controlbar)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("controlbar");

                entity.Property(e => e.Controlbarbgcolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("controlbarbgcolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Controlbaroutlinecolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("controlbaroutlinecolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Controlbaroverlayalpha)
                    .HasColumnType("int(3)")
                    .HasColumnName("controlbaroverlayalpha");

                entity.Property(e => e.Controlbaroverlaycolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("controlbaroverlaycolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Customplayerpage)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customplayerpage")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Durationdock)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("durationdock");

                entity.Property(e => e.Embeddock)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("embeddock");

                entity.Property(e => e.Facebookdock)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("facebookdock");

                entity.Property(e => e.Fullscreendock)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("fullscreendock");

                entity.Property(e => e.Hddock)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("hddock");

                entity.Property(e => e.Iconcolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("iconcolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LivestreamAdInterval)
                    .HasColumnType("int(10)")
                    .HasColumnName("livestream_ad_interval");

                entity.Property(e => e.Loop)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("loop");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Playlist)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("playlist");

                entity.Property(e => e.Playlistbgcolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("playlistbgcolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Postroll)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("postroll");

                entity.Property(e => e.Preroll)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("preroll");

                entity.Property(e => e.Progressbarbgcolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("progressbarbgcolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Progressbarbuffercolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("progressbarbuffercolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Progressbarseekcolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("progressbarseekcolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published");

                entity.Property(e => e.Ratio)
                    .HasPrecision(16, 2)
                    .HasColumnName("ratio");

                entity.Property(e => e.Sharedock)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("sharedock");

                entity.Property(e => e.Stretch)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("stretch")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timerdock)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("timerdock");

                entity.Property(e => e.Twitterdock)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("twitterdock");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VastUrl)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vast_url")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Volumebarbgcolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("volumebarbgcolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Volumebarseekcolor)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("volumebarseekcolor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Volumelevel)
                    .HasColumnType("int(2)")
                    .HasColumnName("volumelevel");

                entity.Property(e => e.VpaidMode)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("vpaid_mode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosAllvideoshareVideo>(entity =>
            {
                entity.ToTable("jos_allvideoshare_videos");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5)")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasColumnName("access")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("category")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Catid)
                    .HasColumnType("int(5)")
                    .HasColumnName("catid");

                entity.Property(e => e.Catids)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("catids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dvr)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("dvr");

                entity.Property(e => e.Featured)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("featured");

                entity.Property(e => e.Hd)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hd")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hls)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hls")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadescription)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("metadescription")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(5)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Preview)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("preview")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("slug")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Streamer)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("streamer")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tags")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thirdparty)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("thirdparty")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thumb)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("thumb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Video)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("video")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Views)
                    .HasColumnType("int(5)")
                    .HasColumnName("views");
            });

            modelBuilder.Entity<JosAsset>(entity =>
            {
                entity.ToTable("jos_assets");

                entity.HasIndex(e => e.Name, "idx_asset_name")
                    .IsUnique();

                entity.HasIndex(e => new { e.Lft, e.Rgt }, "idx_lft_rgt");

                entity.HasIndex(e => e.ParentId, "idx_parent_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id")
                    .HasComment("Primary Key");

                entity.Property(e => e.Level)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("level")
                    .HasComment("The cached level in the nested tree.");

                entity.Property(e => e.Lft)
                    .HasColumnType("int(11)")
                    .HasColumnName("lft")
                    .HasComment("Nested set lft.");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("name")
                    .HasComment("The unique name for the asset.\n")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent_id")
                    .HasComment("Nested set parent.");

                entity.Property(e => e.Rgt)
                    .HasColumnType("int(11)")
                    .HasColumnName("rgt")
                    .HasComment("Nested set rgt.");

                entity.Property(e => e.Rules)
                    .IsRequired()
                    .HasColumnType("varchar(5120)")
                    .HasColumnName("rules")
                    .HasComment("JSON encoded access control.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("title")
                    .HasComment("The descriptive title for the asset.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosAssociation>(entity =>
            {
                entity.HasKey(e => new { e.Context, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_associations");

                entity.HasIndex(e => e.Key, "idx_key");

                entity.Property(e => e.Context)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("context")
                    .HasComment("The context of the associated item.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("A reference to the associated item.");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnType("char(32)")
                    .HasColumnName("key")
                    .HasComment("The key for the association computed from an md5 on associated ids.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosBanner>(entity =>
            {
                entity.ToTable("jos_banners");

                entity.HasIndex(e => e.Catid, "idx_banner_catid");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => e.MetakeyPrefix, "idx_metakey_prefix")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.OwnPrefix, "idx_own_prefix");

                entity.HasIndex(e => e.State, "idx_state");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.Catid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("catid");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Cid)
                    .HasColumnType("int(11)")
                    .HasColumnName("cid");

                entity.Property(e => e.Clicks)
                    .HasColumnType("int(11)")
                    .HasColumnName("clicks");

                entity.Property(e => e.Clickurl)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasColumnName("clickurl")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedByAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("created_by_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Custombannercode)
                    .IsRequired()
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("custombannercode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Impmade)
                    .HasColumnType("int(11)")
                    .HasColumnName("impmade");

                entity.Property(e => e.Imptotal)
                    .HasColumnType("int(11)")
                    .HasColumnName("imptotal");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metakey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.MetakeyPrefix)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey_prefix")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_by");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.OwnPrefix).HasColumnName("own_prefix");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PurchaseType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("purchase_type")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Reset)
                    .HasColumnType("datetime")
                    .HasColumnName("reset")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("state");

                entity.Property(e => e.Sticky)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("sticky");

                entity.Property(e => e.TrackClicks)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("track_clicks")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.TrackImpressions)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("track_impressions")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasColumnName("type");

                entity.Property(e => e.Version)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosBannerClient>(entity =>
            {
                entity.ToTable("jos_banner_clients");

                entity.HasIndex(e => e.MetakeyPrefix, "idx_metakey_prefix")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.OwnPrefix, "idx_own_prefix");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("contact")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Extrainfo)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("extrainfo")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metakey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.MetakeyPrefix)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("metakey_prefix")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.OwnPrefix)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("own_prefix");

                entity.Property(e => e.PurchaseType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("purchase_type")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("state");

                entity.Property(e => e.TrackClicks)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("track_clicks")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.TrackImpressions)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("track_impressions")
                    .HasDefaultValueSql("'-1'");
            });

            modelBuilder.Entity<JosBannerTrack>(entity =>
            {
                entity.HasKey(e => new { e.TrackDate, e.TrackType, e.BannerId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("jos_banner_tracks");

                entity.HasIndex(e => e.BannerId, "idx_banner_id");

                entity.HasIndex(e => e.TrackDate, "idx_track_date");

                entity.HasIndex(e => e.TrackType, "idx_track_type");

                entity.Property(e => e.TrackDate)
                    .HasColumnType("datetime")
                    .HasColumnName("track_date");

                entity.Property(e => e.TrackType)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("track_type");

                entity.Property(e => e.BannerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("banner_id");

                entity.Property(e => e.Count)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("count");
            });

            modelBuilder.Entity<JosCategory>(entity =>
            {
                entity.ToTable("jos_categories");

                entity.HasIndex(e => new { e.Extension, e.Published, e.Access }, "cat_idx");

                entity.HasIndex(e => e.Access, "idx_access");

                entity.HasIndex(e => e.Alias, "idx_alias")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => new { e.Lft, e.Rgt }, "idx_left_right");

                entity.HasIndex(e => e.Path, "idx_path")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("access");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("asset_id")
                    .HasComment("FK to the #__assets table.");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_user_id");

                entity.Property(e => e.Description)
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("extension")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Lft)
                    .HasColumnType("int(11)")
                    .HasColumnName("lft");

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("metadata")
                    .HasDefaultValueSql("''")
                    .HasComment("JSON encoded metadata properties.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasComment("The meta description for the page.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasComment("The meta keywords for the page.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_user_id");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Params)
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("path")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.Rgt)
                    .HasColumnType("int(11)")
                    .HasColumnName("rgt");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Version)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosContactDetail>(entity =>
            {
                entity.ToTable("jos_contact_details");

                entity.HasIndex(e => e.Access, "idx_access");

                entity.HasIndex(e => e.Catid, "idx_catid");

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.CreatedBy, "idx_createdby");

                entity.HasIndex(e => new { e.Featured, e.Catid }, "idx_featured_catid");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => e.Published, "idx_state");

                entity.HasIndex(e => e.Xreference, "idx_xreference");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("access");

                entity.Property(e => e.Address)
                    .HasColumnType("mediumtext")
                    .HasColumnName("address")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("alias")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_bin");

                entity.Property(e => e.Catid)
                    .HasColumnType("int(11)")
                    .HasColumnName("catid");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ConPosition)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("con_position")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Country)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("country")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedByAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("created_by_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.DefaultCon)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("default_con");

                entity.Property(e => e.EmailTo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email_to")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Fax)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fax")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Featured)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("featured")
                    .HasComment("Set if article is featured.");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.Image)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("image")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("varchar(7)")
                    .HasColumnName("language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metadata")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metadesc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metakey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Misc)
                    .HasColumnType("longtext")
                    .HasColumnName("misc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mobile")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_by");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Postcode)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("postcode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.Sortname1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sortname1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Sortname2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sortname2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Sortname3)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sortname3")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.State)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("state")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Suburb)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("suburb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Telephone)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("telephone")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.Property(e => e.Version)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Webpage)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("webpage")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Xreference)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("xreference")
                    .HasDefaultValueSql("''")
                    .HasComment("A reference to enable linkages to external data sets.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosContent>(entity =>
            {
                entity.ToTable("jos_content");

                entity.HasIndex(e => e.Access, "idx_access");

                entity.HasIndex(e => e.Alias, "idx_alias")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.Catid, "idx_catid");

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.CreatedBy, "idx_createdby");

                entity.HasIndex(e => new { e.Featured, e.Catid }, "idx_featured_catid");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => e.State, "idx_state");

                entity.HasIndex(e => e.Xreference, "idx_xreference");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("access");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("asset_id")
                    .HasComment("FK to the #__assets table.");

                entity.Property(e => e.Attribs)
                    .IsRequired()
                    .HasColumnType("varchar(5120)")
                    .HasColumnName("attribs")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Catid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("catid");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedByAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("created_by_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Featured)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("featured")
                    .HasComment("Set if article is featured.");

                entity.Property(e => e.Fulltext)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("fulltext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("images")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Introtext)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("introtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasComment("The language code for the article.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metadata")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metadesc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metakey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_by");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("state");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Urls)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("urls")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Version)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Xreference)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("xreference")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosContentFrontpage>(entity =>
            {
                entity.HasKey(e => e.ContentId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_content_frontpage");

                entity.Property(e => e.ContentId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("content_id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");
            });

            modelBuilder.Entity<JosContentRating>(entity =>
            {
                entity.HasKey(e => e.ContentId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_content_rating");

                entity.Property(e => e.ContentId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("content_id");

                entity.Property(e => e.Lastip)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("lastip")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.RatingCount)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rating_count");

                entity.Property(e => e.RatingSum)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rating_sum");
            });

            modelBuilder.Entity<JosContentType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_content_types");

                entity.HasIndex(e => e.TypeAlias, "idx_alias")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("type_id");

                entity.Property(e => e.ContentHistoryOptions)
                    .IsRequired()
                    .HasColumnType("varchar(5120)")
                    .HasColumnName("content_history_options")
                    .HasComment("JSON string for com_contenthistory options")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.FieldMappings)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("field_mappings")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Router)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("router")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Rules)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("rules")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Table)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("table")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TypeAlias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("type_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TypeTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("type_title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosContentitemTagMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_contentitem_tag_map");

                entity.HasComment("Maps items from content tables to tags");

                entity.HasIndex(e => e.CoreContentId, "idx_core_content_id");

                entity.HasIndex(e => new { e.TagDate, e.TagId }, "idx_date_id");

                entity.HasIndex(e => new { e.TagId, e.TypeId }, "idx_tag_type");

                entity.HasIndex(e => new { e.TypeId, e.ContentItemId, e.TagId }, "uc_ItemnameTagid")
                    .IsUnique();

                entity.Property(e => e.ContentItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("content_item_id")
                    .HasComment("PK from the content type table");

                entity.Property(e => e.CoreContentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_content_id")
                    .HasComment("PK from the core content table");

                entity.Property(e => e.TagDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("tag_date")
                    .HasDefaultValueSql("current_timestamp()")
                    .HasComment("Date of most recent save for this tag-item");

                entity.Property(e => e.TagId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tag_id")
                    .HasComment("PK from the tag table");

                entity.Property(e => e.TypeAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("type_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnType("mediumint(8)")
                    .HasColumnName("type_id")
                    .HasComment("PK from the content_type table");
            });

            modelBuilder.Entity<JosCoreLogSearch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_core_log_searches");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.SearchTerm)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("search_term")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosExtension>(entity =>
            {
                entity.HasKey(e => e.ExtensionId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_extensions");

                entity.HasIndex(e => new { e.Element, e.ClientId }, "element_clientid");

                entity.HasIndex(e => new { e.Element, e.Folder, e.ClientId }, "element_folder_clientid");

                entity.HasIndex(e => new { e.Type, e.Element, e.Folder, e.ClientId }, "extension");

                entity.Property(e => e.ExtensionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("extension_id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("access")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ClientId)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("client_id");

                entity.Property(e => e.CustomData)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("custom_data")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Element)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("element")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Enabled)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("enabled");

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("folder")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ManifestCache)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("manifest_cache")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PackageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("package_id")
                    .HasComment("Parent package ID for extensions installed as a package.");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Protected)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("protected");

                entity.Property(e => e.State)
                    .HasColumnType("int(11)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SystemData)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("system_data")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosField>(entity =>
            {
                entity.ToTable("jos_fields");

                entity.HasIndex(e => e.Access, "idx_access");

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.Context, "idx_context")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.CreatedUserId, "idx_created_user_id");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => e.State, "idx_state");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(11)")
                    .HasColumnName("access")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("asset_id");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11)")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("context")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_user_id");

                entity.Property(e => e.DefaultValue)
                    .HasColumnType("text")
                    .HasColumnName("default_value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Fieldparams)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("fieldparams")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("group_id");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("label")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'text'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosFieldsCategory>(entity =>
            {
                entity.HasKey(e => new { e.FieldId, e.CategoryId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_fields_categories");

                entity.Property(e => e.FieldId)
                    .HasColumnType("int(11)")
                    .HasColumnName("field_id");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("category_id");
            });

            modelBuilder.Entity<JosFieldsGroup>(entity =>
            {
                entity.ToTable("jos_fields_groups");

                entity.HasIndex(e => e.Access, "idx_access");

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.Context, "idx_context")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.HasIndex(e => e.CreatedBy, "idx_created_by");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => e.State, "idx_state");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(11)")
                    .HasColumnName("access")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("asset_id");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11)")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("context")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_by");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosFieldsValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_fields_values");

                entity.HasIndex(e => e.FieldId, "idx_field_id");

                entity.HasIndex(e => e.ItemId, "idx_item_id")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 191 });

                entity.Property(e => e.FieldId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("field_id");

                entity.Property(e => e.ItemId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("item_id")
                    .HasComment("Allow references to items which have strings as ids, eg. none db systems.")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Value)
                    .HasColumnType("text")
                    .HasColumnName("value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosFinderFilter>(entity =>
            {
                entity.HasKey(e => e.FilterId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_finder_filters");

                entity.Property(e => e.FilterId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("filter_id");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("alias")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedByAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("created_by_alias")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("data")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MapCount)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("map_count");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_by");

                entity.Property(e => e.Params)
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<JosFinderLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_finder_links");

                entity.HasIndex(e => e.Md5sum, "idx_md5");

                entity.HasIndex(e => new { e.Published, e.State, e.Access, e.PublishStartDate, e.PublishEndDate, e.ListPrice }, "idx_published_list");

                entity.HasIndex(e => new { e.Published, e.State, e.Access, e.PublishStartDate, e.PublishEndDate, e.SalePrice }, "idx_published_sale");

                entity.HasIndex(e => e.Title, "idx_title")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.TypeId, "idx_type");

                entity.HasIndex(e => e.Url, "idx_url")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 75 });

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(5)")
                    .HasColumnName("access")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Indexdate)
                    .HasColumnType("datetime")
                    .HasColumnName("indexdate")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("varchar(8)")
                    .HasColumnName("language")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ListPrice)
                    .HasColumnType("double unsigned")
                    .HasColumnName("list_price");

                entity.Property(e => e.Md5sum)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("md5sum")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Object)
                    .IsRequired()
                    .HasColumnType("mediumblob")
                    .HasColumnName("object");

                entity.Property(e => e.PublishEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_end_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PublishStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_start_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("route")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SalePrice)
                    .HasColumnType("double unsigned")
                    .HasColumnName("sale_price");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.State)
                    .HasColumnType("int(5)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("type_id");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<JosFinderLinksTerms0>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms0");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTerms1>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms1");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTerms2>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms2");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTerms3>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms3");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTerms4>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms4");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTerms5>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms5");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTerms6>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms6");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTerms7>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms7");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTerms8>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms8");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTerms9>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_terms9");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTermsa>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_termsa");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTermsb>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_termsb");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTermsc>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_termsc");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTermsd>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_termsd");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTermse>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_termse");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderLinksTermsf>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.TermId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_links_termsf");

                entity.HasIndex(e => new { e.LinkId, e.TermId, e.Weight }, "idx_link_term_weight");

                entity.HasIndex(e => new { e.TermId, e.Weight }, "idx_term_weight");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderTaxonomy>(entity =>
            {
                entity.ToTable("jos_finder_taxonomy");

                entity.HasIndex(e => e.Access, "access");

                entity.HasIndex(e => new { e.ParentId, e.State, e.Access }, "idx_parent_published");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.ParentId, "parent_id");

                entity.HasIndex(e => e.State, "state");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("access");

                entity.Property(e => e.Ordering)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("ordering");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("parent_id");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<JosFinderTaxonomyMap>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.NodeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_finder_taxonomy_map");

                entity.HasIndex(e => e.LinkId, "link_id");

                entity.HasIndex(e => e.NodeId, "node_id");

                entity.Property(e => e.LinkId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("link_id");

                entity.Property(e => e.NodeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("node_id");
            });

            modelBuilder.Entity<JosFinderTerm>(entity =>
            {
                entity.HasKey(e => e.TermId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_finder_terms");

                entity.HasIndex(e => new { e.Soundex, e.Phrase }, "idx_soundex_phrase");

                entity.HasIndex(e => new { e.Stem, e.Phrase }, "idx_stem_phrase");

                entity.HasIndex(e => e.Term, "idx_term")
                    .IsUnique();

                entity.HasIndex(e => new { e.Term, e.Phrase }, "idx_term_phrase");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.Common)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("common");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Links)
                    .HasColumnType("int(10)")
                    .HasColumnName("links");

                entity.Property(e => e.Phrase)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("phrase");

                entity.Property(e => e.Soundex)
                    .IsRequired()
                    .HasColumnType("varchar(75)")
                    .HasColumnName("soundex")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Stem)
                    .IsRequired()
                    .HasColumnType("varchar(75)")
                    .HasColumnName("stem")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Term)
                    .IsRequired()
                    .HasColumnType("varchar(75)")
                    .HasColumnName("term")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<JosFinderTermsCommon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_finder_terms_common");

                entity.HasIndex(e => e.Language, "idx_lang");

                entity.HasIndex(e => new { e.Term, e.Language }, "idx_word_lang");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("varchar(3)")
                    .HasColumnName("language")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Term)
                    .IsRequired()
                    .HasColumnType("varchar(75)")
                    .HasColumnName("term")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<JosFinderToken>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_finder_tokens");

                entity.HasIndex(e => e.Context, "idx_context");

                entity.HasIndex(e => e.Term, "idx_word");

                entity.Property(e => e.Common)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("common");

                entity.Property(e => e.Context)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("context")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Phrase)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("phrase");

                entity.Property(e => e.Stem)
                    .IsRequired()
                    .HasColumnType("varchar(75)")
                    .HasColumnName("stem")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Term)
                    .IsRequired()
                    .HasColumnType("varchar(75)")
                    .HasColumnName("term")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Weight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("weight")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosFinderTokensAggregate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_finder_tokens_aggregate");

                entity.HasIndex(e => e.TermId, "keyword_id");

                entity.HasIndex(e => e.Term, "token");

                entity.Property(e => e.Common)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("common");

                entity.Property(e => e.Context)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("context")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.ContextWeight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("context_weight");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MapSuffix)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasColumnName("map_suffix")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Phrase)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("phrase");

                entity.Property(e => e.Stem)
                    .IsRequired()
                    .HasColumnType("varchar(75)")
                    .HasColumnName("stem")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Term)
                    .IsRequired()
                    .HasColumnType("varchar(75)")
                    .HasColumnName("term")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TermId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("term_id");

                entity.Property(e => e.TermWeight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("term_weight");

                entity.Property(e => e.TotalWeight)
                    .HasColumnType("float unsigned")
                    .HasColumnName("total_weight");
            });

            modelBuilder.Entity<JosFinderType>(entity =>
            {
                entity.ToTable("jos_finder_types");

                entity.HasIndex(e => e.Title, "title")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Mime)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("mime")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<JosJcomment>(entity =>
            {
                entity.ToTable("jos_jcomments");

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.Email, "idx_email");

                entity.HasIndex(e => e.Lang, "idx_lang");

                entity.HasIndex(e => new { e.ObjectId, e.ObjectGroup, e.Published, e.Date }, "idx_object");

                entity.HasIndex(e => new { e.Path, e.Level }, "idx_path");

                entity.HasIndex(e => e.Source, "idx_source");

                entity.HasIndex(e => e.Subscribe, "idx_subscribe");

                entity.HasIndex(e => e.ThreadId, "idx_thread");

                entity.HasIndex(e => e.Userid, "idx_userid");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("comment")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Deleted)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("deleted");

                entity.Property(e => e.Editor)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("editor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Homepage)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("homepage")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnType("varchar(39)")
                    .HasColumnName("ip")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Isgood)
                    .HasColumnType("smallint(5)")
                    .HasColumnName("isgood");

                entity.Property(e => e.Ispoor)
                    .HasColumnType("smallint(5)")
                    .HasColumnName("ispoor");

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("lang")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObjectGroup)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("object_group")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("object_id");

                entity.Property(e => e.ObjectParams)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("object_params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Parent)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("parent");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("path")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("published");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("source")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SourceId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("source_id");

                entity.Property(e => e.Subscribe)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("subscribe");

                entity.Property(e => e.ThreadId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("thread_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("userid");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("username")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosJcommentsBlacklist>(entity =>
            {
                entity.ToTable("jos_jcomments_blacklist");

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.Ip, "idx_ip");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.Editor)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("editor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Expire)
                    .HasColumnType("datetime")
                    .HasColumnName("expire")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnType("varchar(39)")
                    .HasColumnName("ip")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("tinytext")
                    .HasColumnName("notes")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("tinytext")
                    .HasColumnName("reason")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<JosJcommentsCustomBbcode>(entity =>
            {
                entity.ToTable("jos_jcomments_custom_bbcodes");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ButtonAcl)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("button_acl")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ButtonCloseTag)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("button_close_tag")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ButtonCss)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("button_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ButtonEnabled)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("button_enabled");

                entity.Property(e => e.ButtonImage)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("button_image")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ButtonOpenTag)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("button_open_tag")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ButtonPrompt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("button_prompt")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ButtonTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("button_title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("ordering");

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("pattern")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("published");

                entity.Property(e => e.ReplacementHtml)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("replacement_html")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReplacementText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("replacement_text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SimplePattern)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("simple_pattern")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SimpleReplacementHtml)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("simple_replacement_html")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SimpleReplacementText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("simple_replacement_text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosJcommentsMailq>(entity =>
            {
                entity.ToTable("jos_jcomments_mailq");

                entity.HasIndex(e => e.Attempts, "idx_attempts");

                entity.HasIndex(e => e.Priority, "idx_priority");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Attempts).HasColumnName("attempts");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("body")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.SessionId)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("session_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("subject")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosJcommentsObject>(entity =>
            {
                entity.ToTable("jos_jcomments_objects");

                entity.HasIndex(e => new { e.ObjectId, e.ObjectGroup, e.Lang }, "idx_object");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("access");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("category_id");

                entity.Property(e => e.Expired)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("expired");

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasColumnType("varchar(20)")
                    .HasColumnName("lang")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("link")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ObjectGroup)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("object_group")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("object_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<JosJcommentsReport>(entity =>
            {
                entity.ToTable("jos_jcomments_reports");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Commentid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("commentid");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnType("varchar(39)")
                    .HasColumnName("ip")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnType("tinytext")
                    .HasColumnName("reason")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("status");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<JosJcommentsSetting>(entity =>
            {
                entity.HasKey(e => new { e.Component, e.Lang, e.Name })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("jos_jcomments_settings");

                entity.Property(e => e.Component)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("component")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lang)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("lang")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosJcommentsSmily>(entity =>
            {
                entity.ToTable("jos_jcomments_smilies");

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(39)")
                    .HasColumnName("alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(39)")
                    .HasColumnName("code")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("image")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published).HasColumnName("published");
            });

            modelBuilder.Entity<JosJcommentsSubscription>(entity =>
            {
                entity.ToTable("jos_jcomments_subscriptions");

                entity.HasIndex(e => e.Hash, "idx_hash");

                entity.HasIndex(e => e.Lang, "idx_lang");

                entity.HasIndex(e => new { e.ObjectId, e.ObjectGroup }, "idx_object");

                entity.HasIndex(e => e.Source, "idx_source");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hash")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lang)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("lang")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObjectGroup)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("object_group")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ObjectId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("object_id");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("published");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("source")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<JosJcommentsVersion>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PRIMARY");

                entity.ToTable("jos_jcomments_version");

                entity.Property(e => e.Version)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("version")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Installed)
                    .HasColumnType("datetime")
                    .HasColumnName("installed")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Previous)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("previous")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<JosJcommentsVote>(entity =>
            {
                entity.ToTable("jos_jcomments_votes");

                entity.HasIndex(e => new { e.Commentid, e.Userid }, "idx_comment");

                entity.HasIndex(e => new { e.Userid, e.Date }, "idx_user");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Commentid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("commentid");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnType("varchar(39)")
                    .HasColumnName("ip")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("userid");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<JosK2Attachment>(entity =>
            {
                entity.ToTable("jos_k2_attachments");

                entity.HasIndex(e => e.ItemId, "itemID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("filename")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(11)")
                    .HasColumnName("hits");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("itemID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TitleAttribute)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("titleAttribute")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosK2Category>(entity =>
            {
                entity.ToTable("jos_k2_categories");

                entity.HasIndex(e => e.Access, "access");

                entity.HasIndex(e => new { e.Published, e.Access, e.Trash }, "category");

                entity.HasIndex(e => e.Language, "language");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Parent, "parent");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Trash, "trash");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(11)")
                    .HasColumnName("access");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("alias")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExtraFieldsGroup)
                    .HasColumnType("int(11)")
                    .HasColumnName("extraFieldsGroup");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("image")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Parent)
                    .HasColumnType("int(11)")
                    .HasColumnName("parent")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Plugins)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("plugins")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("published");

                entity.Property(e => e.Trash)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("trash");
            });

            modelBuilder.Entity<JosK2Comment>(entity =>
            {
                entity.ToTable("jos_k2_comments");

                entity.HasIndex(e => new { e.ItemId, e.Published }, "countComments");

                entity.HasIndex(e => e.ItemId, "itemID");

                entity.HasIndex(e => new { e.Published, e.CommentDate }, "latestComments");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.UserId, "userID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CommentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("commentDate");

                entity.Property(e => e.CommentEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("commentEmail")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommentText)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("commentText")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommentUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("commentURL")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("itemID");

                entity.Property(e => e.Published)
                    .HasColumnType("int(11)")
                    .HasColumnName("published");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("userName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosK2ExtraField>(entity =>
            {
                entity.ToTable("jos_k2_extra_fields");

                entity.HasIndex(e => e.Group, "group");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Group)
                    .HasColumnType("int(11)")
                    .HasColumnName("group");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosK2ExtraFieldsGroup>(entity =>
            {
                entity.ToTable("jos_k2_extra_fields_groups");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosK2Item>(entity =>
            {
                entity.ToTable("jos_k2_items");

                entity.HasIndex(e => e.Catid, "catid");

                entity.HasIndex(e => e.Created, "created");

                entity.HasIndex(e => e.CreatedBy, "created_by");

                entity.HasIndex(e => e.Featured, "featured");

                entity.HasIndex(e => e.FeaturedOrdering, "featured_ordering");

                entity.HasIndex(e => e.Hits, "hits");

                entity.HasIndex(e => new { e.Published, e.PublishUp, e.PublishDown, e.Trash, e.Access }, "item");

                entity.HasIndex(e => e.Language, "language");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => new { e.Title, e.Introtext, e.Fulltext, e.ExtraFieldsSearch, e.ImageCaption, e.ImageCredits, e.VideoCaption, e.VideoCredits, e.Metadesc, e.Metakey }, "search")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.Title, "title")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(11)")
                    .HasColumnName("access");

                entity.Property(e => e.Alias)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("alias")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Catid)
                    .HasColumnType("int(11)")
                    .HasColumnName("catid");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedByAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("created_by_alias")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExtraFields)
                    .HasColumnType("text")
                    .HasColumnName("extra_fields")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ExtraFieldsSearch)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("extra_fields_search")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Featured)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("featured");

                entity.Property(e => e.FeaturedOrdering)
                    .HasColumnType("int(11)")
                    .HasColumnName("featured_ordering");

                entity.Property(e => e.Fulltext)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("fulltext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gallery)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gallery")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.ImageCaption)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("image_caption")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImageCredits)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("image_credits")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Introtext)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("introtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("metadata")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("metadesc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("metakey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Plugins)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("plugins")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up");

                entity.Property(e => e.Published)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("published");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Trash)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("trash");

                entity.Property(e => e.Video)
                    .HasColumnType("text")
                    .HasColumnName("video")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VideoCaption)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("video_caption")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VideoCredits)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("video_credits")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosK2Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_k2_log");

                entity.Property(e => e.Response)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("response")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11)")
                    .HasColumnName("status");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<JosK2Rating>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_k2_rating");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("itemID");

                entity.Property(e => e.Lastip)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("lastip")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RatingCount)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("rating_count");

                entity.Property(e => e.RatingSum)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("rating_sum");
            });

            modelBuilder.Entity<JosK2Tag>(entity =>
            {
                entity.ToTable("jos_k2_tags");

                entity.HasIndex(e => e.Name, "name")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.HasIndex(e => e.Published, "published");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("published");
            });

            modelBuilder.Entity<JosK2TagsXref>(entity =>
            {
                entity.ToTable("jos_k2_tags_xref");

                entity.HasIndex(e => e.ItemId, "itemID");

                entity.HasIndex(e => e.TagId, "tagID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("itemID");

                entity.Property(e => e.TagId)
                    .HasColumnType("int(11)")
                    .HasColumnName("tagID");
            });

            modelBuilder.Entity<JosK2User>(entity =>
            {
                entity.ToTable("jos_k2_users");

                entity.HasIndex(e => e.Group, "group");

                entity.HasIndex(e => e.UserId, "userID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("enum('m','f')")
                    .HasColumnName("gender")
                    .HasDefaultValueSql("'m'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Group)
                    .HasColumnType("int(11)")
                    .HasColumnName("group");

                entity.Property(e => e.Hostname)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hostname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Image)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("image")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasColumnName("ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("notes")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Plugins)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("plugins")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("url")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("userID");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("userName")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosK2UserGroup>(entity =>
            {
                entity.ToTable("jos_k2_user_groups");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Permissions)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("permissions")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosLanguage>(entity =>
            {
                entity.HasKey(e => e.LangId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_languages");

                entity.HasIndex(e => e.Access, "idx_access");

                entity.HasIndex(e => e.LangCode, "idx_langcode")
                    .IsUnique();

                entity.HasIndex(e => e.Ordering, "idx_ordering");

                entity.HasIndex(e => e.Sef, "idx_sef")
                    .IsUnique();

                entity.Property(e => e.LangId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("lang_id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("access");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("asset_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(512)")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("image")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LangCode)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("lang_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metadesc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metakey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .HasColumnType("int(11)")
                    .HasColumnName("published");

                entity.Property(e => e.Sef)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("sef")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Sitename)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("sitename")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TitleNative)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("title_native")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosMenu>(entity =>
            {
                entity.ToTable("jos_menu");

                entity.HasIndex(e => e.Alias, "idx_alias")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => new { e.ClientId, e.ParentId, e.Alias, e.Language }, "idx_client_id_parent_id_alias_language")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 100, 0 });

                entity.HasIndex(e => new { e.ComponentId, e.Menutype, e.Published, e.Access }, "idx_componentid");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => new { e.Lft, e.Rgt }, "idx_left_right");

                entity.HasIndex(e => e.Menutype, "idx_menutype");

                entity.HasIndex(e => e.Path, "idx_path")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("access")
                    .HasComment("The access level required to view the menu item.");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("alias")
                    .HasComment("The SEF alias of the menu item.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.BrowserNav)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("browserNav")
                    .HasComment("The click behaviour of the link.");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out")
                    .HasComment("FK to #__users.id");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("The time the menu item was checked out.");

                entity.Property(e => e.ClientId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("client_id");

                entity.Property(e => e.ComponentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("component_id")
                    .HasComment("FK to #__extensions.id");

                entity.Property(e => e.Home)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("home")
                    .HasComment("Indicates if this menu item is the home or default page.");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("img")
                    .HasComment("The image of the menu item.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("level")
                    .HasComment("The relative level in the tree.");

                entity.Property(e => e.Lft)
                    .HasColumnType("int(11)")
                    .HasColumnName("lft")
                    .HasComment("Nested set lft.");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("link")
                    .HasComment("The actually link the menu item refers to.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Menutype)
                    .IsRequired()
                    .HasColumnType("varchar(24)")
                    .HasColumnName("menutype")
                    .HasComment("The type of menu this item belongs to. FK to #__menu_types.menutype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasComment("JSON encoded data for the menu item.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("parent_id")
                    .HasDefaultValueSql("'1'")
                    .HasComment("The parent menu item in the menu tree.");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("path")
                    .HasComment("The computed path of the menu item based on the alias field.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published")
                    .HasComment("The published state of the menu link.");

                entity.Property(e => e.Rgt)
                    .HasColumnType("int(11)")
                    .HasColumnName("rgt")
                    .HasComment("Nested set rgt.");

                entity.Property(e => e.TemplateStyleId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("template_style_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasComment("The display title of the menu item.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("type")
                    .HasComment("The type of link: Component, URL, Alias, Separator")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosMenuType>(entity =>
            {
                entity.ToTable("jos_menu_types");

                entity.HasIndex(e => e.Menutype, "idx_menutype")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("asset_id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("int(11)")
                    .HasColumnName("client_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Menutype)
                    .IsRequired()
                    .HasColumnType("varchar(24)")
                    .HasColumnName("menutype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(48)")
                    .HasColumnName("title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_messages");

                entity.HasIndex(e => new { e.UserIdTo, e.State }, "useridto_state");

                entity.Property(e => e.MessageId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("message_id");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("date_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.FolderId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("folder_id");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("message")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Priority)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("subject")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserIdFrom)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id_from");

                entity.Property(e => e.UserIdTo)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id_to");
            });

            modelBuilder.Entity<JosMessagesCfg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_messages_cfg");

                entity.HasIndex(e => new { e.UserId, e.CfgName }, "idx_user_var_name")
                    .IsUnique();

                entity.Property(e => e.CfgName)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("cfg_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CfgValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cfg_value")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<JosModule>(entity =>
            {
                entity.ToTable("jos_modules");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => new { e.Module, e.Published }, "newsfeeds");

                entity.HasIndex(e => new { e.Published, e.Access }, "published");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("access");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("asset_id")
                    .HasComment("FK to the #__assets table.");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ClientId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("client_id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasColumnName("content")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Module)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("module")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("position")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.Showtitle)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("showtitle")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosModulesMenu>(entity =>
            {
                entity.HasKey(e => new { e.Moduleid, e.Menuid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_modules_menu");

                entity.Property(e => e.Moduleid)
                    .HasColumnType("int(11)")
                    .HasColumnName("moduleid");

                entity.Property(e => e.Menuid)
                    .HasColumnType("int(11)")
                    .HasColumnName("menuid");
            });

            modelBuilder.Entity<JosNbordersMailsended>(entity =>
            {
                entity.ToTable("jos_nborders_mailsended");

                entity.HasIndex(e => e.OrderId, "order_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DnGenerated)
                    .HasColumnType("int(11)")
                    .HasColumnName("dn_generated")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DnMailed)
                    .HasColumnType("int(1)")
                    .HasColumnName("dn_mailed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_date")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderGenerated)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_generated")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_id");

                entity.Property(e => e.OrderLastchanged)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_lastchanged")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderMailed)
                    .HasColumnType("int(1)")
                    .HasColumnName("order_mailed")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OrderNo)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_no");

                entity.Property(e => e.OrderPrefix)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("order_prefix")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosNbordersTemplate>(entity =>
            {
                entity.ToTable("jos_nborders_template");

                entity.Property(e => e.Id)
                    .HasColumnType("int(3)")
                    .HasColumnName("id");

                entity.Property(e => e.TemplateBody)
                    .HasColumnType("text")
                    .HasColumnName("template_body")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateDefault)
                    .HasColumnType("text")
                    .HasColumnName("template_default")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateFooter)
                    .HasColumnType("text")
                    .HasColumnName("template_footer")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TemplateHeader)
                    .HasColumnType("text")
                    .HasColumnName("template_header")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosNewsfeed>(entity =>
            {
                entity.ToTable("jos_newsfeeds");

                entity.HasIndex(e => e.Access, "idx_access");

                entity.HasIndex(e => e.Catid, "idx_catid");

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.CreatedBy, "idx_createdby");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => e.Published, "idx_state");

                entity.HasIndex(e => e.Xreference, "idx_xreference");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("access");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.CacheTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("cache_time")
                    .HasDefaultValueSql("'3600'");

                entity.Property(e => e.Catid)
                    .HasColumnType("int(11)")
                    .HasColumnName("catid");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedByAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("created_by_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("images")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("link")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metadata")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metadesc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metakey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_by");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Numarticles)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("numarticles")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.Rtl)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("rtl");

                entity.Property(e => e.Version)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Xreference)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("xreference")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosOverrider>(entity =>
            {
                entity.ToTable("jos_overrider");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id")
                    .HasComment("Primary Key");

                entity.Property(e => e.Constant)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("constant")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("file")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.String)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("string")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosPostinstallMessage>(entity =>
            {
                entity.HasKey(e => e.PostinstallMessageId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_postinstall_messages");

                entity.Property(e => e.PostinstallMessageId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("postinstall_message_id");

                entity.Property(e => e.Action)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("action")
                    .HasDefaultValueSql("''")
                    .HasComment("Action method name or URL")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ActionFile)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("action_file")
                    .HasDefaultValueSql("''")
                    .HasComment("RAD URI to the PHP file containing action method")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ActionKey)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("action_key")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ConditionFile)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("condition_file")
                    .HasComment("RAD URI to file holding display condition method")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ConditionMethod)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("condition_method")
                    .HasComment("Display condition method, must return boolean")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.DescriptionKey)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("description_key")
                    .HasDefaultValueSql("''")
                    .HasComment("Lang key for description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Enabled)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ExtensionId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("extension_id")
                    .HasDefaultValueSql("'700'")
                    .HasComment("FK to #__extensions");

                entity.Property(e => e.LanguageClientId)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("language_client_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LanguageExtension)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("language_extension")
                    .HasDefaultValueSql("'com_postinstall'")
                    .HasComment("Extension holding lang keys")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.TitleKey)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title_key")
                    .HasDefaultValueSql("''")
                    .HasComment("Lang key for the title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(10)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'link'")
                    .HasComment("Message type - message, link, action")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.VersionIntroduced)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("version_introduced")
                    .HasDefaultValueSql("'3.2.0'")
                    .HasComment("Version when this message was introduced")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosPrivacyConsent>(entity =>
            {
                entity.ToTable("jos_privacy_consents");

                entity.HasIndex(e => e.UserId, "idx_user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("body")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Remind)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("remind");

                entity.Property(e => e.State)
                    .HasColumnType("int(10)")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("subject")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("token")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<JosPrivacyRequest>(entity =>
            {
                entity.ToTable("jos_privacy_requests");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ConfirmToken)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("confirm_token")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ConfirmTokenCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("confirm_token_created_at")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.RequestType)
                    .IsRequired()
                    .HasColumnType("varchar(25)")
                    .HasColumnName("request_type")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.RequestedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("requested_at")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<JosRedirectLink>(entity =>
            {
                entity.ToTable("jos_redirect_links");

                entity.HasIndex(e => e.ModifiedDate, "idx_link_modifed");

                entity.HasIndex(e => e.OldUrl, "idx_old_url")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("created_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Header)
                    .HasColumnType("smallint(3)")
                    .HasColumnName("header")
                    .HasDefaultValueSql("'301'");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.NewUrl)
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("new_url")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.OldUrl)
                    .IsRequired()
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("old_url")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("published");

                entity.Property(e => e.Referer)
                    .IsRequired()
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("referer")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosRevsliderStaticSlide>(entity =>
            {
                entity.ToTable("jos_revslider_static_slides");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Layers)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("layers")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SliderId)
                    .HasColumnType("int(9)")
                    .HasColumnName("slider_id");
            });

            modelBuilder.Entity<JosSchema>(entity =>
            {
                entity.HasKey(e => new { e.ExtensionId, e.VersionId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_schemas");

                entity.Property(e => e.ExtensionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("extension_id");

                entity.Property(e => e.VersionId)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("version_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_session");

                entity.HasIndex(e => new { e.ClientId, e.Guest }, "client_id_guest");

                entity.HasIndex(e => e.Time, "time");

                entity.HasIndex(e => e.Userid, "userid");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(192)
                    .HasColumnName("session_id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("client_id");

                entity.Property(e => e.Data)
                    .HasColumnType("mediumtext")
                    .HasColumnName("data")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guest)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("guest")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Time)
                    .HasColumnType("int(11)")
                    .HasColumnName("time");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11)")
                    .HasColumnName("userid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Username)
                    .HasColumnType("varchar(150)")
                    .HasColumnName("username")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosSpmedium>(entity =>
            {
                entity.ToTable("jos_spmedia");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Alt)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("alt")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Caption)
                    .IsRequired()
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("caption")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("extension")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MediaAttr)
                    .IsRequired()
                    .HasColumnType("varchar(5120)")
                    .HasColumnName("media_attr")
                    .HasDefaultValueSql("'{}'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("path")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Thumb)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("thumb")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'image'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosSppagebuilder>(entity =>
            {
                entity.ToTable("jos_sppagebuilder");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10)")
                    .HasColumnName("access");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("asset_id");

                entity.Property(e => e.Attribs)
                    .IsRequired()
                    .HasColumnType("varchar(5120)")
                    .HasColumnName("attribs")
                    .HasDefaultValueSql("'[]'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Catid)
                    .HasColumnType("int(10)")
                    .HasColumnName("catid");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10)")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Css)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("css")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extension")
                    .HasDefaultValueSql("'com_sppagebuilder'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ExtensionView)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("extension_view")
                    .HasDefaultValueSql("'page'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hits)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("hits");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.OgDescription)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("og_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OgImage)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("og_image")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OgTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("og_title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ViewId)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("view_id");
            });

            modelBuilder.Entity<JosSppagebuilderAddon>(entity =>
            {
                entity.ToTable("jos_sppagebuilder_addons");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosSppagebuilderIntegration>(entity =>
            {
                entity.ToTable("jos_sppagebuilder_integrations");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Component)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("component")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Plugin)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("plugin")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosSppagebuilderLanguage>(entity =>
            {
                entity.ToTable("jos_sppagebuilder_languages");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LangKey)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("lang_key")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LangTag)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("lang_tag")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("version")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosSppagebuilderSection>(entity =>
            {
                entity.ToTable("jos_sppagebuilder_sections");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("created_by");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("section")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosTag>(entity =>
            {
                entity.ToTable("jos_tags");

                entity.HasIndex(e => e.Access, "idx_access");

                entity.HasIndex(e => e.Alias, "idx_alias")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => new { e.Lft, e.Rgt }, "idx_left_right");

                entity.HasIndex(e => e.Path, "idx_path")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => new { e.Published, e.Access }, "tag_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("access");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedByAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("created_by_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_user_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("images")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Lft)
                    .HasColumnType("int(11)")
                    .HasColumnName("lft");

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("metadata")
                    .HasComment("JSON encoded metadata properties.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("metadesc")
                    .HasComment("The meta description for the page.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(1024)")
                    .HasColumnName("metakey")
                    .HasComment("The meta keywords for the page.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_user_id");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("path")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.Rgt)
                    .HasColumnType("int(11)")
                    .HasColumnName("rgt");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Urls)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("urls")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Version)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosTemplateStyle>(entity =>
            {
                entity.ToTable("jos_template_styles");

                entity.HasIndex(e => e.ClientId, "idx_client_id");

                entity.HasIndex(e => new { e.ClientId, e.Home }, "idx_client_id_home");

                entity.HasIndex(e => e.Template, "idx_template");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("client_id");

                entity.Property(e => e.Home)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("home")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Template)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("template")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosUcmBase>(entity =>
            {
                entity.HasKey(e => e.UcmId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_ucm_base");

                entity.HasIndex(e => e.UcmItemId, "idx_ucm_item_id");

                entity.HasIndex(e => e.UcmLanguageId, "idx_ucm_language_id");

                entity.HasIndex(e => e.UcmTypeId, "idx_ucm_type_id");

                entity.Property(e => e.UcmId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("ucm_id");

                entity.Property(e => e.UcmItemId)
                    .HasColumnType("int(10)")
                    .HasColumnName("ucm_item_id");

                entity.Property(e => e.UcmLanguageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ucm_language_id");

                entity.Property(e => e.UcmTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ucm_type_id");
            });

            modelBuilder.Entity<JosUcmContent>(entity =>
            {
                entity.HasKey(e => e.CoreContentId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_ucm_content");

                entity.HasComment("Contains core content data in name spaced fields");

                entity.HasIndex(e => e.CoreAccess, "idx_access");

                entity.HasIndex(e => e.CoreAlias, "idx_alias")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.CoreTypeAlias, "idx_content_type")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.CoreCheckedOutUserId, "idx_core_checked_out_user_id");

                entity.HasIndex(e => e.CoreCreatedUserId, "idx_core_created_user_id");

                entity.HasIndex(e => e.CoreModifiedUserId, "idx_core_modified_user_id");

                entity.HasIndex(e => e.CoreTypeId, "idx_core_type_id");

                entity.HasIndex(e => e.CoreCreatedTime, "idx_created_time");

                entity.HasIndex(e => e.CoreLanguage, "idx_language");

                entity.HasIndex(e => e.CoreModifiedTime, "idx_modified_time");

                entity.HasIndex(e => e.CoreTitle, "idx_title")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => new { e.CoreState, e.CoreAccess }, "tag_idx");

                entity.Property(e => e.CoreContentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_content_id");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("asset_id")
                    .HasComment("FK to the #__assets table.");

                entity.Property(e => e.CoreAccess)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_access");

                entity.Property(e => e.CoreAlias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("core_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_bin");

                entity.Property(e => e.CoreBody)
                    .HasColumnType("mediumtext")
                    .HasColumnName("core_body")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreCatid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_catid");

                entity.Property(e => e.CoreCheckedOutTime)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("core_checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreCheckedOutUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_checked_out_user_id");

                entity.Property(e => e.CoreContentItemId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_content_item_id")
                    .HasComment("ID from the individual type table");

                entity.Property(e => e.CoreCreatedByAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("core_created_by_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreCreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("core_created_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CoreCreatedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_created_user_id");

                entity.Property(e => e.CoreFeatured)
                    .HasColumnType("tinyint(4) unsigned")
                    .HasColumnName("core_featured");

                entity.Property(e => e.CoreHits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_hits");

                entity.Property(e => e.CoreImages)
                    .HasColumnType("text")
                    .HasColumnName("core_images")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreLanguage)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("core_language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreMetadata)
                    .IsRequired()
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("core_metadata")
                    .HasDefaultValueSql("''")
                    .HasComment("JSON encoded metadata properties.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreMetadesc)
                    .HasColumnType("text")
                    .HasColumnName("core_metadesc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreMetakey)
                    .HasColumnType("text")
                    .HasColumnName("core_metakey")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("core_modified_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CoreModifiedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_modified_user_id")
                    .HasComment("Most recent user that modified");

                entity.Property(e => e.CoreOrdering)
                    .HasColumnType("int(11)")
                    .HasColumnName("core_ordering");

                entity.Property(e => e.CoreParams)
                    .HasColumnType("text")
                    .HasColumnName("core_params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CorePublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("core_publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CorePublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("core_publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CoreState).HasColumnName("core_state");

                entity.Property(e => e.CoreTitle)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("core_title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreTypeAlias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("core_type_alias")
                    .HasDefaultValueSql("''")
                    .HasComment("FK to the content types table")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreTypeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_type_id");

                entity.Property(e => e.CoreUrls)
                    .HasColumnType("text")
                    .HasColumnName("core_urls")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.CoreVersion)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("core_version")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CoreXreference)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("core_xreference")
                    .HasDefaultValueSql("''")
                    .HasComment("A reference to enable linkages to external data sets.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosUcmHistory>(entity =>
            {
                entity.HasKey(e => e.VersionId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_ucm_history");

                entity.HasIndex(e => e.SaveDate, "idx_save_date");

                entity.HasIndex(e => new { e.UcmTypeId, e.UcmItemId }, "idx_ucm_item_id");

                entity.Property(e => e.VersionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version_id");

                entity.Property(e => e.CharacterCount)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("character_count")
                    .HasComment("Number of characters in this version.");

                entity.Property(e => e.EditorUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("editor_user_id");

                entity.Property(e => e.KeepForever)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("keep_forever")
                    .HasComment("0=auto delete; 1=keep");

                entity.Property(e => e.SaveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("save_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Sha1Hash)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("sha1_hash")
                    .HasDefaultValueSql("''")
                    .HasComment("SHA1 hash of the version_data column.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UcmItemId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ucm_item_id");

                entity.Property(e => e.UcmTypeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ucm_type_id");

                entity.Property(e => e.VersionData)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("version_data")
                    .HasComment("json-encoded string of version data")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.VersionNote)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("version_note")
                    .HasDefaultValueSql("''")
                    .HasComment("Optional version name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosUpdate>(entity =>
            {
                entity.HasKey(e => e.UpdateId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_updates");

                entity.HasComment("Available Updates");

                entity.Property(e => e.UpdateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("update_id");

                entity.Property(e => e.ClientId)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("client_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("data")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Detailsurl)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("detailsurl")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Element)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("element")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ExtensionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("extension_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtraQuery)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("extra_query")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Folder)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("folder")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Infourl)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("infourl")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UpdateSiteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("update_site_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Version)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("version")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosUpdateSite>(entity =>
            {
                entity.HasKey(e => e.UpdateSiteId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_update_sites");

                entity.HasComment("Update Sites");

                entity.Property(e => e.UpdateSiteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("update_site_id");

                entity.Property(e => e.Enabled)
                    .HasColumnType("int(11)")
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtraQuery)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("extra_query")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LastCheckTimestamp)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("last_check_timestamp")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("location")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Type)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosUpdateSitesExtension>(entity =>
            {
                entity.HasKey(e => new { e.UpdateSiteId, e.ExtensionId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_update_sites_extensions");

                entity.HasComment("Links extensions to update sites");

                entity.Property(e => e.UpdateSiteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("update_site_id");

                entity.Property(e => e.ExtensionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("extension_id");
            });

            modelBuilder.Entity<JosUser>(entity =>
            {
                entity.ToTable("jos_users");

                entity.HasIndex(e => e.Email, "email");

                entity.HasIndex(e => e.Block, "idx_block");

                entity.HasIndex(e => e.Name, "idx_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.Username, "idx_username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Activation)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("activation")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Block)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("block");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.LastResetTime)
                    .HasColumnType("datetime")
                    .HasColumnName("lastResetTime")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("Date of last password reset");

                entity.Property(e => e.LastvisitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastvisitDate")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Otep)
                    .IsRequired()
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("otep")
                    .HasDefaultValueSql("''")
                    .HasComment("One time emergency passwords")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.OtpKey)
                    .IsRequired()
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("otpKey")
                    .HasDefaultValueSql("''")
                    .HasComment("Two factor authentication encrypted keys")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("password")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.RegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registerDate")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.RequireReset)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("requireReset")
                    .HasComment("Require user to reset password on next login");

                entity.Property(e => e.ResetCount)
                    .HasColumnType("int(11)")
                    .HasColumnName("resetCount")
                    .HasComment("Count of password resets since lastResetTime");

                entity.Property(e => e.SendEmail)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("sendEmail")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnType("varchar(150)")
                    .HasColumnName("username")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosUserKey>(entity =>
            {
                entity.ToTable("jos_user_keys");

                entity.HasIndex(e => e.Series, "series")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Invalid)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("invalid");

                entity.Property(e => e.Series)
                    .IsRequired()
                    .HasColumnType("varchar(191)")
                    .HasColumnName("series")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasColumnName("time")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("token")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Uastring)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("uastring")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(150)")
                    .HasColumnName("user_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosUserNote>(entity =>
            {
                entity.ToTable("jos_user_notes");

                entity.HasIndex(e => e.Catid, "idx_category_id");

                entity.HasIndex(e => e.UserId, "idx_user_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("body")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Catid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("catid");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_user_id");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedUserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_user_id");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ReviewTime)
                    .HasColumnType("datetime")
                    .HasColumnName("review_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("state");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("subject")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<JosUserProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_user_profiles");

                entity.HasComment("Simple user profile storage table");

                entity.HasIndex(e => new { e.UserId, e.ProfileKey }, "idx_user_id_profile_key")
                    .IsUnique();

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.ProfileKey)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("profile_key")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ProfileValue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("profile_value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<JosUserUsergroupMap>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GroupId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("jos_user_usergroup_map");

                entity.Property(e => e.UserId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("user_id")
                    .HasComment("Foreign Key to #__users.id");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("group_id")
                    .HasComment("Foreign Key to #__usergroups.id");
            });

            modelBuilder.Entity<JosUsergroup>(entity =>
            {
                entity.ToTable("jos_usergroups");

                entity.HasIndex(e => e.ParentId, "idx_usergroup_adjacency_lookup");

                entity.HasIndex(e => new { e.Lft, e.Rgt }, "idx_usergroup_nested_set_lookup");

                entity.HasIndex(e => new { e.ParentId, e.Title }, "idx_usergroup_parent_title_lookup")
                    .IsUnique();

                entity.HasIndex(e => e.Title, "idx_usergroup_title_lookup");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id")
                    .HasComment("Primary Key");

                entity.Property(e => e.Lft)
                    .HasColumnType("int(11)")
                    .HasColumnName("lft")
                    .HasComment("Nested set lft.");

                entity.Property(e => e.ParentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("parent_id")
                    .HasComment("Adjacency List Reference Id");

                entity.Property(e => e.Rgt)
                    .HasColumnType("int(11)")
                    .HasColumnName("rgt")
                    .HasComment("Nested set rgt.");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosUtf8Conversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jos_utf8_conversion");

                entity.Property(e => e.Converted)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("converted");
            });

            modelBuilder.Entity<JosViewlevel>(entity =>
            {
                entity.ToTable("jos_viewlevels");

                entity.HasIndex(e => e.Title, "idx_assetgroup_title_lookup")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id")
                    .HasComment("Primary Key");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Rules)
                    .IsRequired()
                    .HasColumnType("varchar(5120)")
                    .HasColumnName("rules")
                    .HasComment("JSON encoded access control.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<JosVirtuemartAdminmenuentry>(entity =>
            {
                entity.ToTable("jos_virtuemart_adminmenuentries");

                entity.HasComment("Administration Menu Items");

                entity.HasIndex(e => e.ModuleId, "module_id");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.Property(e => e.Id)
                    .HasColumnType("tinyint(1) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Depends)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasColumnName("depends")
                    .HasDefaultValueSql("''")
                    .HasComment("Names of the Parameters, this Item depends on")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IconClass)
                    .HasColumnType("char(96)")
                    .HasColumnName("icon_class")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasColumnName("link")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModuleId)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("module_id")
                    .HasComment("The ID of the VM Module, this Item is assigned to");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.ParentId)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("parent_id");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Task)
                    .HasColumnType("char(32)")
                    .HasColumnName("task")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tooltip)
                    .HasColumnType("char(128)")
                    .HasColumnName("tooltip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.View)
                    .HasColumnType("char(32)")
                    .HasColumnName("view")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartCalc>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCalcId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_calcs");

                entity.HasIndex(e => e.CalcKind, "calc_kind");

                entity.HasIndex(e => e.PublishDown, "publish_down");

                entity.HasIndex(e => e.PublishUp, "publish_up");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Shared, "shared");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.CalcCurrency)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("calc_currency")
                    .HasComment("Currency of the Rule");

                entity.Property(e => e.CalcDescr)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("calc_descr")
                    .HasDefaultValueSql("''")
                    .HasComment("DESCRIPTION")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("calc_jplugin_id");

                entity.Property(e => e.CalcKind)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("calc_kind")
                    .HasDefaultValueSql("''")
                    .HasComment("DISCOUNT/TAX/MARGIN/COMMISSION")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("calc_name")
                    .HasDefaultValueSql("''")
                    .HasComment("NAME OF THE RULE")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcParams)
                    .IsRequired()
                    .HasColumnType("varchar(15359)")
                    .HasColumnName("calc_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcShopperPublished)
                    .HasColumnName("calc_shopper_published")
                    .HasComment("Visible for Shoppers");

                entity.Property(e => e.CalcValue)
                    .HasPrecision(10, 4)
                    .HasColumnName("calc_value")
                    .HasComment("The Amount");

                entity.Property(e => e.CalcValueMathop)
                    .IsRequired()
                    .HasColumnType("varchar(8)")
                    .HasColumnName("calc_value_mathop")
                    .HasDefaultValueSql("''")
                    .HasComment("THE MATHEMATICAL OPERATION LIKE (+,-,+%,-%)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcVendorPublished)
                    .HasColumnName("calc_vendor_published")
                    .HasComment("Visible for Vendors");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ForOverride).HasColumnName("for_override");

                entity.Property(e => e.HasCategories).HasColumnName("has_categories");

                entity.Property(e => e.HasCountries).HasColumnName("has_countries");

                entity.Property(e => e.HasManufacturers).HasColumnName("has_manufacturers");

                entity.Property(e => e.HasShoppergroups).HasColumnName("has_shoppergroups");

                entity.Property(e => e.HasStates).HasColumnName("has_states");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("Enddate if nothing is set = permanent");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .HasComment("Startdate if nothing is set = permanent");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared).HasColumnName("shared");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'")
                    .HasComment("BELONGS TO VENDOR");
            });

            modelBuilder.Entity<JosVirtuemartCalcCategory>(entity =>
            {
                entity.ToTable("jos_virtuemart_calc_categories");

                entity.HasIndex(e => new { e.VirtuemartCalcId, e.VirtuemartCategoryId }, "virtuemart_calc_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_category_id");
            });

            modelBuilder.Entity<JosVirtuemartCalcCountry>(entity =>
            {
                entity.ToTable("jos_virtuemart_calc_countries");

                entity.HasIndex(e => new { e.VirtuemartCalcId, e.VirtuemartCountryId }, "virtuemart_calc_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartCountryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_country_id");
            });

            modelBuilder.Entity<JosVirtuemartCalcManufacturer>(entity =>
            {
                entity.ToTable("jos_virtuemart_calc_manufacturers");

                entity.HasIndex(e => new { e.VirtuemartCalcId, e.VirtuemartManufacturerId }, "virtuemart_calc_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_manufacturer_id");
            });

            modelBuilder.Entity<JosVirtuemartCalcShoppergroup>(entity =>
            {
                entity.ToTable("jos_virtuemart_calc_shoppergroups");

                entity.HasIndex(e => new { e.VirtuemartCalcId, e.VirtuemartShoppergroupId }, "virtuemart_calc_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");
            });

            modelBuilder.Entity<JosVirtuemartCalcState>(entity =>
            {
                entity.ToTable("jos_virtuemart_calc_states");

                entity.HasIndex(e => new { e.VirtuemartCalcId, e.VirtuemartStateId }, "virtuemart_calc_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartStateId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_state_id");
            });

            modelBuilder.Entity<JosVirtuemartCart>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCartId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_carts");

                entity.HasComment("Used to store the cart");

                entity.HasIndex(e => e.VirtuemartUserId, "virtuemart_user_id");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartCartId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_cart_id");

                entity.Property(e => e.CartData)
                    .HasColumnType("varbinary(50000)")
                    .HasColumnName("cartData");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id");
            });

            modelBuilder.Entity<JosVirtuemartCategoriesArAa>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_categories_ar_aa");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("category_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartCategoriesDeDe>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_categories_de_de");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("category_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartCategoriesEnGb>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_categories_en_gb");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("category_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartCategoriesEsE>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_categories_es_es");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasColumnType("varchar(20000)")
                    .HasColumnName("category_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("char(180)")
                    .HasColumnName("category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("char(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartCategoriesFrFr>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_categories_fr_fr");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("category_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartCategoriesItIt>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_categories_it_it");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("category_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartCategoriesRuRu>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_categories_ru_ru");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("category_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartCategoriesSqAl>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_categories_sq_al");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("category_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartCategory>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_categories");

                entity.HasComment("Product Categories are stored here");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Shared, "shared");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CatParams)
                    .IsRequired()
                    .HasColumnType("varchar(15359)")
                    .HasColumnName("cat_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryLayout)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("category_layout")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryParentId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("category_parent_id");

                entity.Property(e => e.CategoryProductLayout)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("category_product_layout")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryTemplate)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("category_template")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.HasChildren).HasColumnName("has_children");

                entity.Property(e => e.HasMedias).HasColumnName("has_medias");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.LimitListInitial)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("limit_list_initial");

                entity.Property(e => e.LimitListMax)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("limit_list_max");

                entity.Property(e => e.LimitListStart)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("limit_list_start");

                entity.Property(e => e.LimitListStep)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("limit_list_step")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Metaauthor)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("metaauthor")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metarobot)
                    .IsRequired()
                    .HasColumnType("varchar(40)")
                    .HasColumnName("metarobot")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.ProductsPerRow)
                    .IsRequired()
                    .HasColumnType("varchar(1)")
                    .HasColumnName("products_per_row")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared).HasColumnName("shared");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'")
                    .HasComment("BELONGS TO VENDOR");
            });

            modelBuilder.Entity<JosVirtuemartCategoryCategory>(entity =>
            {
                entity.ToTable("jos_virtuemart_category_categories");

                entity.HasComment("Category child-parent relation list");

                entity.HasIndex(e => e.CategoryChildId, "category_child_id");

                entity.HasIndex(e => new { e.CategoryParentId, e.CategoryChildId }, "category_parent_id")
                    .IsUnique();

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CategoryChildId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("category_child_id");

                entity.Property(e => e.CategoryParentId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("category_parent_id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");
            });

            modelBuilder.Entity<JosVirtuemartCategoryMedia>(entity =>
            {
                entity.ToTable("jos_virtuemart_category_medias");

                entity.HasIndex(e => new { e.VirtuemartCategoryId, e.Ordering }, "ordering");

                entity.HasIndex(e => new { e.VirtuemartCategoryId, e.VirtuemartMediaId }, "virtuemart_category_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.VirtuemartMediaId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_media_id");
            });

            modelBuilder.Entity<JosVirtuemartConfig>(entity =>
            {
                entity.HasKey(e => e.VirtuemartConfigId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_configs");

                entity.HasComment("Holds configuration settings");

                entity.Property(e => e.VirtuemartConfigId)
                    .HasColumnType("tinyint(1) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("virtuemart_config_id");

                entity.Property(e => e.Config)
                    .HasColumnType("text")
                    .HasColumnName("config")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");
            });

            modelBuilder.Entity<JosVirtuemartCountry>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCountryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_countries");

                entity.HasComment("Country records");

                entity.HasIndex(e => e.Country2Code, "country_2_code");

                entity.HasIndex(e => e.Country3Code, "country_3_code");

                entity.HasIndex(e => e.CountryName, "country_name");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.Property(e => e.VirtuemartCountryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_country_id");

                entity.Property(e => e.Country2Code)
                    .HasColumnType("char(2)")
                    .HasColumnName("country_2_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Country3Code)
                    .HasColumnType("char(3)")
                    .HasColumnName("country_3_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CountryName)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("country_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartWorldzoneId)
                    .IsRequired()
                    .HasColumnName("virtuemart_worldzone_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartCoupon>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCouponId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_coupons");

                entity.HasComment("Used to store coupon codes");

                entity.HasIndex(e => e.CouponCode, "coupon_code");

                entity.HasIndex(e => e.CouponType, "coupon_type");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartCouponId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_coupon_id");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("coupon_code")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CouponExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_expiry_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CouponStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_start_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CouponType)
                    .IsRequired()
                    .HasColumnType("enum('gift','permanent')")
                    .HasColumnName("coupon_type")
                    .HasDefaultValueSql("'gift'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CouponUsed)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasColumnName("coupon_used")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CouponValue)
                    .HasPrecision(15, 5)
                    .HasColumnName("coupon_value");

                entity.Property(e => e.CouponValueMax)
                    .HasPrecision(15, 5)
                    .HasColumnName("coupon_value_max");

                entity.Property(e => e.CouponValueValid)
                    .HasPrecision(15, 5)
                    .HasColumnName("coupon_value_valid");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PercentOrTotal)
                    .IsRequired()
                    .HasColumnType("enum('percent','total')")
                    .HasColumnName("percent_or_total")
                    .HasDefaultValueSql("'percent'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartCategoryIds)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("virtuemart_category_ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartCouponMaxAttemptPerUser)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("virtuemart_coupon_max_attempt_per_user");

                entity.Property(e => e.VirtuemartProductIds)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("virtuemart_product_ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartShopperIds)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("virtuemart_shopper_ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartShoppergroupIds)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("virtuemart_shoppergroup_ids")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id");
            });

            modelBuilder.Entity<JosVirtuemartCurrency>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCurrencyId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_currencies");

                entity.HasComment("Used to store currencies");

                entity.HasIndex(e => e.CurrencyCode3, "currency_code_3")
                    .IsUnique();

                entity.HasIndex(e => e.CurrencyName, "currency_name");

                entity.HasIndex(e => e.CurrencyNumericCode, "currency_numeric_code");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Shared, "shared");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartCurrencyId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_currency_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CurrencyCode2)
                    .HasColumnType("char(2)")
                    .HasColumnName("currency_code_2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyCode3)
                    .HasColumnType("char(3)")
                    .HasColumnName("currency_code_3")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyDecimalPlace)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("currency_decimal_place")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyDecimalSymbol)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("currency_decimal_symbol")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyExchangeRate)
                    .HasPrecision(12, 5)
                    .HasColumnName("currency_exchange_rate");

                entity.Property(e => e.CurrencyName)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("currency_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyNegativeStyle)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("currency_negative_style")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyNumericCode)
                    .HasColumnType("int(4)")
                    .HasColumnName("currency_numeric_code");

                entity.Property(e => e.CurrencyPositiveStyle)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("currency_positive_style")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencySymbol)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("currency_symbol")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyThousands)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("currency_thousands")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared)
                    .IsRequired()
                    .HasColumnName("shared")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartCustom>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCustomId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_customs");

                entity.HasComment("custom fields definition");

                entity.HasIndex(e => e.CustomElement, "custom_element");

                entity.HasIndex(e => e.CustomParentId, "custom_parent_id");

                entity.HasIndex(e => e.FieldType, "field_type");

                entity.HasIndex(e => e.IsCartAttribute, "is_cart_attribute");

                entity.HasIndex(e => e.IsInput, "is_input");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Searchable, "searchable");

                entity.HasIndex(e => e.Shared, "shared");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartCustomId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_custom_id");

                entity.Property(e => e.AdminOnly)
                    .HasColumnName("admin_only")
                    .HasComment("1:Display in admin only");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CustomDesc)
                    .HasColumnType("varchar(4095)")
                    .HasColumnName("custom_desc")
                    .HasComment("DESCRIPTION OR UNIT")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomElement)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("custom_element")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("custom_jplugin_id");

                entity.Property(e => e.CustomParams)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("custom_params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomParentId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("custom_parent_id");

                entity.Property(e => e.CustomTip)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("custom_tip")
                    .HasDefaultValueSql("''")
                    .HasComment("TIP")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomTitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("custom_title")
                    .HasDefaultValueSql("''")
                    .HasComment("FIELD TITLE")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomValue)
                    .HasColumnType("varchar(4095)")
                    .HasColumnName("custom_value")
                    .HasComment("DEFAULT VALUE")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldType)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasColumnName("field_type")
                    .HasDefaultValueSql("'0'")
                    .HasComment("S:STRING,I:INT,P:PARENT, B:BOOL,D:DATE,T:TIME,H:HIDDEN")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsCartAttribute)
                    .HasColumnName("is_cart_attribute")
                    .HasComment("Add attributes to cart");

                entity.Property(e => e.IsHidden)
                    .HasColumnName("is_hidden")
                    .HasComment("1:hidden");

                entity.Property(e => e.IsInput)
                    .HasColumnName("is_input")
                    .HasComment("Add input to cart");

                entity.Property(e => e.IsList)
                    .HasColumnName("is_list")
                    .HasComment("list of values");

                entity.Property(e => e.LayoutPos)
                    .HasColumnType("varchar(24)")
                    .HasColumnName("layout_pos")
                    .HasComment("LAYOUT POSITION")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Searchable)
                    .HasColumnName("searchable")
                    .HasComment("Available as search filter");

                entity.Property(e => e.Shared)
                    .HasColumnName("shared")
                    .HasComment("VALID FOR ALL VENDORS?");

                entity.Property(e => e.ShowTitle)
                    .IsRequired()
                    .HasColumnName("show_title")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("virtuemart_shoppergroup_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartInvoice>(entity =>
            {
                entity.HasKey(e => e.VirtuemartInvoiceId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_invoices");

                entity.HasComment("custom fields definition");

                entity.HasIndex(e => new { e.InvoiceNumber, e.VirtuemartVendorId }, "invoice_number")
                    .IsUnique();

                entity.HasIndex(e => e.VirtuemartOrderId, "virtuemart_order_id");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartInvoiceId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_invoice_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.InvHash)
                    .HasColumnType("varchar(33)")
                    .HasColumnName("inv_hash")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("invoice_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OHash)
                    .HasColumnType("varchar(33)")
                    .HasColumnName("o_hash")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatus)
                    .HasColumnType("char(2)")
                    .HasColumnName("order_status")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Xhtml)
                    .HasColumnType("text")
                    .HasColumnName("xhtml")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturer>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers");

                entity.HasComment("Manufacturers are those who deliver products");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => new { e.VirtuemartManufacturerId, e.VirtuemartManufacturercategoriesId }, "virtuemart_manufacturercategories_id")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Metaauthor)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metaauthor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metarobot)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metarobot")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_manufacturercategories_id");
            });

            modelBuilder.Entity<JosVirtuemartManufacturerMedia>(entity =>
            {
                entity.ToTable("jos_virtuemart_manufacturer_medias");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => new { e.VirtuemartManufacturerId, e.VirtuemartMediaId }, "virtuemart_manufacturer_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.VirtuemartMediaId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_media_id");
            });

            modelBuilder.Entity<JosVirtuemartManufacturercategoriesArAa>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories_ar_aa");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturercategories_id");

                entity.Property(e => e.MfCategoryDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_category_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfCategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturercategoriesDeDe>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories_de_de");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturercategories_id");

                entity.Property(e => e.MfCategoryDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_category_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfCategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturercategoriesEnGb>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories_en_gb");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturercategories_id");

                entity.Property(e => e.MfCategoryDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_category_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfCategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturercategoriesEsE>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories_es_es");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturercategories_id");

                entity.Property(e => e.MfCategoryDesc)
                    .IsRequired()
                    .HasColumnType("varchar(20000)")
                    .HasColumnName("mf_category_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfCategoryName)
                    .IsRequired()
                    .HasColumnType("char(180)")
                    .HasColumnName("mf_category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("char(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturercategoriesFrFr>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories_fr_fr");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturercategories_id");

                entity.Property(e => e.MfCategoryDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_category_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfCategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturercategoriesItIt>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories_it_it");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturercategories_id");

                entity.Property(e => e.MfCategoryDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_category_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfCategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturercategoriesRuRu>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories_ru_ru");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturercategories_id");

                entity.Property(e => e.MfCategoryDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_category_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfCategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturercategoriesSqAl>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories_sq_al");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturercategories_id");

                entity.Property(e => e.MfCategoryDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_category_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfCategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_category_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturercategory>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories");

                entity.HasComment("Manufacturers are assigned to these categories");

                entity.HasIndex(e => e.Published, "published");

                entity.Property(e => e.VirtuemartManufacturercategoriesId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_manufacturercategories_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartManufacturersArAa>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers_ar_aa");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturersDeDe>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers_de_de");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturersEnGb>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers_en_gb");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturersEsE>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers_es_es");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(20000)")
                    .HasColumnName("mf_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfEmail)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("mf_email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfName)
                    .IsRequired()
                    .HasColumnType("char(180)")
                    .HasColumnName("mf_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfUrl)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("mf_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("char(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturersFrFr>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers_fr_fr");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturersItIt>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers_it_it");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturersRuRu>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers_ru_ru");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartManufacturersSqAl>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers_sq_al");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("mf_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfEmail)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("mf_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MfUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("mf_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartMedia>(entity =>
            {
                entity.HasKey(e => e.VirtuemartMediaId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_medias");

                entity.HasComment("Additional Images and Files which are assigned to products");

                entity.HasIndex(e => e.FileType, "file_type");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Shared, "shared");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartMediaId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_media_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.FileClass)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("file_class")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileDescription)
                    .IsRequired()
                    .HasColumnType("varchar(254)")
                    .HasColumnName("file_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileIsDownloadable).HasColumnName("file_is_downloadable");

                entity.Property(e => e.FileIsForSale).HasColumnName("file_is_forSale");

                entity.Property(e => e.FileIsProductImage).HasColumnName("file_is_product_image");

                entity.Property(e => e.FileLang)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasColumnName("file_lang")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileMeta)
                    .IsRequired()
                    .HasColumnType("varchar(254)")
                    .HasColumnName("file_meta")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileMimetype)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("file_mimetype")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileParams)
                    .IsRequired()
                    .HasColumnType("varchar(12287)")
                    .HasColumnName("file_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileTitle)
                    .IsRequired()
                    .HasColumnType("varchar(126)")
                    .HasColumnName("file_title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("file_type")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileUrl)
                    .IsRequired()
                    .HasColumnType("varchar(900)")
                    .HasColumnName("file_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FileUrlThumb)
                    .IsRequired()
                    .HasColumnType("varchar(900)")
                    .HasColumnName("file_url_thumb")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared).HasColumnName("shared");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartMigrationOldtonewId>(entity =>
            {
                entity.ToTable("jos_virtuemart_migration_oldtonew_ids");

                entity.HasComment("xref table for vm1 ids to vm2 ids");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Attributes).HasColumnName("attributes");

                entity.Property(e => e.Cats).HasColumnName("cats");

                entity.Property(e => e.Catsxref)
                    .HasColumnType("blob")
                    .HasColumnName("catsxref");

                entity.Property(e => e.Manus).HasColumnName("manus");

                entity.Property(e => e.Mfcats)
                    .HasColumnType("blob")
                    .HasColumnName("mfcats");

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.OrdersStart)
                    .HasColumnType("int(1)")
                    .HasColumnName("orders_start");

                entity.Property(e => e.Orderstates)
                    .HasColumnType("blob")
                    .HasColumnName("orderstates");

                entity.Property(e => e.Products).HasColumnName("products");

                entity.Property(e => e.ProductsStart)
                    .HasColumnType("int(1)")
                    .HasColumnName("products_start");

                entity.Property(e => e.Relatedproducts).HasColumnName("relatedproducts");

                entity.Property(e => e.Shoppergroups).HasColumnName("shoppergroups");
            });

            modelBuilder.Entity<JosVirtuemartModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_modules");

                entity.HasComment("VirtueMart Core Modules, not: Joomla modules");

                entity.HasIndex(e => e.ModuleName, "module_name");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.Property(e => e.ModuleId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("module_id");

                entity.Property(e => e.IsAdmin)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("is_admin")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModuleDescription)
                    .HasColumnType("varchar(15359)")
                    .HasColumnName("module_description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModuleName)
                    .HasColumnType("char(255)")
                    .HasColumnName("module_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModulePerms)
                    .HasColumnType("char(255)")
                    .HasColumnName("module_perms")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartOrder>(entity =>
            {
                entity.HasKey(e => e.VirtuemartOrderId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_orders");

                entity.HasComment("Used to store all orders");

                entity.HasIndex(e => e.CreatedOn, "created_on");

                entity.HasIndex(e => e.OrderNumber, "order_number");

                entity.HasIndex(e => e.VirtuemartPaymentmethodId, "virtuemart_paymentmethod_id");

                entity.HasIndex(e => e.VirtuemartShipmentmethodId, "virtuemart_shipmentmethod_id");

                entity.HasIndex(e => e.VirtuemartUserId, "virtuemart_user_id");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.CouponCode)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("coupon_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CouponDiscount)
                    .HasPrecision(12, 2)
                    .HasColumnName("coupon_discount");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CustomerNumber)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("customer_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("delivery_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InvoiceLocked).HasColumnName("invoice_locked");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnType("char(15)")
                    .HasColumnName("ip_address")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OHash)
                    .HasColumnType("varchar(33)")
                    .HasColumnName("o_hash")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderBillDiscountAmount)
                    .HasPrecision(15, 5)
                    .HasColumnName("order_billDiscountAmount");

                entity.Property(e => e.OrderBillTax)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("order_billTax")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderBillTaxAmount)
                    .HasPrecision(15, 5)
                    .HasColumnName("order_billTaxAmount");

                entity.Property(e => e.OrderCreateInvoicePass)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("order_create_invoice_pass")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderCurrency)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("order_currency");

                entity.Property(e => e.OrderDiscount)
                    .HasPrecision(12, 2)
                    .HasColumnName("order_discount");

                entity.Property(e => e.OrderDiscountAmount)
                    .HasPrecision(15, 5)
                    .HasColumnName("order_discountAmount");

                entity.Property(e => e.OrderLanguage)
                    .HasColumnType("varchar(7)")
                    .HasColumnName("order_language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("order_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderPass)
                    .HasColumnType("varchar(34)")
                    .HasColumnName("order_pass")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderPayment)
                    .HasPrecision(12, 2)
                    .HasColumnName("order_payment");

                entity.Property(e => e.OrderPaymentTax)
                    .HasPrecision(10, 5)
                    .HasColumnName("order_payment_tax");

                entity.Property(e => e.OrderSalesPrice)
                    .HasPrecision(15, 5)
                    .HasColumnName("order_salesPrice");

                entity.Property(e => e.OrderShipment)
                    .HasPrecision(12, 5)
                    .HasColumnName("order_shipment");

                entity.Property(e => e.OrderShipmentTax)
                    .HasPrecision(10, 5)
                    .HasColumnName("order_shipment_tax");

                entity.Property(e => e.OrderStatus)
                    .HasColumnType("char(1)")
                    .HasColumnName("order_status")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderSubtotal)
                    .HasPrecision(15, 5)
                    .HasColumnName("order_subtotal");

                entity.Property(e => e.OrderTax)
                    .HasPrecision(12, 5)
                    .HasColumnName("order_tax");

                entity.Property(e => e.OrderTotal)
                    .HasPrecision(15, 5)
                    .HasColumnName("order_total");

                entity.Property(e => e.Paid)
                    .HasPrecision(15, 5)
                    .HasColumnName("paid");

                entity.Property(e => e.PaidOn)
                    .HasColumnType("datetime")
                    .HasColumnName("paid_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PaymentCurrencyId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("payment_currency_id");

                entity.Property(e => e.PaymentCurrencyRate)
                    .HasPrecision(12, 6)
                    .HasColumnName("payment_currency_rate")
                    .HasDefaultValueSql("'1.000000'");

                entity.Property(e => e.StsameAsBt).HasColumnName("STsameAsBT");

                entity.Property(e => e.UserCurrencyId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("user_currency_id");

                entity.Property(e => e.UserCurrencyRate)
                    .HasPrecision(12, 6)
                    .HasColumnName("user_currency_rate")
                    .HasDefaultValueSql("'1.000000'");

                entity.Property(e => e.UserShoppergroups)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("user_shoppergroups")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id");
            });

            modelBuilder.Entity<JosVirtuemartOrderCalcRule>(entity =>
            {
                entity.HasKey(e => e.VirtuemartOrderCalcRuleId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_order_calc_rules");

                entity.HasComment("Stores all calculation rules which are part of an order");

                entity.HasIndex(e => e.VirtuemartCalcId, "virtuemart_calc_id");

                entity.HasIndex(e => e.VirtuemartOrderId, "virtuemart_order_id");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartOrderCalcRuleId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_calc_rule_id");

                entity.Property(e => e.CalcAmount)
                    .HasPrecision(15, 5)
                    .HasColumnName("calc_amount");

                entity.Property(e => e.CalcCurrency)
                    .HasColumnType("int(1)")
                    .HasColumnName("calc_currency");

                entity.Property(e => e.CalcKind)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("calc_kind")
                    .HasDefaultValueSql("''")
                    .HasComment("Discount/Tax/Margin/Commission")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcMathop)
                    .IsRequired()
                    .HasColumnType("varchar(16)")
                    .HasColumnName("calc_mathop")
                    .HasDefaultValueSql("''")
                    .HasComment("Discount/Tax/Margin/Commission")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcParams)
                    .IsRequired()
                    .HasColumnType("varchar(15359)")
                    .HasColumnName("calc_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcResult)
                    .HasPrecision(15, 5)
                    .HasColumnName("calc_result");

                entity.Property(e => e.CalcRuleName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("calc_rule_name")
                    .HasDefaultValueSql("''")
                    .HasComment("Name of the rule")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcValue)
                    .HasPrecision(15, 5)
                    .HasColumnName("calc_value");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartOrderItemId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_order_item_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartOrderHistory>(entity =>
            {
                entity.HasKey(e => e.VirtuemartOrderHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_order_histories");

                entity.HasComment("Stores all actions and changes that occur to an order");

                entity.HasIndex(e => e.VirtuemartOrderId, "virtuemart_order_id");

                entity.Property(e => e.VirtuemartOrderHistoryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_history_id");

                entity.Property(e => e.Comments)
                    .HasColumnType("varchar(15359)")
                    .HasColumnName("comments")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CustomerNotified).HasColumnName("customer_notified");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OHash)
                    .HasColumnType("varchar(33)")
                    .HasColumnName("o_hash")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatusCode)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasColumnName("order_status_code")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Paid)
                    .HasPrecision(15, 5)
                    .HasColumnName("paid");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");
            });

            modelBuilder.Entity<JosVirtuemartOrderItem>(entity =>
            {
                entity.HasKey(e => e.VirtuemartOrderItemId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_order_items");

                entity.HasComment("Stores all items (products) which are part of an order");

                entity.HasIndex(e => e.OrderStatus, "order_status");

                entity.HasIndex(e => e.VirtuemartOrderId, "virtuemart_order_id");

                entity.HasIndex(e => e.VirtuemartProductId, "virtuemart_product_id");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartOrderItemId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_item_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("delivery_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OiHash)
                    .HasColumnType("varchar(33)")
                    .HasColumnName("oi_hash")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderItemCurrency)
                    .HasColumnType("int(1)")
                    .HasColumnName("order_item_currency");

                entity.Property(e => e.OrderItemName)
                    .IsRequired()
                    .HasColumnType("varchar(4096)")
                    .HasColumnName("order_item_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderItemSku)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("order_item_sku")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatus)
                    .HasColumnType("char(1)")
                    .HasColumnName("order_status")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Paid)
                    .HasPrecision(15, 5)
                    .HasColumnName("paid");

                entity.Property(e => e.ProductAttribute)
                    .HasColumnType("mediumtext")
                    .HasColumnName("product_attribute")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductBasePriceWithTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_basePriceWithTax");

                entity.Property(e => e.ProductDiscountedPriceWithoutTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_discountedPriceWithoutTax");

                entity.Property(e => e.ProductFinalPrice)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_final_price");

                entity.Property(e => e.ProductItemPrice)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_item_price");

                entity.Property(e => e.ProductPriceWithoutTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_priceWithoutTax");

                entity.Property(e => e.ProductQuantity)
                    .HasColumnType("int(1)")
                    .HasColumnName("product_quantity");

                entity.Property(e => e.ProductSubtotalDiscount)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_subtotal_discount");

                entity.Property(e => e.ProductSubtotalWithTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_subtotal_with_tax");

                entity.Property(e => e.ProductTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_tax");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartOrderItemHistory>(entity =>
            {
                entity.HasKey(e => e.VirtuemartOrderItemHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_order_item_histories");

                entity.HasComment("Stores all actions and changes that occur to an order item only");

                entity.HasIndex(e => e.VirtuemartOrderId, "virtuemart_order_id");

                entity.Property(e => e.VirtuemartOrderItemHistoryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_item_history_id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("action")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("delivery_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OiHash)
                    .HasColumnType("varchar(33)")
                    .HasColumnName("oi_hash")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderItemCurrency)
                    .HasColumnType("int(1)")
                    .HasColumnName("order_item_currency");

                entity.Property(e => e.OrderItemName)
                    .IsRequired()
                    .HasColumnType("varchar(4096)")
                    .HasColumnName("order_item_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderItemSku)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("order_item_sku")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatus)
                    .HasColumnType("char(1)")
                    .HasColumnName("order_status")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Paid)
                    .HasPrecision(15, 5)
                    .HasColumnName("paid");

                entity.Property(e => e.ProductAttribute)
                    .HasColumnType("mediumtext")
                    .HasColumnName("product_attribute")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductBasePriceWithTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_basePriceWithTax");

                entity.Property(e => e.ProductDiscountedPriceWithoutTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_discountedPriceWithoutTax");

                entity.Property(e => e.ProductFinalPrice)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_final_price");

                entity.Property(e => e.ProductItemPrice)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_item_price");

                entity.Property(e => e.ProductPriceWithoutTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_priceWithoutTax");

                entity.Property(e => e.ProductQuantity)
                    .HasColumnType("int(1)")
                    .HasColumnName("product_quantity");

                entity.Property(e => e.ProductSubtotalDiscount)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_subtotal_discount");

                entity.Property(e => e.ProductSubtotalWithTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_subtotal_with_tax");

                entity.Property(e => e.ProductTax)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_tax");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartOrderItemId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_item_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartOrderUserinfo>(entity =>
            {
                entity.HasKey(e => e.VirtuemartOrderUserinfoId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_order_userinfos");

                entity.HasComment("Stores the BillTo and ShipTo Information at order time");

                entity.HasIndex(e => e.AddressType, "address_type");

                entity.HasIndex(e => e.VirtuemartOrderId, "virtuemart_order_id");

                entity.HasIndex(e => new { e.VirtuemartUserId, e.AddressType }, "virtuemart_user_id");

                entity.Property(e => e.VirtuemartOrderUserinfoId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_userinfo_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnType("varchar(96)")
                    .HasColumnName("address_1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("address_2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressType)
                    .HasColumnType("char(2)")
                    .HasColumnName("address_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressTypeName)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("address_type_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Agreed).HasColumnName("agreed");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(96)")
                    .HasColumnName("city")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("company")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CustomerNote)
                    .IsRequired()
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("customer_note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fax)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fax")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnType("varchar(96)")
                    .HasColumnName("first_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("last_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MiddleName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("middle_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Phone1)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("phone_1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("phone_2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tos).HasColumnName("tos");

                entity.Property(e => e.VirtuemartCountryId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_country_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartStateId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_state_id");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("zip")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartOrderstate>(entity =>
            {
                entity.HasKey(e => e.VirtuemartOrderstateId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_orderstates");

                entity.HasComment("All available order statuses");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartOrderstateId)
                    .HasColumnType("tinyint(1) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("virtuemart_orderstate_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderStatusCode)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasColumnName("order_status_code")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatusColor)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("order_status_color")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatusDescription)
                    .HasColumnType("varchar(15359)")
                    .HasColumnName("order_status_description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatusName)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("order_status_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStockHandle)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasColumnName("order_stock_handle")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartPaymentPlgAuthorizenet>(entity =>
            {
                entity.ToTable("jos_virtuemart_payment_plg_authorizenet");

                entity.HasComment("Payment AuthorizeNet Table");

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AuthorizenetResponseAccountNumber)
                    .HasColumnType("char(4)")
                    .HasColumnName("authorizenet_response_account_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizenetResponseAuthorizationCode)
                    .HasColumnType("char(10)")
                    .HasColumnName("authorizenet_response_authorization_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizenetResponseCardCodeResponse)
                    .HasColumnType("char(5)")
                    .HasColumnName("authorizenet_response_card_code_response")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizenetResponseCardType)
                    .HasColumnType("char(128)")
                    .HasColumnName("authorizenet_response_card_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizenetResponseCavvResponse)
                    .HasColumnType("char(1)")
                    .HasColumnName("authorizenet_response_cavv_response")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizenetResponseResponseCode)
                    .HasColumnType("char(128)")
                    .HasColumnName("authorizenet_response_response_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizenetResponseResponseReasonCode)
                    .HasPrecision(10, 2)
                    .HasColumnName("authorizenet_response_response_reason_code");

                entity.Property(e => e.AuthorizenetResponseResponseReasonText)
                    .HasColumnType("text")
                    .HasColumnName("authorizenet_response_response_reason_text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizenetResponseResponseSubcode)
                    .HasColumnType("char(13)")
                    .HasColumnName("authorizenet_response_response_subcode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizenetResponseTransactionId)
                    .HasColumnType("char(128)")
                    .HasColumnName("authorizenet_response_transaction_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizenetResponseTransactionType)
                    .HasColumnType("char(50)")
                    .HasColumnName("authorizenet_response_transaction_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AuthorizeresponseRaw)
                    .HasColumnType("text")
                    .HasColumnName("authorizeresponse_raw")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CostPerTransaction)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_per_transaction");

                entity.Property(e => e.CostPercentTotal)
                    .HasColumnType("char(10)")
                    .HasColumnName("cost_percent_total")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("char(64)")
                    .HasColumnName("order_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentCurrency)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("payment_currency");

                entity.Property(e => e.PaymentName)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("payment_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentOrderTotal)
                    .HasPrecision(15, 5)
                    .HasColumnName("payment_order_total");

                entity.Property(e => e.ReturnContext)
                    .HasColumnType("char(255)")
                    .HasColumnName("return_context")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("tax_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");
            });

            modelBuilder.Entity<JosVirtuemartPaymentPlgHeidelpay>(entity =>
            {
                entity.ToTable("jos_virtuemart_payment_plg_heidelpay");

                entity.HasComment("Payment Heidelpay");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("comment")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp")
                    .HasColumnName("date")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("char(64)")
                    .HasColumnName("order_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentCode)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("payment_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentMethode)
                    .HasColumnType("char(2)")
                    .HasColumnName("payment_methode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .HasColumnType("char(50)")
                    .HasColumnName("payment_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentType)
                    .HasColumnType("char(2)")
                    .HasColumnName("payment_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcessingResult)
                    .HasColumnType("char(3)")
                    .HasColumnName("processing_result")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResponseIp)
                    .HasColumnType("char(20)")
                    .HasColumnName("response_ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SecretHash)
                    .HasColumnType("char(50)")
                    .HasColumnName("secret_hash")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShortId)
                    .HasColumnType("varchar(14)")
                    .HasColumnName("short_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TransactionMode)
                    .HasColumnType("char(18)")
                    .HasColumnName("transaction_mode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UniqueId)
                    .HasColumnType("varchar(48)")
                    .HasColumnName("unique_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");
            });

            modelBuilder.Entity<JosVirtuemartPaymentPlgMoneybookersAcc>(entity =>
            {
                entity.ToTable("jos_virtuemart_payment_plg_moneybookers_acc");

                entity.HasComment("Payment Moneybookers Table");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CostPerTransaction)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_per_transaction");

                entity.Property(e => e.CostPercentTotal)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_percent_total");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MbAmount)
                    .HasPrecision(19, 2)
                    .HasColumnName("mb_amount");

                entity.Property(e => e.MbCurrency)
                    .HasColumnType("char(3)")
                    .HasColumnName("mb_currency")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MbMd5sig)
                    .HasColumnType("char(32)")
                    .HasColumnName("mb_md5sig")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MbMerchantId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mb_merchant_id");

                entity.Property(e => e.MbPayFromEmail)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("mb_pay_from_email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MbPayToEmail)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("mb_pay_to_email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MbRecPaymentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mb_rec_payment_id");

                entity.Property(e => e.MbRecPaymentType)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("mb_rec_payment_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MbSha2sig)
                    .HasColumnType("char(64)")
                    .HasColumnName("mb_sha2sig")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MbStatus).HasColumnName("mb_status");

                entity.Property(e => e.MbTransactionId)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("mb_transaction_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MbresponseRaw)
                    .HasColumnType("varchar(512)")
                    .HasColumnName("mbresponse_raw")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("char(64)")
                    .HasColumnName("order_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentCurrency)
                    .HasColumnType("char(3)")
                    .HasColumnName("payment_currency")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("payment_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentOrderTotal)
                    .HasPrecision(15, 5)
                    .HasColumnName("payment_order_total");

                entity.Property(e => e.TaxId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("tax_id");

                entity.Property(e => e.UserSession)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_session")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");
            });

            modelBuilder.Entity<JosVirtuemartPaymentPlgPaypal>(entity =>
            {
                entity.ToTable("jos_virtuemart_payment_plg_paypal");

                entity.HasComment("Payment Paypal Table");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CostPerTransaction)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_per_transaction");

                entity.Property(e => e.CostPercentTotal)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_percent_total");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.EmailCurrency)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("email_currency");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("char(64)")
                    .HasColumnName("order_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentCurrency)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("payment_currency");

                entity.Property(e => e.PaymentName)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("payment_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentOrderTotal)
                    .HasPrecision(15, 5)
                    .HasColumnName("payment_order_total");

                entity.Property(e => e.PaypalCustom)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("paypal_custom")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalFullresponse)
                    .HasColumnType("text")
                    .HasColumnName("paypal_fullresponse")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalMethod)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("paypal_method")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseBusiness)
                    .HasColumnType("char(128)")
                    .HasColumnName("paypal_response_business")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseCaseCreationDate)
                    .HasColumnType("char(32)")
                    .HasColumnName("paypal_response_case_creation_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseCaseId)
                    .HasColumnType("char(32)")
                    .HasColumnName("paypal_response_case_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseCaseType)
                    .HasColumnType("char(32)")
                    .HasColumnName("paypal_response_case_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseFirstName)
                    .HasColumnType("char(64)")
                    .HasColumnName("paypal_response_first_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseInvoice)
                    .HasColumnType("char(32)")
                    .HasColumnName("paypal_response_invoice")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseLastName)
                    .HasColumnType("char(64)")
                    .HasColumnName("paypal_response_last_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseMcCurrency)
                    .HasColumnType("char(10)")
                    .HasColumnName("paypal_response_mc_currency")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseMcFee)
                    .HasPrecision(10, 2)
                    .HasColumnName("paypal_response_mc_fee");

                entity.Property(e => e.PaypalResponseMcGross)
                    .HasPrecision(10, 2)
                    .HasColumnName("paypal_response_mc_gross");

                entity.Property(e => e.PaypalResponseParentTxnId)
                    .HasColumnType("char(32)")
                    .HasColumnName("paypal_response_parent_txn_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponsePayerEmail)
                    .HasColumnType("char(128)")
                    .HasColumnName("paypal_response_payer_email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponsePayerId)
                    .HasColumnType("char(13)")
                    .HasColumnName("paypal_response_payer_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponsePaymentDate)
                    .HasColumnType("char(28)")
                    .HasColumnName("paypal_response_payment_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponsePaymentStatus)
                    .HasColumnType("char(50)")
                    .HasColumnName("paypal_response_payment_status")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponsePendingReason)
                    .HasColumnType("char(50)")
                    .HasColumnName("paypal_response_pending_reason")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseProtectionEligibility)
                    .HasColumnType("char(128)")
                    .HasColumnName("paypal_response_protection_eligibility")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseReasonCode)
                    .HasColumnType("char(32)")
                    .HasColumnName("paypal_response_reason_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseReceiverEmail)
                    .HasColumnType("char(128)")
                    .HasColumnName("paypal_response_receiver_email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseResidenceCountry)
                    .HasColumnType("char(2)")
                    .HasColumnName("paypal_response_residence_country")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseTax)
                    .HasPrecision(10, 2)
                    .HasColumnName("paypal_response_tax");

                entity.Property(e => e.PaypalResponseTransactionSubject)
                    .HasColumnType("char(128)")
                    .HasColumnName("paypal_response_transaction_subject")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseTxnId)
                    .HasColumnType("char(32)")
                    .HasColumnName("paypal_response_txn_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalResponseTxnType)
                    .HasColumnType("char(32)")
                    .HasColumnName("paypal_response_txn_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaypalresponseRaw)
                    .HasColumnType("varchar(512)")
                    .HasColumnName("paypalresponse_raw")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("tax_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");
            });

            modelBuilder.Entity<JosVirtuemartPaymentPlgPayzen>(entity =>
            {
                entity.ToTable("jos_virtuemart_payment_plg_payzen");

                entity.HasComment("Payment payzen Table");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CostPerTransaction)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_per_transaction");

                entity.Property(e => e.CostPercentTotal)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_percent_total");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("char(64)")
                    .HasColumnName("order_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentCurrency)
                    .HasColumnType("char(3)")
                    .HasColumnName("payment_currency")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("payment_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentOrderTotal)
                    .HasPrecision(15, 5)
                    .HasColumnName("payment_order_total");

                entity.Property(e => e.PayzenCustom)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("payzen_custom")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponseAuthNumber)
                    .HasColumnType("char(10)")
                    .HasColumnName("payzen_response_auth_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponseCardNumber)
                    .HasColumnType("char(50)")
                    .HasColumnName("payzen_response_card_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponseExpiryMonth)
                    .HasColumnType("char(2)")
                    .HasColumnName("payzen_response_expiry_month")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponseExpiryYear)
                    .HasColumnType("char(4)")
                    .HasColumnName("payzen_response_expiry_year")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponsePaymentAmount)
                    .HasColumnType("char(15)")
                    .HasColumnName("payzen_response_payment_amount")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponsePaymentCurrency)
                    .HasColumnType("char(3)")
                    .HasColumnName("payzen_response_payment_currency")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponsePaymentDate)
                    .HasColumnType("char(20)")
                    .HasColumnName("payzen_response_payment_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponsePaymentMean)
                    .HasColumnType("char(255)")
                    .HasColumnName("payzen_response_payment_mean")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponsePaymentMessage)
                    .HasColumnType("char(255)")
                    .HasColumnName("payzen_response_payment_message")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponsePaymentStatus)
                    .HasColumnType("char(3)")
                    .HasColumnName("payzen_response_payment_status")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PayzenResponseTransId)
                    .HasColumnType("char(6)")
                    .HasColumnName("payzen_response_trans_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("tax_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");
            });

            modelBuilder.Entity<JosVirtuemartPaymentPlgStandard>(entity =>
            {
                entity.ToTable("jos_virtuemart_payment_plg_standard");

                entity.HasComment("Payment Standard Table");

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CostMinTransaction)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_min_transaction");

                entity.Property(e => e.CostPerTransaction)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_per_transaction");

                entity.Property(e => e.CostPercentTotal)
                    .HasPrecision(10, 2)
                    .HasColumnName("cost_percent_total");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.EmailCurrency)
                    .HasColumnType("char(3)")
                    .HasColumnName("email_currency")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("char(64)")
                    .HasColumnName("order_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentCurrency)
                    .HasColumnType("char(3)")
                    .HasColumnName("payment_currency")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("payment_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentOrderTotal)
                    .HasPrecision(15, 5)
                    .HasColumnName("payment_order_total");

                entity.Property(e => e.TaxId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("tax_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethod>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods");

                entity.HasComment("The payment methods of your store");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => new { e.PaymentElement, e.VirtuemartVendorId }, "payment_element");

                entity.HasIndex(e => e.PaymentJpluginId, "payment_jplugin_id");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("currency_id");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.PaymentElement)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("payment_element")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("payment_jplugin_id");

                entity.Property(e => e.PaymentParams)
                    .HasColumnType("text")
                    .HasColumnName("payment_params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared)
                    .HasColumnName("shared")
                    .HasComment("valide for all vendors?");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethodShoppergroup>(entity =>
            {
                entity.ToTable("jos_virtuemart_paymentmethod_shoppergroups");

                entity.HasComment("xref table for paymentmethods to shoppergroup");

                entity.HasIndex(e => new { e.VirtuemartPaymentmethodId, e.VirtuemartShoppergroupId }, "virtuemart_paymentmethod_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethodsArAa>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods_ar_aa");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.PaymentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("payment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("payment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethodsDeDe>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods_de_de");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.PaymentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("payment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("payment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethodsEnGb>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods_en_gb");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.PaymentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("payment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("payment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethodsEsE>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods_es_es");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.PaymentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(20000)")
                    .HasColumnName("payment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasColumnType("char(180)")
                    .HasColumnName("payment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("char(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethodsFrFr>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods_fr_fr");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.PaymentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("payment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("payment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethodsItIt>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods_it_it");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.PaymentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("payment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("payment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethodsRuRu>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods_ru_ru");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.PaymentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("payment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("payment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartPaymentmethodsSqAl>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods_sq_al");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.PaymentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("payment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("payment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartPermgroup>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPermgroupId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_permgroups");

                entity.HasComment("Holds all the user groups");

                entity.HasIndex(e => e.VirtuemartVendorId, "i_virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartPermgroupId)
                    .HasColumnType("tinyint(1) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("virtuemart_permgroup_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.GroupLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("group_level");

                entity.Property(e => e.GroupName)
                    .HasColumnType("char(128)")
                    .HasColumnName("group_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(2)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared).HasColumnName("shared");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartProduct>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_products");

                entity.HasComment("All products are stored here.");

                entity.HasIndex(e => e.CreatedOn, "created_on");

                entity.HasIndex(e => e.ModifiedOn, "modified_on");

                entity.HasIndex(e => e.Pordering, "pordering");

                entity.HasIndex(e => e.ProductDiscontinued, "product_discontinued");

                entity.HasIndex(e => e.ProductInStock, "product_in_stock");

                entity.HasIndex(e => e.ProductOrdered, "product_ordered");

                entity.HasIndex(e => e.ProductParentId, "product_parent_id");

                entity.HasIndex(e => e.ProductSku, "product_sku");

                entity.HasIndex(e => e.ProductSpecial, "product_special");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.HasCategories).HasColumnName("has_categories");

                entity.Property(e => e.HasManufacturers).HasColumnName("has_manufacturers");

                entity.Property(e => e.HasMedias).HasColumnName("has_medias");

                entity.Property(e => e.HasPrices).HasColumnName("has_prices");

                entity.Property(e => e.HasShoppergroups).HasColumnName("has_shoppergroups");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.Intnotes)
                    .HasColumnType("text")
                    .HasColumnName("intnotes")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Layout)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("layout")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LowStockNotification)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("low_stock_notification");

                entity.Property(e => e.Metaauthor)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metaauthor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metarobot)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metarobot")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Pordering)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("pordering");

                entity.Property(e => e.ProductAvailability)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("product_availability")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductAvailableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("product_available_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ProductCanonCategoryId)
                    .HasColumnType("int(1)")
                    .HasColumnName("product_canon_category_id");

                entity.Property(e => e.ProductDiscontinued).HasColumnName("product_discontinued");

                entity.Property(e => e.ProductGtin)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("product_gtin")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductHeight)
                    .HasPrecision(10, 4)
                    .HasColumnName("product_height");

                entity.Property(e => e.ProductInStock)
                    .HasColumnType("int(1)")
                    .HasColumnName("product_in_stock");

                entity.Property(e => e.ProductLength)
                    .HasPrecision(10, 4)
                    .HasColumnName("product_length");

                entity.Property(e => e.ProductLwhUom)
                    .HasColumnType("varchar(7)")
                    .HasColumnName("product_lwh_uom")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductMpn)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("product_mpn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductOrdered)
                    .HasColumnType("int(1)")
                    .HasColumnName("product_ordered");

                entity.Property(e => e.ProductPackaging)
                    .HasColumnType("decimal(8,4) unsigned")
                    .HasColumnName("product_packaging");

                entity.Property(e => e.ProductParams)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("product_params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductParentId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("product_parent_id");

                entity.Property(e => e.ProductSales)
                    .HasColumnType("int(1)")
                    .HasColumnName("product_sales");

                entity.Property(e => e.ProductSku)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("product_sku")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSpecial).HasColumnName("product_special");

                entity.Property(e => e.ProductStockhandle)
                    .IsRequired()
                    .HasColumnType("varchar(24)")
                    .HasColumnName("product_stockhandle")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductUnit)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("product_unit")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductUrl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("product_url")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductWeight)
                    .HasPrecision(10, 4)
                    .HasColumnName("product_weight");

                entity.Property(e => e.ProductWeightUom)
                    .HasColumnType("varchar(7)")
                    .HasColumnName("product_weight_uom")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductWidth)
                    .HasPrecision(10, 4)
                    .HasColumnName("product_width");

                entity.Property(e => e.Published).HasColumnName("published");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartProductCategory>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_categories");

                entity.HasComment("Maps Products to Categories");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.VirtuemartCategoryId }, "virtuemart_product_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductCustomPlgIstraxxDownload>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_custom_plg_istraxx_download");

                entity.HasComment("InnoDB");

                entity.HasIndex(e => e.VirtuemartOrderItemId, "virtuemart_order_item_id");

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ClientIp)
                    .HasColumnType("char(42)")
                    .HasColumnName("client_ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Errorcode).HasColumnName("errorcode");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Message)
                    .HasColumnType("char(255)")
                    .HasColumnName("message")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.VirtuemartOrderItemId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_item_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductCustomPlgIstraxxDownloadSimple>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_custom_plg_istraxx_download_simple");

                entity.HasComment("istraxx_download_simple");

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ClientIp)
                    .HasColumnType("char(42)")
                    .HasColumnName("client_ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Errorcode).HasColumnName("errorcode");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Message)
                    .HasColumnType("char(255)")
                    .HasColumnName("message")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.VirtuemartOrderItemId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_item_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductCustomPlgParamRef>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_custom_plg_param_ref");

                entity.HasComment("customvalues reference");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Intval).HasColumnName("intval");

                entity.Property(e => e.Val)
                    .HasColumnType("int(11)")
                    .HasColumnName("val");

                entity.Property(e => e.VirtuemartCustomId)
                    .HasColumnType("int(11)")
                    .HasColumnName("virtuemart_custom_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductCustomPlgParamValue>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_custom_plg_param_values");

                entity.HasComment("customvalues");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(5)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .HasColumnType("int(1)")
                    .HasColumnName("published");

                entity.Property(e => e.Status)
                    .HasColumnType("int(1)")
                    .HasColumnName("status");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartCustomId)
                    .HasColumnType("int(11)")
                    .HasColumnName("virtuemart_custom_id");
            });

            modelBuilder.Entity<JosVirtuemartProductCustomPlgVm2tag>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_custom_plg_vm2tags");

                entity.HasComment("Product Tags Table");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.VirtuemartCustomId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("virtuemart_custom_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductCustomfield>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCustomfieldId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_product_customfields");

                entity.HasComment("custom fields");

                entity.HasIndex(e => e.CustomfieldValue, "customfield_value")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 50 });

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => new { e.VirtuemartCustomId, e.VirtuemartProductId, e.CustomfieldValue }, "unique_cust_prd_value")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 50 });

                entity.HasIndex(e => new { e.VirtuemartCustomfieldId, e.VirtuemartProductId, e.VirtuemartCustomId, e.CustomfieldValue }, "unique_custf_prd_value")
                    .IsUnique()
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 50 });

                entity.HasIndex(e => e.VirtuemartCustomId, "virtuemart_custom_id");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.Ordering }, "virtuemart_product_id");

                entity.Property(e => e.VirtuemartCustomfieldId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_customfield_id")
                    .HasComment("FIELD ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CustomfieldParams)
                    .HasColumnType("text")
                    .HasColumnName("customfield_params")
                    .HasComment("PARAM FOR PLUGINS")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomfieldPrice)
                    .HasPrecision(15, 6)
                    .HasColumnName("customfield_price")
                    .HasComment("price");

                entity.Property(e => e.CustomfieldValue)
                    .HasColumnType("varchar(2500)")
                    .HasColumnName("customfield_value")
                    .HasComment("FIELD VALUE")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Disabler)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("disabler");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Noninheritable)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("noninheritable");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Override)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("override");

                entity.Property(e => e.ProductGtin)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("product_gtin")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductMpn)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("product_mpn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSku)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("product_sku")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartCustomId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_custom_id")
                    .HasDefaultValueSql("'1'")
                    .HasComment("CUSTOM GROUP ID");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductManufacturer>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_manufacturers");

                entity.HasComment("Maps a product to a manufacturer");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.VirtuemartManufacturerId }, "virtuemart_product_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductMedia>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_medias");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.Ordering }, "ordering");

                entity.HasIndex(e => e.VirtuemartMediaId, "virtuemart_media_id");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.VirtuemartMediaId }, "virtuemart_product_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.VirtuemartMediaId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_media_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductPrice>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductPriceId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_product_prices");

                entity.HasComment("Holds price records for a product");

                entity.HasIndex(e => e.PriceQuantityEnd, "price_quantity_end");

                entity.HasIndex(e => e.PriceQuantityStart, "price_quantity_start");

                entity.HasIndex(e => e.ProductPrice, "product_price");

                entity.HasIndex(e => e.ProductPricePublishDown, "product_price_publish_down");

                entity.HasIndex(e => e.ProductPricePublishUp, "product_price_publish_up");

                entity.HasIndex(e => e.VirtuemartProductId, "virtuemart_product_id");

                entity.HasIndex(e => e.VirtuemartShoppergroupId, "virtuemart_shoppergroup_id");

                entity.Property(e => e.VirtuemartProductPriceId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_price_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Override).HasColumnName("override");

                entity.Property(e => e.PriceQuantityEnd)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("price_quantity_end");

                entity.Property(e => e.PriceQuantityStart)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("price_quantity_start");

                entity.Property(e => e.ProductCurrency)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("product_currency");

                entity.Property(e => e.ProductDiscountId)
                    .HasColumnType("int(1)")
                    .HasColumnName("product_discount_id");

                entity.Property(e => e.ProductOverridePrice)
                    .HasPrecision(15, 5)
                    .HasColumnName("product_override_price");

                entity.Property(e => e.ProductPrice)
                    .HasPrecision(15, 6)
                    .HasColumnName("product_price");

                entity.Property(e => e.ProductPricePublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("product_price_publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ProductPricePublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("product_price_publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ProductTaxId)
                    .HasColumnType("int(1)")
                    .HasColumnName("product_tax_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");
            });

            modelBuilder.Entity<JosVirtuemartProductRelation>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_relations");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.RelatedProducts }, "i_virtuemart_product_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.RelatedProducts)
                    .HasColumnType("int(11)")
                    .HasColumnName("related_products");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductShoppergroup>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_shoppergroups");

                entity.HasComment("Maps Products to Categories");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.VirtuemartShoppergroupId }, "virtuemart_product_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");
            });

            modelBuilder.Entity<JosVirtuemartProductsArAa>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_products_ar_aa");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("product_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("product_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSDesc)
                    .IsRequired()
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("product_s_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartProductsEnGb>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_products_en_gb");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("product_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("product_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSDesc)
                    .IsRequired()
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("product_s_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartProductsEsE>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_products_es_es");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductDesc)
                    .IsRequired()
                    .HasColumnType("varchar(18400)")
                    .HasColumnName("product_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("char(180)")
                    .HasColumnName("product_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSDesc)
                    .IsRequired()
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("product_s_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("char(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartProductsFrFr>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_products_fr_fr");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("product_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("product_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSDesc)
                    .IsRequired()
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("product_s_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartProductsItIt>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_products_it_it");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("product_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("product_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSDesc)
                    .IsRequired()
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("product_s_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartProductsRuRu>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_products_ru_ru");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("product_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("product_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSDesc)
                    .IsRequired()
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("product_s_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartProductsSqAl>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_products_sq_al");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("product_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("product_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSDesc)
                    .IsRequired()
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("product_s_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartRating>(entity =>
            {
                entity.HasKey(e => e.VirtuemartRatingId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_ratings");

                entity.HasComment("Stores all ratings for a product");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.VirtuemartRatingId }, "virtuemart_product_id")
                    .IsUnique();

                entity.Property(e => e.VirtuemartRatingId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_rating_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Rates)
                    .HasColumnType("int(1)")
                    .HasColumnName("rates");

                entity.Property(e => e.Rating)
                    .HasPrecision(10, 1)
                    .HasColumnName("rating");

                entity.Property(e => e.Ratingcount)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("ratingcount");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartRatingReview>(entity =>
            {
                entity.HasKey(e => e.VirtuemartRatingReviewId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_rating_reviews");

                entity.HasIndex(e => e.CreatedBy, "created_by");

                entity.HasIndex(e => e.CreatedOn, "created_on");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.CreatedBy }, "virtuemart_product_id");

                entity.HasIndex(e => e.VirtuemartRatingVoteId, "virtuemart_rating_vote_id");

                entity.Property(e => e.VirtuemartRatingReviewId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_rating_review_id");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(15359)")
                    .HasColumnName("comment")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Customer)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("customer")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lastip)
                    .IsRequired()
                    .HasColumnType("char(50)")
                    .HasColumnName("lastip")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ReviewEditable)
                    .IsRequired()
                    .HasColumnName("review_editable")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ReviewLanguage)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("review_language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReviewOk).HasColumnName("review_ok");

                entity.Property(e => e.ReviewRates)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("review_rates");

                entity.Property(e => e.ReviewRating)
                    .HasPrecision(10, 2)
                    .HasColumnName("review_rating");

                entity.Property(e => e.ReviewRatingcount)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("review_ratingcount");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.VirtuemartRatingVoteId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_rating_vote_id");
            });

            modelBuilder.Entity<JosVirtuemartRatingVote>(entity =>
            {
                entity.HasKey(e => e.VirtuemartRatingVoteId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_rating_votes");

                entity.HasComment("Stores all ratings for a product");

                entity.HasIndex(e => e.CreatedBy, "created_by");

                entity.HasIndex(e => e.CreatedOn, "created_on");

                entity.HasIndex(e => new { e.VirtuemartProductId, e.CreatedBy }, "virtuemart_product_id");

                entity.Property(e => e.VirtuemartRatingVoteId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_rating_vote_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Lastip)
                    .IsRequired()
                    .HasColumnType("char(50)")
                    .HasColumnName("lastip")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.Vote)
                    .HasColumnType("int(1)")
                    .HasColumnName("vote");
            });

            modelBuilder.Entity<JosVirtuemartShipmentPlgWeightCountry>(entity =>
            {
                entity.ToTable("jos_virtuemart_shipment_plg_weight_countries");

                entity.HasComment("Shipment Weight Countries Table");

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("char(32)")
                    .HasColumnName("order_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderWeight)
                    .HasPrecision(10, 4)
                    .HasColumnName("order_weight");

                entity.Property(e => e.ShipmentCost)
                    .HasPrecision(10, 2)
                    .HasColumnName("shipment_cost");

                entity.Property(e => e.ShipmentName)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("shipment_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentPackageFee)
                    .HasPrecision(10, 2)
                    .HasColumnName("shipment_package_fee");

                entity.Property(e => e.ShipmentWeightUnit)
                    .HasColumnType("char(3)")
                    .HasColumnName("shipment_weight_unit")
                    .HasDefaultValueSql("'KG'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("tax_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_shipmentmethod_id");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethod>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShipmentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shipmentmethods");

                entity.HasComment("Shipment created from the shipment plugins");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => new { e.ShipmentElement, e.VirtuemartVendorId }, "shipment_element");

                entity.HasIndex(e => e.ShipmentJpluginId, "shipment_jplugin_id");

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CurrencyId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("currency_id");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared).HasColumnName("shared");

                entity.Property(e => e.ShipmentElement)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("shipment_element")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("shipment_jplugin_id");

                entity.Property(e => e.ShipmentParams)
                    .HasColumnType("text")
                    .HasColumnName("shipment_params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethodShoppergroup>(entity =>
            {
                entity.ToTable("jos_virtuemart_shipmentmethod_shoppergroups");

                entity.HasComment("xref table for shipment to shoppergroup");

                entity.HasIndex(e => new { e.VirtuemartShipmentmethodId, e.VirtuemartShoppergroupId }, "virtuemart_shipmentmethod_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethodsArAa>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShipmentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shipmentmethods_ar_aa");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.ShipmentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("shipment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("shipment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethodsDeDe>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShipmentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shipmentmethods_de_de");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.ShipmentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("shipment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("shipment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethodsEnGb>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShipmentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shipmentmethods_en_gb");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.ShipmentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("shipment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("shipment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethodsEsE>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShipmentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shipmentmethods_es_es");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.ShipmentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(20000)")
                    .HasColumnName("shipment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentName)
                    .IsRequired()
                    .HasColumnType("char(180)")
                    .HasColumnName("shipment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("char(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethodsFrFr>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShipmentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shipmentmethods_fr_fr");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.ShipmentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("shipment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("shipment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethodsItIt>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShipmentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shipmentmethods_it_it");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.ShipmentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("shipment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("shipment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethodsRuRu>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShipmentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shipmentmethods_ru_ru");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.ShipmentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("shipment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("shipment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartShipmentmethodsSqAl>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShipmentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shipmentmethods_sq_al");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.ShipmentDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("shipment_desc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("shipment_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartShoppergroup>(entity =>
            {
                entity.HasKey(e => e.VirtuemartShoppergroupId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_shoppergroups");

                entity.HasComment("Shopper Groups that users can be assigned to");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Shared, "shared");

                entity.HasIndex(e => e.ShopperGroupName, "shopper_group_name");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CustomPriceDisplay).HasColumnName("custom_price_display");

                entity.Property(e => e.Default).HasColumnName("default");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.PriceDisplay)
                    .IsRequired()
                    .HasColumnType("blob")
                    .HasColumnName("price_display");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SgrpAdditional).HasColumnName("sgrp_additional");

                entity.Property(e => e.Shared).HasColumnName("shared");

                entity.Property(e => e.ShopperGroupDesc)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("shopper_group_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShopperGroupName)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("shopper_group_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartState>(entity =>
            {
                entity.HasKey(e => e.VirtuemartStateId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_states");

                entity.HasComment("States that are assigned to a country");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Shared, "shared");

                entity.HasIndex(e => new { e.VirtuemartVendorId, e.VirtuemartCountryId, e.State2Code }, "state_2_code")
                    .IsUnique();

                entity.HasIndex(e => new { e.VirtuemartVendorId, e.VirtuemartCountryId, e.State3Code }, "state_3_code")
                    .IsUnique();

                entity.HasIndex(e => e.VirtuemartCountryId, "virtuemart_country_id");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartStateId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_state_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared)
                    .IsRequired()
                    .HasColumnName("shared")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.State2Code)
                    .HasColumnType("char(2)")
                    .HasColumnName("state_2_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.State3Code)
                    .HasColumnType("char(3)")
                    .HasColumnName("state_3_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StateName)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("state_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartCountryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_country_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartWorldzoneId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_worldzone_id");
            });

            modelBuilder.Entity<JosVirtuemartUserfield>(entity =>
            {
                entity.HasKey(e => e.VirtuemartUserfieldId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_userfields");

                entity.HasComment("Holds the fields for the user information");

                entity.HasIndex(e => e.Account, "account");

                entity.HasIndex(e => e.Cart, "cart");

                entity.HasIndex(e => e.Name, "name")
                    .IsUnique();

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Shared, "shared");

                entity.HasIndex(e => e.Shipment, "shipment");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartUserfieldId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_userfield_id");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasColumnName("account")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Calculated).HasColumnName("calculated");

                entity.Property(e => e.Cart).HasColumnName("cart");

                entity.Property(e => e.Cols)
                    .HasColumnType("int(1)")
                    .HasColumnName("cols");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Default)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("default")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Maxlength)
                    .HasColumnType("int(1)")
                    .HasColumnName("maxlength");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Placeholder)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("placeholder")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Readonly).HasColumnName("readonly");

                entity.Property(e => e.Registration).HasColumnName("registration");

                entity.Property(e => e.Required)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("required");

                entity.Property(e => e.Rows)
                    .HasColumnType("int(1)")
                    .HasColumnName("rows");

                entity.Property(e => e.Shared).HasColumnName("shared");

                entity.Property(e => e.Shipment).HasColumnName("shipment");

                entity.Property(e => e.Size)
                    .HasColumnType("int(1)")
                    .HasColumnName("size");

                entity.Property(e => e.Sys)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("sys");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(70)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserfieldJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("userfield_jplugin_id");

                entity.Property(e => e.UserfieldParams)
                    .HasColumnType("text")
                    .HasColumnName("userfield_params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartUserfieldValue>(entity =>
            {
                entity.HasKey(e => e.VirtuemartUserfieldValueId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_userfield_values");

                entity.HasComment("Holds the different values for dropdown and radio lists");

                entity.HasIndex(e => e.VirtuemartUserfieldId, "virtuemart_userfield_id");

                entity.Property(e => e.VirtuemartUserfieldValueId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_userfield_value_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Fieldtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fieldtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fieldvalue)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fieldvalue")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Sys)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("sys");

                entity.Property(e => e.VirtuemartUserfieldId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_userfield_id");
            });

            modelBuilder.Entity<JosVirtuemartUserinfo>(entity =>
            {
                entity.HasKey(e => e.VirtuemartUserinfoId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_userinfos");

                entity.HasComment("Customer Information, BT = BillTo and ST = ShipTo");

                entity.HasIndex(e => e.AddressType, "address_type");

                entity.HasIndex(e => e.AddressTypeName, "address_type_name");

                entity.HasIndex(e => new { e.VirtuemartUserinfoId, e.VirtuemartUserId }, "i_virtuemart_user_id");

                entity.HasIndex(e => new { e.VirtuemartUserId, e.AddressType }, "virtuemart_user_id");

                entity.Property(e => e.VirtuemartUserinfoId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_userinfo_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnType("varchar(96)")
                    .HasColumnName("address_1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("address_2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressType)
                    .IsRequired()
                    .HasColumnType("char(2)")
                    .HasColumnName("address_type")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("address_type_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Agreed).HasColumnName("agreed");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("varchar(96)")
                    .HasColumnName("city")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("company")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CustomerNote)
                    .IsRequired()
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("customer_note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fax)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fax")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnType("varchar(96)")
                    .HasColumnName("first_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("last_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.MiddleName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("middle_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Phone1)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("phone_1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("phone_2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tos).HasColumnName("tos");

                entity.Property(e => e.VirtuemartCountryId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_country_id");

                entity.Property(e => e.VirtuemartStateId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_state_id");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("zip")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVendor>(entity =>
            {
                entity.HasKey(e => e.VirtuemartVendorId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vendors");

                entity.HasComment("Vendors manage their products in your store");

                entity.HasIndex(e => e.VendorCurrency, "vendor_currency");

                entity.HasIndex(e => e.VendorName, "vendor_name");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Metaauthor)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("metaauthor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metarobot)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("metarobot")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.VendorAcceptedCurrencies)
                    .IsRequired()
                    .HasColumnType("varchar(1536)")
                    .HasColumnName("vendor_accepted_currencies")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorCurrency)
                    .HasColumnType("int(1)")
                    .HasColumnName("vendor_currency");

                entity.Property(e => e.VendorName)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("vendor_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorParams)
                    .IsRequired()
                    .HasColumnType("varchar(14335)")
                    .HasColumnName("vendor_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVendorMedia>(entity =>
            {
                entity.ToTable("jos_virtuemart_vendor_medias");

                entity.HasIndex(e => new { e.VirtuemartVendorId, e.VirtuemartMediaId }, "virtuemart_vendor_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.VirtuemartMediaId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_media_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id");
            });

            modelBuilder.Entity<JosVirtuemartVendorUser>(entity =>
            {
                entity.ToTable("jos_virtuemart_vendor_users");

                entity.HasIndex(e => new { e.VirtuemartVendorUserId, e.VirtuemartUserId }, "virtuemart_vendor_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");

                entity.Property(e => e.VirtuemartVendorUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_user_id");
            });

            modelBuilder.Entity<JosVirtuemartVendorsArAa>(entity =>
            {
                entity.HasKey(e => e.VirtuemartVendorId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vendors_ar_aa");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLegalInfo)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_legal_info")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterCss)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_letter_css")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterFooterHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_footer_html")
                    .HasDefaultValueSql("'<p>{vm:vendorlegalinfo}<br />Page {vm:pagenum}/{vm:pagecount}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterHeaderHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_header_html")
                    .HasDefaultValueSql("'<h1>{vm:vendorname}</h1><p>{vm:vendoraddress}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailCss)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("varchar(26)")
                    .HasColumnName("vendor_phone")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_store_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVendorsDeDe>(entity =>
            {
                entity.HasKey(e => e.VirtuemartVendorId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vendors_de_de");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLegalInfo)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_legal_info")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterCss)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_letter_css")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterFooterHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_footer_html")
                    .HasDefaultValueSql("'<p>{vm:vendorlegalinfo}<br />Page {vm:pagenum}/{vm:pagecount}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterHeaderHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_header_html")
                    .HasDefaultValueSql("'<h1>{vm:vendorname}</h1><p>{vm:vendoraddress}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailCss)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("varchar(26)")
                    .HasColumnName("vendor_phone")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_store_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVendorsEnGb>(entity =>
            {
                entity.HasKey(e => e.VirtuemartVendorId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vendors_en_gb");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLegalInfo)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_legal_info")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterCss)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_letter_css")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterFooterHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_footer_html")
                    .HasDefaultValueSql("'<p>{vm:vendorlegalinfo}<br />Page {vm:pagenum}/{vm:pagecount}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterHeaderHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_header_html")
                    .HasDefaultValueSql("'<h1>{vm:vendorname}</h1><p>{vm:vendoraddress}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailCss)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("varchar(26)")
                    .HasColumnName("vendor_phone")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_store_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVendorsFrFr>(entity =>
            {
                entity.HasKey(e => e.VirtuemartVendorId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vendors_fr_fr");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLegalInfo)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_legal_info")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterCss)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_letter_css")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterFooterHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_footer_html")
                    .HasDefaultValueSql("'<p>{vm:vendorlegalinfo}<br />Page {vm:pagenum}/{vm:pagecount}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterHeaderHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_header_html")
                    .HasDefaultValueSql("'<h1>{vm:vendorname}</h1><p>{vm:vendoraddress}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailCss)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("varchar(26)")
                    .HasColumnName("vendor_phone")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_store_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVendorsItIt>(entity =>
            {
                entity.HasKey(e => e.VirtuemartVendorId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vendors_it_it");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLegalInfo)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_legal_info")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterCss)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_letter_css")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterFooterHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_footer_html")
                    .HasDefaultValueSql("'<p>{vm:vendorlegalinfo}<br />Page {vm:pagenum}/{vm:pagecount}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterHeaderHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_header_html")
                    .HasDefaultValueSql("'<h1>{vm:vendorname}</h1><p>{vm:vendoraddress}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailCss)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("varchar(26)")
                    .HasColumnName("vendor_phone")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_store_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVendorsRuRu>(entity =>
            {
                entity.HasKey(e => e.VirtuemartVendorId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vendors_ru_ru");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLegalInfo)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_legal_info")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterCss)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_letter_css")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterFooterHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_footer_html")
                    .HasDefaultValueSql("'<p>{vm:vendorlegalinfo}<br />Page {vm:pagenum}/{vm:pagecount}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterHeaderHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_header_html")
                    .HasDefaultValueSql("'<h1>{vm:vendorname}</h1><p>{vm:vendoraddress}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailCss)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("varchar(26)")
                    .HasColumnName("vendor_phone")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_store_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVendorsSqAl>(entity =>
            {
                entity.HasKey(e => e.VirtuemartVendorId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vendors_sq_al");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.Customtitle)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("customtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metadesc")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("metakey")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnType("varchar(192)")
                    .HasColumnName("slug")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_invoice_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLegalInfo)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_legal_info")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterCss)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_letter_css")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterFooterHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_footer_html")
                    .HasDefaultValueSql("'<p>{vm:vendorlegalinfo}<br />Page {vm:pagenum}/{vm:pagecount}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorLetterHeaderHtml)
                    .IsRequired()
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("vendor_letter_header_html")
                    .HasDefaultValueSql("'<h1>{vm:vendorname}</h1><p>{vm:vendoraddress}</p>'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailCss)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("varchar(26)")
                    .HasColumnName("vendor_phone")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreDesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_store_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorStoreName)
                    .IsRequired()
                    .HasColumnType("varchar(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("vendor_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVmuser>(entity =>
            {
                entity.HasKey(e => e.VirtuemartUserId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vmusers");

                entity.HasComment("Holds the unique user data");

                entity.HasIndex(e => new { e.VirtuemartUserId, e.VirtuemartVendorId }, "u_virtuemart_user_id")
                    .IsUnique();

                entity.HasIndex(e => e.UserIsVendor, "user_is_vendor");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");

                entity.Property(e => e.Agreed).HasColumnName("agreed");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CustomerNumber)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("customer_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.UserIsVendor).HasColumnName("user_is_vendor");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id");
            });

            modelBuilder.Entity<JosVirtuemartVmuserShoppergroup>(entity =>
            {
                entity.ToTable("jos_virtuemart_vmuser_shoppergroups");

                entity.HasComment("xref table for users to shopper group");

                entity.HasIndex(e => new { e.VirtuemartUserId, e.VirtuemartShoppergroupId }, "virtuemart_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");
            });

            modelBuilder.Entity<JosVirtuemartWaitinguser>(entity =>
            {
                entity.HasKey(e => e.VirtuemartWaitinguserId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_waitingusers");

                entity.HasComment("Stores notifications, users waiting f. products out of stock");

                entity.HasIndex(e => e.NotifyEmail, "notify_email");

                entity.HasIndex(e => e.VirtuemartProductId, "virtuemart_product_id");

                entity.Property(e => e.VirtuemartWaitinguserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_waitinguser_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Notified).HasColumnName("notified");

                entity.Property(e => e.NotifyDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("notify_date")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.NotifyEmail)
                    .IsRequired()
                    .HasColumnType("varchar(150)")
                    .HasColumnName("notify_email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");
            });

            modelBuilder.Entity<JosVirtuemartWorldzone>(entity =>
            {
                entity.HasKey(e => e.VirtuemartWorldzoneId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_worldzones");

                entity.HasComment("The Zones managed by the Zone Shipment Module");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartWorldzoneId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_worldzone_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.LockedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("locked_by");

                entity.Property(e => e.LockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("locked_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(1)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared).HasColumnName("shared");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.ZoneCost)
                    .HasPrecision(10, 2)
                    .HasColumnName("zone_cost");

                entity.Property(e => e.ZoneDescription)
                    .HasColumnType("varchar(14335)")
                    .HasColumnName("zone_description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZoneLimit)
                    .HasPrecision(10, 2)
                    .HasColumnName("zone_limit");

                entity.Property(e => e.ZoneName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("zone_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZoneTaxRate)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("zone_tax_rate");
            });

            modelBuilder.Entity<JosWeblink>(entity =>
            {
                entity.ToTable("jos_weblinks");

                entity.HasIndex(e => e.Access, "idx_access");

                entity.HasIndex(e => e.Catid, "idx_catid");

                entity.HasIndex(e => e.CheckedOut, "idx_checkout");

                entity.HasIndex(e => e.CreatedBy, "idx_createdby");

                entity.HasIndex(e => new { e.Featured, e.Catid }, "idx_featured_catid");

                entity.HasIndex(e => e.Language, "idx_language");

                entity.HasIndex(e => e.State, "idx_state");

                entity.HasIndex(e => e.Xreference, "idx_xreference");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Access)
                    .HasColumnType("int(11)")
                    .HasColumnName("access")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasColumnType("varchar(400)")
                    .HasColumnName("alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_bin");

                entity.Property(e => e.Catid)
                    .HasColumnType("int(11)")
                    .HasColumnName("catid");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11)")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedByAlias)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("created_by_alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Featured)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("featured")
                    .HasComment("Set if link is featured.");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(11)")
                    .HasColumnName("hits");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("images")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metadata")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metadesc")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("metakey")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasColumnName("modified")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modified_by");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("params")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PublishDown)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_down")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.PublishUp)
                    .HasColumnType("datetime")
                    .HasColumnName("publish_up")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Version)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Xreference)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("xreference")
                    .HasComment("A reference to enable linkages to external data sets.")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_unicode_ci");
            });

            modelBuilder.Entity<JosWfProfile>(entity =>
            {
                entity.ToTable("jos_wf_profiles");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Area)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("area");

                entity.Property(e => e.CheckedOut)
                    .HasColumnType("int(11)")
                    .HasColumnName("checked_out");

                entity.Property(e => e.CheckedOutTime)
                    .HasColumnType("datetime")
                    .HasColumnName("checked_out_time");

                entity.Property(e => e.Components)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("components")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Device)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("device")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(11)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Plugins)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("plugins")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Published)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("published");

                entity.Property(e => e.Rows)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("rows")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Types)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("types")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Users)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("users")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosWishlist>(entity =>
            {
                entity.ToTable("jos_wishlists");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Userid)
                    .HasColumnType("int(11)")
                    .HasColumnName("userid");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("virtuemart_product_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
