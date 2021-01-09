using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabaseTwo.DatabaseTwo
{
    public partial class DatabaseTwoContext : DbContext
    {
        public DatabaseTwoContext()
        {
        }

        public DatabaseTwoContext(DbContextOptions<DatabaseTwoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JosAcymailingUserstat> JosAcymailingUserstats { get; set; }
        public virtual DbSet<JosCategory> JosCategories { get; set; }
        public virtual DbSet<JosContent> JosContents { get; set; }
        public virtual DbSet<JosContentType> JosContentTypes { get; set; }
        public virtual DbSet<JosExtension> JosExtensions { get; set; }
        public virtual DbSet<JosModulesMenu> JosModulesMenus { get; set; }
        public virtual DbSet<JosUser> JosUsers { get; set; }
        public virtual DbSet<JosUserKey> JosUserKeys { get; set; }
        public virtual DbSet<JosUserUsergroupMap> JosUserUsergroupMaps { get; set; }
        public virtual DbSet<JosUsergroup> JosUsergroups { get; set; }
        public virtual DbSet<JosVirtuemartAdminmenuentry> JosVirtuemartAdminmenuentries { get; set; }
        public virtual DbSet<JosVirtuemartCalc> JosVirtuemartCalcs { get; set; }
        public virtual DbSet<JosVirtuemartCalcCategory> JosVirtuemartCalcCategories { get; set; }
        public virtual DbSet<JosVirtuemartCalcCountry> JosVirtuemartCalcCountries { get; set; }
        public virtual DbSet<JosVirtuemartCalcManufacturer> JosVirtuemartCalcManufacturers { get; set; }
        public virtual DbSet<JosVirtuemartCalcShoppergroup> JosVirtuemartCalcShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartCart> JosVirtuemartCarts { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesEnGb> JosVirtuemartCategoriesEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartCategoriesFrFr> JosVirtuemartCategoriesFrFrs { get; set; }
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
        public virtual DbSet<JosVirtuemartManufacturercategoriesDeDe> JosVirtuemartManufacturercategoriesDeDes { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesEnGb> JosVirtuemartManufacturercategoriesEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesFrFr> JosVirtuemartManufacturercategoriesFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesFrFrbak> JosVirtuemartManufacturercategoriesFrFrbaks { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesItIt> JosVirtuemartManufacturercategoriesItIts { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategoriesRuRu> JosVirtuemartManufacturercategoriesRuRus { get; set; }
        public virtual DbSet<JosVirtuemartManufacturercategory> JosVirtuemartManufacturercategories { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersDeDe> JosVirtuemartManufacturersDeDes { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersEnGb> JosVirtuemartManufacturersEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersEsE> JosVirtuemartManufacturersEsEs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersFrFr> JosVirtuemartManufacturersFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersFrFrbak> JosVirtuemartManufacturersFrFrbaks { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersItIt> JosVirtuemartManufacturersItIts { get; set; }
        public virtual DbSet<JosVirtuemartManufacturersRuRu> JosVirtuemartManufacturersRuRus { get; set; }
        public virtual DbSet<JosVirtuemartMedia> JosVirtuemartMedias { get; set; }
        public virtual DbSet<JosVirtuemartMigrationOldtonewId> JosVirtuemartMigrationOldtonewIds { get; set; }
        public virtual DbSet<JosVirtuemartModule> JosVirtuemartModules { get; set; }
        public virtual DbSet<JosVirtuemartOrder> JosVirtuemartOrders { get; set; }
        public virtual DbSet<JosVirtuemartOrderCalcRule> JosVirtuemartOrderCalcRules { get; set; }
        public virtual DbSet<JosVirtuemartOrderHistory> JosVirtuemartOrderHistories { get; set; }
        public virtual DbSet<JosVirtuemartOrderItem> JosVirtuemartOrderItems { get; set; }
        public virtual DbSet<JosVirtuemartOrderUserinfo> JosVirtuemartOrderUserinfos { get; set; }
        public virtual DbSet<JosVirtuemartOrderstate> JosVirtuemartOrderstates { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgAlatakMonetico> JosVirtuemartPaymentPlgAlatakMoneticos { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgAlatakSip> JosVirtuemartPaymentPlgAlatakSips { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgAuthorizenet> JosVirtuemartPaymentPlgAuthorizenets { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgHeidelpay> JosVirtuemartPaymentPlgHeidelpays { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgPaypal> JosVirtuemartPaymentPlgPaypals { get; set; }
        public virtual DbSet<JosVirtuemartPaymentPlgStandard> JosVirtuemartPaymentPlgStandards { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethod> JosVirtuemartPaymentmethods { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodShoppergroup> JosVirtuemartPaymentmethodShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsDeDe> JosVirtuemartPaymentmethodsDeDes { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsEnGb> JosVirtuemartPaymentmethodsEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsEsE> JosVirtuemartPaymentmethodsEsEs { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsFrFr> JosVirtuemartPaymentmethodsFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsFrFrbak> JosVirtuemartPaymentmethodsFrFrbaks { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsItIt> JosVirtuemartPaymentmethodsItIts { get; set; }
        public virtual DbSet<JosVirtuemartPaymentmethodsRuRu> JosVirtuemartPaymentmethodsRuRus { get; set; }
        public virtual DbSet<JosVirtuemartProduct> JosVirtuemartProducts { get; set; }
        public virtual DbSet<JosVirtuemartProductCategory> JosVirtuemartProductCategories { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomPlgIstraxxDownload> JosVirtuemartProductCustomPlgIstraxxDownloads { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomPlgParamRef> JosVirtuemartProductCustomPlgParamRefs { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomPlgParamValue> JosVirtuemartProductCustomPlgParamValues { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomPlgVm2tag> JosVirtuemartProductCustomPlgVm2tags { get; set; }
        public virtual DbSet<JosVirtuemartProductCustomfield> JosVirtuemartProductCustomfields { get; set; }
        public virtual DbSet<JosVirtuemartProductManufacturer> JosVirtuemartProductManufacturers { get; set; }
        public virtual DbSet<JosVirtuemartProductMedia> JosVirtuemartProductMedias { get; set; }
        public virtual DbSet<JosVirtuemartProductPrice> JosVirtuemartProductPrices { get; set; }
        public virtual DbSet<JosVirtuemartProductRelation> JosVirtuemartProductRelations { get; set; }
        public virtual DbSet<JosVirtuemartProductShoppergroup> JosVirtuemartProductShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartProductsEnGb> JosVirtuemartProductsEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartProductsFrFr> JosVirtuemartProductsFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartRating> JosVirtuemartRatings { get; set; }
        public virtual DbSet<JosVirtuemartRatingReview> JosVirtuemartRatingReviews { get; set; }
        public virtual DbSet<JosVirtuemartShipmentPlgWeightCountry> JosVirtuemartShipmentPlgWeightCountries { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethod> JosVirtuemartShipmentmethods { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodShoppergroup> JosVirtuemartShipmentmethodShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartShipmentmethodsFrFr> JosVirtuemartShipmentmethodsFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartShoppergroup> JosVirtuemartShoppergroups { get; set; }
        public virtual DbSet<JosVirtuemartState> JosVirtuemartStates { get; set; }
        public virtual DbSet<JosVirtuemartUserfield> JosVirtuemartUserfields { get; set; }
        public virtual DbSet<JosVirtuemartUserfieldValue> JosVirtuemartUserfieldValues { get; set; }
        public virtual DbSet<JosVirtuemartUserinfo> JosVirtuemartUserinfos { get; set; }
        public virtual DbSet<JosVirtuemartVendor> JosVirtuemartVendors { get; set; }
        public virtual DbSet<JosVirtuemartVendorMedia> JosVirtuemartVendorMedias { get; set; }
        public virtual DbSet<JosVirtuemartVendorUser> JosVirtuemartVendorUsers { get; set; }
        public virtual DbSet<JosVirtuemartVendorsDeDe> JosVirtuemartVendorsDeDes { get; set; }
        public virtual DbSet<JosVirtuemartVendorsEnGb> JosVirtuemartVendorsEnGbs { get; set; }
        public virtual DbSet<JosVirtuemartVendorsFrFr> JosVirtuemartVendorsFrFrs { get; set; }
        public virtual DbSet<JosVirtuemartVendorsFrFrbak> JosVirtuemartVendorsFrFrbaks { get; set; }
        public virtual DbSet<JosVirtuemartVendorsItIt> JosVirtuemartVendorsItIts { get; set; }
        public virtual DbSet<JosVirtuemartVendorsRuRu> JosVirtuemartVendorsRuRus { get; set; }
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
                optionsBuilder.UseMySql("server=127.0.0.1;AllowZeroDateTime=True;convert zero datetime=True;database=db2;user=root;port=13301;password=password;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.FromString("10.4.6-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                    .IsRequired()
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
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Version)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosContent>(entity =>
            {
                entity.ToTable("jos_content");

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
                    .HasColumnType("mediumtext")
                    .HasColumnName("fulltext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("images")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Introtext)
                    .IsRequired()
                    .HasColumnType("mediumtext")
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
                    .HasColumnType("text")
                    .HasColumnName("metadata")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metadesc)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("metadesc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Metakey)
                    .IsRequired()
                    .HasColumnType("text")
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
                    .HasColumnType("text")
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
                    .HasComment("A reference to enable linkages to external data sets.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
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
                    .HasColumnType("text")
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
                    .HasColumnType("text")
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
                    .HasColumnType("text")
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
                    .HasColumnName("enabled")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("folder")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ManifestCache)
                    .IsRequired()
                    .HasColumnType("text")
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

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text")
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
                    .HasColumnType("text")
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

            modelBuilder.Entity<JosUser>(entity =>
            {
                entity.ToTable("jos_users");

                entity.HasIndex(e => e.Email, "email");

                entity.HasIndex(e => e.Block, "idx_block");

                entity.HasIndex(e => e.Name, "idx_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 100 });

                entity.HasIndex(e => e.Username, "username");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Activation)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("activation")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Block)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("block");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("email")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

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
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Otep)
                    .IsRequired()
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("otep")
                    .HasDefaultValueSql("''")
                    .HasComment("One time emergency passwords")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.OtpKey)
                    .IsRequired()
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("otpKey")
                    .HasDefaultValueSql("''")
                    .HasComment("Two factor authentication encrypted keys")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("password")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

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
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Usertype)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("usertype")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
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
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Time)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasColumnName("time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Uastring)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("uastring")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(150)")
                    .HasColumnName("user_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
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
                    .HasComment("THE ID OF THE VM MODULE, THIS ITEM IS ASSIGNED TO");

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
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.CalcCurrency)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("calc_currency")
                    .HasComment("Currency of the Rule");

                entity.Property(e => e.CalcDescr)
                    .IsRequired()
                    .HasColumnType("char(128)")
                    .HasColumnName("calc_descr")
                    .HasDefaultValueSql("''")
                    .HasComment("Description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("calc_jplugin_id");

                entity.Property(e => e.CalcKind)
                    .IsRequired()
                    .HasColumnType("char(16)")
                    .HasColumnName("calc_kind")
                    .HasDefaultValueSql("''")
                    .HasComment("Discount/Tax/Margin/Commission")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcName)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasColumnName("calc_name")
                    .HasDefaultValueSql("''")
                    .HasComment("Name of the rule")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcParams)
                    .IsRequired()
                    .HasColumnType("varchar(18000)")
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
                    .HasColumnType("char(8)")
                    .HasColumnName("calc_value_mathop")
                    .HasDefaultValueSql("''")
                    .HasComment("the mathematical operation like (+,-,+%,-%)")
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
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Belongs to vendor");
            });

            modelBuilder.Entity<JosVirtuemartCalcCategory>(entity =>
            {
                entity.ToTable("jos_virtuemart_calc_categories");

                entity.HasIndex(e => new { e.VirtuemartCalcId, e.VirtuemartCategoryId }, "virtuemart_calc_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_category_id")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<JosVirtuemartCalcCountry>(entity =>
            {
                entity.ToTable("jos_virtuemart_calc_countries");

                entity.HasIndex(e => new { e.VirtuemartCalcId, e.VirtuemartCountryId }, "virtuemart_calc_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartCountryId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_country_id");
            });

            modelBuilder.Entity<JosVirtuemartCalcManufacturer>(entity =>
            {
                entity.ToTable("jos_virtuemart_calc_manufacturers");

                entity.HasIndex(e => new { e.VirtuemartCalcId, e.VirtuemartManufacturerId }, "virtuemart_calc_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_manufacturer_id");
            });

            modelBuilder.Entity<JosVirtuemartCalcShoppergroup>(entity =>
            {
                entity.ToTable("jos_virtuemart_calc_shoppergroups");

                entity.HasIndex(e => new { e.VirtuemartCalcId, e.VirtuemartShoppergroupId }, "virtuemart_calc_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartCalcId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");
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
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_category_id");

                entity.Property(e => e.CategoryLayout)
                    .HasColumnType("char(64)")
                    .HasColumnName("category_layout")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryProductLayout)
                    .HasColumnType("char(64)")
                    .HasColumnName("category_product_layout")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CategoryTemplate)
                    .HasColumnType("char(128)")
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
                    .HasColumnType("char(32)")
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
                    .HasColumnType("char(64)")
                    .HasColumnName("metaauthor")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metarobot)
                    .IsRequired()
                    .HasColumnType("char(40)")
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

                entity.Property(e => e.ProductsPerRow).HasColumnName("products_per_row");

                entity.Property(e => e.Published)
                    .IsRequired()
                    .HasColumnName("published")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Shared).HasColumnName("shared");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1) unsigned")
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

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => new { e.VirtuemartCategoryId, e.VirtuemartMediaId }, "virtuemart_category_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.VirtuemartCategoryId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_category_id")
                    .HasDefaultValueSql("'0'");

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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("char(64)")
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

                entity.Property(e => e.VirtuemartCouponId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_coupon_id");

                entity.Property(e => e.CouponCode)
                    .IsRequired()
                    .HasColumnType("char(32)")
                    .HasColumnName("coupon_code")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CouponExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_expiry_date");

                entity.Property(e => e.CouponStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("coupon_start_date");

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
            });

            modelBuilder.Entity<JosVirtuemartCurrency>(entity =>
            {
                entity.HasKey(e => e.VirtuemartCurrencyId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_currencies");

                entity.HasComment("Used to store currencies");

                entity.HasIndex(e => e.CurrencyCode3, "currency_code_3");

                entity.HasIndex(e => e.CurrencyName, "currency_name");

                entity.HasIndex(e => e.CurrencyNumericCode, "currency_numeric_code");

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.Shared, "shared");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartCurrencyId)
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("char(4)")
                    .HasColumnName("currency_decimal_place")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyDecimalSymbol)
                    .HasColumnType("char(4)")
                    .HasColumnName("currency_decimal_symbol")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyExchangeRate)
                    .HasPrecision(10, 5)
                    .HasColumnName("currency_exchange_rate");

                entity.Property(e => e.CurrencyName)
                    .HasColumnType("char(64)")
                    .HasColumnName("currency_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyNegativeStyle)
                    .HasColumnType("char(64)")
                    .HasColumnName("currency_negative_style")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyNumericCode)
                    .HasColumnType("int(4)")
                    .HasColumnName("currency_numeric_code");

                entity.Property(e => e.CurrencyPositiveStyle)
                    .HasColumnType("char(64)")
                    .HasColumnName("currency_positive_style")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencySymbol)
                    .HasColumnType("char(4)")
                    .HasColumnName("currency_symbol")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CurrencyThousands)
                    .HasColumnType("char(4)")
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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("custom_desc")
                    .HasComment("description or unit")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomElement)
                    .IsRequired()
                    .HasColumnType("char(50)")
                    .HasColumnName("custom_element")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("custom_jplugin_id");

                entity.Property(e => e.CustomParams)
                    .IsRequired()
                    .HasColumnType("varchar(17000)")
                    .HasColumnName("custom_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomParentId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("custom_parent_id");

                entity.Property(e => e.CustomTip)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("custom_tip")
                    .HasDefaultValueSql("''")
                    .HasComment("tip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomTitle)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("custom_title")
                    .HasDefaultValueSql("''")
                    .HasComment("field title")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomValue)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("custom_value")
                    .HasComment("DEFAULT VALUE")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FieldType)
                    .IsRequired()
                    .HasColumnType("char(2)")
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
                    .HasColumnType("char(24)")
                    .HasColumnName("layout_pos")
                    .HasComment("Layout Position")
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
                    .HasColumnName("shared")
                    .HasComment("VALID FOR ALL VENDORS?");

                entity.Property(e => e.ShowTitle)
                    .IsRequired()
                    .HasColumnName("show_title")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1)")
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

                entity.Property(e => e.InvoiceNumber)
                    .HasColumnType("char(64)")
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

                entity.Property(e => e.OrderStatus)
                    .HasColumnType("char(2)")
                    .HasColumnName("order_status")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.VirtuemartMediaId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_media_id");
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

            modelBuilder.Entity<JosVirtuemartManufacturercategoriesFrFrbak>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturercategoriesId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturercategories_fr_frbak");

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

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
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

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
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

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
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

            modelBuilder.Entity<JosVirtuemartManufacturersFrFrbak>(entity =>
            {
                entity.HasKey(e => e.VirtuemartManufacturerId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_manufacturers_fr_frbak");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartManufacturerId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
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

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
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

                entity.Property(e => e.MfDesc)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
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

            modelBuilder.Entity<JosVirtuemartMedia>(entity =>
            {
                entity.HasKey(e => e.VirtuemartMediaId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_medias");

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
                    .HasColumnType("char(64)")
                    .HasColumnName("file_class")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FileDescription)
                    .IsRequired()
                    .HasColumnType("char(254)")
                    .HasColumnName("file_description")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FileIsDownloadable).HasColumnName("file_is_downloadable");

                entity.Property(e => e.FileIsForSale).HasColumnName("file_is_forSale");

                entity.Property(e => e.FileIsProductImage).HasColumnName("file_is_product_image");

                entity.Property(e => e.FileLang)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasColumnName("file_lang")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FileMeta)
                    .IsRequired()
                    .HasColumnType("char(254)")
                    .HasColumnName("file_meta")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FileMimetype)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasColumnName("file_mimetype")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FileParams)
                    .IsRequired()
                    .HasColumnType("varchar(17000)")
                    .HasColumnName("file_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FileTitle)
                    .IsRequired()
                    .HasColumnType("char(126)")
                    .HasColumnName("file_title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnType("char(32)")
                    .HasColumnName("file_type")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FileUrl)
                    .IsRequired()
                    .HasColumnType("varchar(900)")
                    .HasColumnName("file_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FileUrlThumb)
                    .IsRequired()
                    .HasColumnType("varchar(900)")
                    .HasColumnName("file_url_thumb")
                    .HasDefaultValueSql("''")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

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
                    .HasColumnType("smallint(1)")
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
                    .HasColumnType("varchar(21000)")
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

                entity.HasIndex(e => e.OrderNumber, "order_number");

                entity.HasIndex(e => e.VirtuemartPaymentmethodId, "virtuemart_paymentmethod_id");

                entity.HasIndex(e => e.VirtuemartShipmentmethodId, "virtuemart_shipmentmethod_id");

                entity.HasIndex(e => e.VirtuemartUserId, "virtuemart_user_id");

                entity.HasIndex(e => e.VirtuemartVendorId, "virtuemart_vendor_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.CouponCode)
                    .HasColumnType("char(32)")
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

                entity.Property(e => e.CustomerNote)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasColumnName("customer_note")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustomerNumber)
                    .HasColumnType("char(32)")
                    .HasColumnName("customer_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("delivery_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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

                entity.Property(e => e.OcNote)
                    .IsRequired()
                    .HasColumnType("varchar(20000)")
                    .HasColumnName("oc_note")
                    .HasDefaultValueSql("''")
                    .HasComment("old customer notes")
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
                    .HasColumnType("char(7)")
                    .HasColumnName("order_language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("char(64)")
                    .HasColumnName("order_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderPass)
                    .HasColumnType("char(8)")
                    .HasColumnName("order_pass")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderPayment)
                    .HasPrecision(10, 2)
                    .HasColumnName("order_payment");

                entity.Property(e => e.OrderPaymentTax)
                    .HasPrecision(10, 5)
                    .HasColumnName("order_payment_tax");

                entity.Property(e => e.OrderSalesPrice)
                    .HasPrecision(15, 5)
                    .HasColumnName("order_salesPrice");

                entity.Property(e => e.OrderShipment)
                    .HasPrecision(10, 2)
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
                    .HasPrecision(10, 5)
                    .HasColumnName("order_tax");

                entity.Property(e => e.OrderTotal)
                    .HasPrecision(15, 5)
                    .HasColumnName("order_total");

                entity.Property(e => e.UserCurrencyId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("user_currency_id");

                entity.Property(e => e.UserCurrencyRate)
                    .HasPrecision(10, 5)
                    .HasColumnName("user_currency_rate")
                    .HasDefaultValueSql("'1.00000'");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("smallint(1)")
                    .HasColumnName("calc_currency");

                entity.Property(e => e.CalcKind)
                    .IsRequired()
                    .HasColumnType("char(16)")
                    .HasColumnName("calc_kind")
                    .HasDefaultValueSql("''")
                    .HasComment("Discount/Tax/Margin/Commission")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcMathop)
                    .IsRequired()
                    .HasColumnType("char(16)")
                    .HasColumnName("calc_mathop")
                    .HasDefaultValueSql("''")
                    .HasComment("Discount/Tax/Margin/Commission")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcParams)
                    .IsRequired()
                    .HasColumnType("varchar(18000)")
                    .HasColumnName("calc_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CalcResult)
                    .HasPrecision(15, 5)
                    .HasColumnName("calc_result");

                entity.Property(e => e.CalcRuleName)
                    .IsRequired()
                    .HasColumnType("char(64)")
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
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_calc_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartOrderItemId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_order_item_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartOrderHistory>(entity =>
            {
                entity.HasKey(e => e.VirtuemartOrderHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_order_histories");

                entity.HasComment("Stores all actions and changes that occur to an order");

                entity.Property(e => e.VirtuemartOrderHistoryId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_order_history_id");

                entity.Property(e => e.Comments)
                    .HasColumnType("varchar(21000)")
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

                entity.Property(e => e.OrderStatusCode)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasColumnName("order_status_code")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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
                    .HasColumnType("char(255)")
                    .HasColumnName("order_item_sku")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatus)
                    .HasColumnType("char(1)")
                    .HasColumnName("order_status")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_product_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1)")
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
                    .HasColumnType("char(64)")
                    .HasColumnName("address_1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("char(64)")
                    .HasColumnName("address_2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressType)
                    .HasColumnType("char(2)")
                    .HasColumnName("address_type")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AddressTypeName)
                    .HasColumnType("char(32)")
                    .HasColumnName("address_type_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Agreed).HasColumnName("agreed");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasColumnName("city")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("char(64)")
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
                    .HasColumnType("varchar(2500)")
                    .HasColumnName("customer_note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("char(128)")
                    .HasColumnName("email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fax)
                    .HasColumnType("char(32)")
                    .HasColumnName("fax")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnType("char(48)")
                    .HasColumnName("first_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .HasColumnType("char(48)")
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
                    .HasColumnType("char(48)")
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
                    .HasColumnType("char(32)")
                    .HasColumnName("phone_1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone2)
                    .HasColumnType("char(32)")
                    .HasColumnName("phone_2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnType("char(32)")
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
                    .HasColumnType("char(16)")
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

                entity.Property(e => e.OrderStatusDescription)
                    .HasColumnType("varchar(20000)")
                    .HasColumnName("order_status_description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStatusName)
                    .HasColumnType("char(64)")
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
                    .HasColumnType("smallint(1)")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JosVirtuemartPaymentPlgAlatakMonetico>(entity =>
            {
                entity.ToTable("jos_virtuemart_payment_plg_alatak_monetico");

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
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

                entity.Property(e => e.MoneticoCustom)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("monetico_custom")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseBincb)
                    .HasColumnType("char(10)")
                    .HasColumnName("monetico_response_bincb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseBrand)
                    .HasColumnType("char(20)")
                    .HasColumnName("monetico_response_brand")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseCodeRetour)
                    .HasColumnType("char(15)")
                    .HasColumnName("monetico_response_code-retour")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseCvx)
                    .HasColumnType("char(10)")
                    .HasColumnName("monetico_response_cvx")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseDate)
                    .HasColumnType("char(32)")
                    .HasColumnName("monetico_response_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseFiltragecause)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("monetico_response_filtragecause");

                entity.Property(e => e.MoneticoResponseFiltragevaleur)
                    .HasColumnType("char(20)")
                    .HasColumnName("monetico_response_filtragevaleur")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseHpancb)
                    .HasColumnType("char(128)")
                    .HasColumnName("monetico_response_hpancb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseIpclient)
                    .HasColumnType("char(64)")
                    .HasColumnName("monetico_response_ipclient")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseMontant)
                    .HasColumnType("char(32)")
                    .HasColumnName("monetico_response_montant")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseMontantech)
                    .HasColumnType("char(20)")
                    .HasColumnName("monetico_response_montantech")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseMotifrefus)
                    .HasColumnType("char(50)")
                    .HasColumnName("monetico_response_motifrefus")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseNumauto)
                    .HasColumnType("char(50)")
                    .HasColumnName("monetico_response_numauto")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseOriginecb)
                    .HasColumnType("char(10)")
                    .HasColumnName("monetico_response_originecb")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseOrigintr)
                    .HasColumnType("char(3)")
                    .HasColumnName("monetico_response_origintr")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponsePares)
                    .HasColumnType("char(128)")
                    .HasColumnName("monetico_response_pares")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseReference)
                    .HasColumnType("char(32)")
                    .HasColumnName("monetico_response_reference")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseStatus3ds)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("monetico_response_status3ds");

                entity.Property(e => e.MoneticoResponseVeres)
                    .HasColumnType("char(20)")
                    .HasColumnName("monetico_response_veres")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoResponseVld)
                    .HasColumnType("char(20)")
                    .HasColumnName("monetico_response_vld")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MoneticoresponseRaw)
                    .HasColumnType("text")
                    .HasColumnName("moneticoresponse_raw")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderNumber)
                    .HasColumnType("char(32)")
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
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");
            });

            modelBuilder.Entity<JosVirtuemartPaymentPlgAlatakSip>(entity =>
            {
                entity.ToTable("jos_virtuemart_payment_plg_alatak_sips");

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
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
                    .HasColumnType("char(32)")
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

                entity.Property(e => e.SipsCryptedData)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_crypted_data")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentAmount)
                    .HasPrecision(10, 2)
                    .HasColumnName("sips_payment_amount");

                entity.Property(e => e.SipsPaymentAuthorisationId)
                    .HasColumnType("char(50)")
                    .HasColumnName("sips_payment_authorisation_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentBankResponseCode)
                    .HasColumnType("char(128)")
                    .HasColumnName("sips_payment_bank_response_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCaddie)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_caddie")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCaptureDay)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_capture_day")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCaptureMode)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_capture_mode")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCardNumber)
                    .HasColumnType("char(128)")
                    .HasColumnName("sips_payment_card_number")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentComplementaryCode)
                    .HasColumnType("char(128)")
                    .HasColumnName("sips_payment_complementary_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentComplementaryInfo)
                    .HasColumnType("char(128)")
                    .HasColumnName("sips_payment_complementary_info")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCurrency)
                    .HasColumnType("char(7)")
                    .HasColumnName("sips_payment_currency")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCustomerEmail)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_customer_email")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCustomerId)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_customer_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCustomerIpAddress)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_customer_ip_address")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCvvFlag)
                    .HasColumnType("char(64)")
                    .HasColumnName("sips_payment_cvv_flag")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentCvvResponseCode)
                    .HasColumnType("char(64)")
                    .HasColumnName("sips_payment_cvv_response_code")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentData)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_data")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentDate)
                    .HasColumnType("char(13)")
                    .HasColumnName("sips_payment_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentLanguage)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentMerchantCountry)
                    .HasColumnType("char(10)")
                    .HasColumnName("sips_payment_merchant_country")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentMerchantId)
                    .HasColumnType("char(7)")
                    .HasColumnName("sips_payment_merchant_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentMerchantLanguage)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_merchant_language")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentPaymentCertificate)
                    .HasColumnType("char(50)")
                    .HasColumnName("sips_payment_payment_certificate")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentPaymentMeans)
                    .HasColumnType("char(50)")
                    .HasColumnName("sips_payment_payment_means")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentReceipt)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_payment_receipt")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentResponseCode)
                    .HasColumnType("int(1)")
                    .HasColumnName("sips_payment_response_code");

                entity.Property(e => e.SipsPaymentReturnContext)
                    .HasColumnType("char(128)")
                    .HasColumnName("sips_payment_return_context")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentTime)
                    .HasColumnType("char(13)")
                    .HasColumnName("sips_payment_time")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentTransactionId)
                    .HasColumnType("char(15)")
                    .HasColumnName("sips_payment_transaction_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsPaymentTransmissionDate)
                    .HasColumnType("char(32)")
                    .HasColumnName("sips_payment_transmission_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SipsUncryptedData)
                    .HasColumnType("char(2)")
                    .HasColumnName("sips_uncrypted_data")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TaxId)
                    .HasColumnType("smallint(1)")
                    .HasColumnName("tax_id");

                entity.Property(e => e.VirtuemartOrderId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("virtuemart_order_id");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");
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

            modelBuilder.Entity<JosVirtuemartPaymentPlgStandard>(entity =>
            {
                entity.ToTable("jos_virtuemart_payment_plg_standard");

                entity.HasComment("Payment Standard Table");

                entity.Property(e => e.Id)
                    .HasColumnType("int(1) unsigned")
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
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");

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

                entity.Property(e => e.PaymentElement)
                    .IsRequired()
                    .HasColumnType("char(50)")
                    .HasColumnName("payment_element")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PaymentJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("payment_jplugin_id");

                entity.Property(e => e.PaymentParams)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("payment_params")
                    .HasDefaultValueSql("''")
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
                    .HasColumnType("smallint(1)")
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
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");
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

            modelBuilder.Entity<JosVirtuemartPaymentmethodsFrFrbak>(entity =>
            {
                entity.HasKey(e => e.VirtuemartPaymentmethodId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_paymentmethods_fr_frbak");

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

            modelBuilder.Entity<JosVirtuemartProduct>(entity =>
            {
                entity.HasKey(e => e.VirtuemartProductId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_products");

                entity.HasComment("All products are stored here.");

                entity.HasIndex(e => e.CreatedOn, "created_on");

                entity.HasIndex(e => e.ModifiedOn, "modified_on");

                entity.HasIndex(e => e.Pordering, "pordering");

                entity.HasIndex(e => e.ProductParentId, "product_parent_id");

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

                entity.Property(e => e.Hits)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("hits");

                entity.Property(e => e.Intnotes)
                    .HasColumnType("varchar(18000)")
                    .HasColumnName("intnotes")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Layout)
                    .HasColumnType("char(16)")
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
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("pordering")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProductAvailability)
                    .HasColumnType("char(32)")
                    .HasColumnName("product_availability")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductAvailableDate)
                    .HasColumnType("datetime")
                    .HasColumnName("product_available_date")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

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
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("product_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductParentId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("product_parent_id");

                entity.Property(e => e.ProductSales)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("product_sales");

                entity.Property(e => e.ProductSku)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("product_sku")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSpecial).HasColumnName("product_special");

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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_category_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductCustomPlgIstraxxDownload>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_custom_plg_istraxx_download");

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

                entity.HasIndex(e => e.Ordering, "ordering");

                entity.HasIndex(e => e.Published, "published");

                entity.HasIndex(e => e.VirtuemartCustomId, "virtuemart_custom_id");

                entity.HasIndex(e => e.VirtuemartProductId, "virtuemart_product_id");

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
                    .IsRequired()
                    .HasColumnType("varchar(17000)")
                    .HasColumnName("customfield_params")
                    .HasDefaultValueSql("''")
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

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.Override)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("override");

                entity.Property(e => e.ProductGtin)
                    .HasColumnType("char(64)")
                    .HasColumnName("product_gtin")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductMpn)
                    .HasColumnType("char(64)")
                    .HasColumnName("product_mpn")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProductSku)
                    .HasColumnType("char(64)")
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
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_manufacturer_id");

                entity.Property(e => e.VirtuemartProductId)
                    .HasColumnType("int(1)")
                    .HasColumnName("virtuemart_product_id");
            });

            modelBuilder.Entity<JosVirtuemartProductMedia>(entity =>
            {
                entity.ToTable("jos_virtuemart_product_medias");

                entity.HasIndex(e => e.Ordering, "ordering");

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

                entity.HasIndex(e => e.VirtuemartProductId, "product_price");

                entity.HasIndex(e => e.ProductPricePublishDown, "product_price_publish_down");

                entity.HasIndex(e => e.ProductPricePublishUp, "product_price_publish_up");

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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");
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

                entity.HasIndex(e => new { e.VirtuemartProductId, e.CreatedBy }, "virtuemart_product_id")
                    .IsUnique();

                entity.Property(e => e.VirtuemartRatingReviewId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_rating_review_id");

                entity.Property(e => e.Comment)
                    .HasColumnType("varchar(18000)")
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
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_shipmentmethod_id");

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

                entity.Property(e => e.ShipmentElement)
                    .IsRequired()
                    .HasColumnType("char(50)")
                    .HasColumnName("shipment_element")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShipmentJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("shipment_jplugin_id");

                entity.Property(e => e.ShipmentParams)
                    .IsRequired()
                    .HasColumnType("varchar(19000)")
                    .HasColumnName("shipment_params")
                    .HasDefaultValueSql("''")
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
                    .HasColumnType("smallint(1)")
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
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_shipmentmethod_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VirtuemartShoppergroupId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_shoppergroup_id");
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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("shopper_group_desc")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShopperGroupName)
                    .HasColumnType("char(128)")
                    .HasColumnName("shopper_group_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1)")
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
                    .HasColumnType("smallint(1) unsigned")
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

                entity.Property(e => e.Shared).HasColumnName("shared");

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
                    .HasColumnType("char(64)")
                    .HasColumnName("state_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartCountryId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_country_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.VirtuemartWorldzoneId)
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("char(255)")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

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
                    .HasColumnType("char(255)")
                    .HasColumnName("title")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("char(70)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserfieldJpluginId)
                    .HasColumnType("int(1)")
                    .HasColumnName("userfield_jplugin_id");

                entity.Property(e => e.UserfieldParams)
                    .IsRequired()
                    .HasColumnType("varchar(17000)")
                    .HasColumnName("userfield_params")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .HasColumnType("char(255)")
                    .HasColumnName("value")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("fieldtitle")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fieldvalue)
                    .IsRequired()
                    .HasColumnType("char(255)")
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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("char(64)")
                    .HasColumnName("address_1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Address2)
                    .HasColumnType("char(64)")
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
                    .HasColumnType("char(32)")
                    .HasColumnName("address_type_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Agreed).HasColumnName("agreed");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("char(64)")
                    .HasColumnName("city")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Company)
                    .HasColumnType("char(64)")
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
                    .HasColumnType("varchar(2500)")
                    .HasColumnName("customer_note")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fax)
                    .HasColumnType("char(32)")
                    .HasColumnName("fax")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FirstName)
                    .HasColumnType("char(48)")
                    .HasColumnName("first_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastName)
                    .HasColumnType("char(48)")
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
                    .HasColumnType("char(48)")
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

                entity.Property(e => e.Name)
                    .HasColumnType("char(64)")
                    .HasColumnName("name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone1)
                    .HasColumnType("char(32)")
                    .HasColumnName("phone_1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone2)
                    .HasColumnType("char(32)")
                    .HasColumnName("phone_2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnType("char(32)")
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
                    .HasColumnType("char(32)")
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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("char(64)")
                    .HasColumnName("metaauthor")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Metarobot)
                    .HasColumnType("char(20)")
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
                    .HasColumnType("char(64)")
                    .HasColumnName("vendor_name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorParams)
                    .IsRequired()
                    .HasColumnType("varchar(17000)")
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
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Ordering)
                    .HasColumnType("int(1)")
                    .HasColumnName("ordering");

                entity.Property(e => e.VirtuemartMediaId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_media_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id");
            });

            modelBuilder.Entity<JosVirtuemartVendorUser>(entity =>
            {
                entity.ToTable("jos_virtuemart_vendor_users");

                entity.HasIndex(e => new { e.VirtuemartVendorId, e.VirtuemartUserId }, "virtuemart_vendor_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.VirtuemartUserId)
                    .HasColumnType("int(1) unsigned")
                    .HasColumnName("virtuemart_user_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1) unsigned")
                    .HasColumnName("virtuemart_vendor_id");
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

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("char(26)")
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
                    .HasColumnType("char(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("char(255)")
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

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("char(26)")
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
                    .HasColumnType("char(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("char(255)")
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

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("char(26)")
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
                    .HasColumnType("char(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<JosVirtuemartVendorsFrFrbak>(entity =>
            {
                entity.HasKey(e => e.VirtuemartVendorId)
                    .HasName("PRIMARY");

                entity.ToTable("jos_virtuemart_vendors_fr_frbak");

                entity.HasIndex(e => e.Slug, "slug")
                    .IsUnique();

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("int(1) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("virtuemart_vendor_id");

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

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("char(26)")
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
                    .HasColumnType("char(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("char(255)")
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

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("char(26)")
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
                    .HasColumnType("char(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("char(255)")
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

                entity.Property(e => e.VendorInvoiceFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_invoice_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorInvoiceFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
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
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_css")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree1)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free1")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorMailFree2)
                    .IsRequired()
                    .HasColumnType("char(255)")
                    .HasColumnName("vendor_mail_free2")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorPhone)
                    .IsRequired()
                    .HasColumnType("char(26)")
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
                    .HasColumnType("char(180)")
                    .HasColumnName("vendor_store_name")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorTermsOfService)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("vendor_terms_of_service")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VendorUrl)
                    .IsRequired()
                    .HasColumnType("char(255)")
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
                    .HasColumnType("char(32)")
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

                entity.Property(e => e.Perms)
                    .IsRequired()
                    .HasColumnType("char(40)")
                    .HasColumnName("perms")
                    .HasDefaultValueSql("'shopper'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserIsVendor).HasColumnName("user_is_vendor");

                entity.Property(e => e.VirtuemartPaymentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_paymentmethod_id");

                entity.Property(e => e.VirtuemartShipmentmethodId)
                    .HasColumnType("mediumint(1) unsigned")
                    .HasColumnName("virtuemart_shipmentmethod_id");

                entity.Property(e => e.VirtuemartVendorId)
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("smallint(1) unsigned")
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
                    .HasColumnType("char(150)")
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
                    .HasColumnType("smallint(1)")
                    .HasColumnName("virtuemart_vendor_id");

                entity.Property(e => e.ZoneCost)
                    .HasPrecision(10, 2)
                    .HasColumnName("zone_cost");

                entity.Property(e => e.ZoneDescription)
                    .HasColumnType("varchar(18000)")
                    .HasColumnName("zone_description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ZoneLimit)
                    .HasPrecision(10, 2)
                    .HasColumnName("zone_limit");

                entity.Property(e => e.ZoneName)
                    .HasColumnType("char(255)")
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
                    .HasColumnType("varchar(255)")
                    .HasColumnName("alias")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_bin");

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
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Featured)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("featured")
                    .HasComment("Set if link is featured.");

                entity.Property(e => e.Hits)
                    .HasColumnType("int(11)")
                    .HasColumnName("hits");

                entity.Property(e => e.Images)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("images")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnType("char(7)")
                    .HasColumnName("language")
                    .HasDefaultValueSql("''")
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
                    .HasColumnType("text")
                    .HasColumnName("params")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

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
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("url")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Version)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("version")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Xreference)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasColumnName("xreference")
                    .HasComment("A reference to enable linkages to external data sets.")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
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
                    .HasColumnType("tinyint(3)")
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
