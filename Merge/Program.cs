﻿using System;
using System.Collections.Generic;
using System.IO;
using AutoMapper;
using System.Linq;
using Merge.Engine;
using System.Reflection;
using System.Threading.Tasks;
using DatabaseOne.DatabaseOne;
using DatabaseTwo.DatabaseTwo;
using JosCategory = DatabaseOne.DatabaseOne.JosCategory;
using JosContent = DatabaseOne.DatabaseOne.JosContent;
using JosUser = DatabaseOne.DatabaseOne.JosUser;
using JosUserUsergroupMap = DatabaseOne.DatabaseOne.JosUserUsergroupMap;
using JosVirtuemartCalc = DatabaseOne.DatabaseOne.JosVirtuemartCalc;
using JosVirtuemartCalcCategory = DatabaseOne.DatabaseOne.JosVirtuemartCalcCategory;
using JosVirtuemartCart = DatabaseOne.DatabaseOne.JosVirtuemartCart;
using JosVirtuemartCategory = DatabaseOne.DatabaseOne.JosVirtuemartCategory;
using JosVirtuemartCategoryCategory = DatabaseOne.DatabaseOne.JosVirtuemartCategoryCategory;
using JosVirtuemartCategoryMedia = DatabaseOne.DatabaseOne.JosVirtuemartCategoryMedia;
using JosVirtuemartCustom = DatabaseOne.DatabaseOne.JosVirtuemartCustom;
using JosVirtuemartInvoice = DatabaseOne.DatabaseOne.JosVirtuemartInvoice;
using JosVirtuemartManufacturer = DatabaseOne.DatabaseOne.JosVirtuemartManufacturer;
using JosVirtuemartManufacturersDeDe = DatabaseOne.DatabaseOne.JosVirtuemartManufacturersDeDe;
using JosVirtuemartManufacturersEnGb = DatabaseOne.DatabaseOne.JosVirtuemartManufacturersEnGb;
using JosVirtuemartManufacturersEsE = DatabaseOne.DatabaseOne.JosVirtuemartManufacturersEsE;
using JosVirtuemartManufacturersFrFr = DatabaseOne.DatabaseOne.JosVirtuemartManufacturersFrFr;
using JosVirtuemartManufacturersItIt = DatabaseOne.DatabaseOne.JosVirtuemartManufacturersItIt;
using JosVirtuemartMedia = DatabaseOne.DatabaseOne.JosVirtuemartMedia;
using JosVirtuemartOrder = DatabaseOne.DatabaseOne.JosVirtuemartOrder;
using JosVirtuemartOrderCalcRule = DatabaseOne.DatabaseOne.JosVirtuemartOrderCalcRule;
using JosVirtuemartOrderHistory = DatabaseOne.DatabaseOne.JosVirtuemartOrderHistory;
using JosVirtuemartOrderItem = DatabaseOne.DatabaseOne.JosVirtuemartOrderItem;
using JosVirtuemartOrderUserinfo = DatabaseOne.DatabaseOne.JosVirtuemartOrderUserinfo;
using JosVirtuemartPaymentmethod = DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethod;
using JosVirtuemartPaymentmethodsDeDe = DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsDeDe;
using JosVirtuemartPaymentmethodsEnGb = DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsEnGb;
using JosVirtuemartPaymentmethodsEsE = DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsEsE;
using JosVirtuemartPaymentmethodsFrFr = DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsFrFr;
using JosVirtuemartPaymentmethodsItIt = DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsItIt;
using JosVirtuemartPaymentmethodsRuRu = DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsRuRu;
using JosVirtuemartPaymentPlgAlatakMonetico = DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgAlatakMonetico;
using JosVirtuemartPaymentPlgAlatakSip = DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgAlatakSip;
using JosVirtuemartPaymentPlgPaypal = DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgPaypal;
using JosVirtuemartPaymentPlgStandard = DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgStandard;
using JosVirtuemartProduct = DatabaseOne.DatabaseOne.JosVirtuemartProduct;
using JosVirtuemartProductCategory = DatabaseOne.DatabaseOne.JosVirtuemartProductCategory;
using JosVirtuemartProductCustomfield = DatabaseOne.DatabaseOne.JosVirtuemartProductCustomfield;
using JosVirtuemartProductMedia = DatabaseOne.DatabaseOne.JosVirtuemartProductMedia;
using JosVirtuemartProductPrice = DatabaseOne.DatabaseOne.JosVirtuemartProductPrice;
using JosVirtuemartProductRelation = DatabaseOne.DatabaseOne.JosVirtuemartProductRelation;
using JosVirtuemartProductsEnGb = DatabaseOne.DatabaseOne.JosVirtuemartProductsEnGb;
using JosVirtuemartProductsFrFr = DatabaseOne.DatabaseOne.JosVirtuemartProductsFrFr;
using JosVirtuemartUserinfo = DatabaseOne.DatabaseOne.JosVirtuemartUserinfo;
using JosVirtuemartVendorMedia = DatabaseOne.DatabaseOne.JosVirtuemartVendorMedia;
using JosVirtuemartVmuser = DatabaseOne.DatabaseOne.JosVirtuemartVmuser;
using JosVirtuemartVmuserShoppergroup = DatabaseOne.DatabaseOne.JosVirtuemartVmuserShoppergroup;
using JosWishlist = DatabaseOne.DatabaseOne.JosWishlist;

namespace Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            var iMapper = Mapper.GetMapper();

            var one = new DatabaseOneContext();
            using (var two = new DatabaseTwoContext())
            {
                var jCategories = two.JosCategories.Where(i => i.Id > 1).ToList();
                int maxJCategories = one.JosCategories.Max(i => i.Id);
                jCategories.ForEach(i =>
                {
                    i.Id += maxJCategories;
                    if (i.ParentId != 1)
                    {
                        i.ParentId += maxJCategories;
                    }

                    one.JosCategories.Add(iMapper.Map(i, new JosCategory()));
                });
                one.SaveChanges();
                var jContents = two.JosContents.ToList();
                int maxContents = one.JosContents.Max(i => i.Id);
                jContents.ForEach(i =>
                {
                    i.Id += maxContents;
                    i.Catid += maxJCategories;
                    one.JosContents.Add(iMapper.Map(i, new JosContent
                    {
                        Parentid = "",
                        TitleAlias = "",
                        Mask = "",
                        Sectionid = "",
                    }));
                });
                one.SaveChanges();


                var engine = new Engine.Engine(one, two, iMapper);
                var maxProduct =
                    engine
                        .MergeRelationSelf<JosVirtuemartProduct,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartProduct>(i => i.VirtuemartProductId,
                            "VirtuemartProductId", "ProductParentId");
                #region JosVirtuemartProduct language

                engine
                    .MergeLanguage<JosVirtuemartProductsEnGb,
                        DatabaseTwo.DatabaseTwo.JosVirtuemartProductsEnGb>(i => i.VirtuemartProductId,
                        "VirtuemartProductId", maxProduct);
                engine
                    .MergeLanguage<JosVirtuemartProductsFrFr,
                        DatabaseTwo.DatabaseTwo.JosVirtuemartProductsFrFr>(i => i.VirtuemartProductId,
                        "VirtuemartProductId", maxProduct);

                #endregion
                try
                {
                    int maxCustom =
                        engine
                            .MergeRelationSelf<JosVirtuemartCustom,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartCustom>(
                                i => i.VirtuemartCustomId, "VirtuemartCustomId", "CustomParentId");
                    var maxManufacture =
                        engine
                            .MergeStatic<JosVirtuemartManufacturer,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturer>(
                                i => i.VirtuemartManufacturerId, "VirtuemartManufacturerId");

                    // can run parallel
                    var maxMedia =
                        engine
                            .MergeStatic<JosVirtuemartMedia,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartMedia>(i => i.VirtuemartMediaId,
                                j => j.VirtuemartMediaId > 1, "VirtuemartMediaId");
                    // run parallel
                    var maxPaymentMethod =
                        engine
                            .MergeStatic<JosVirtuemartPaymentmethod,
                                    DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethod>
                                (i => i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId");

                    // run parallel
                    
                    var maxCategory =
                        engine
                            .MergeStatic<JosVirtuemartCategory,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartCategory>(i => i.VirtuemartCategoryId,
                                "VirtuemartCategoryId");

                    engine
                        .MergeJoinSelfTable<JosVirtuemartCategoryCategory,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartCategoryCategory>(i => i.Id,
                            "Id", "CategoryParentId", "CategoryChildId", maxCategory);

                    #region JosVirtuemartCategory language

                    engine
                        .MergeLanguage<JosVirtuemartCategory,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartCategory>(i => i.VirtuemartCategoryId,
                            "VirtuemartCategoryId", maxCategory);
                    engine
                        .MergeLanguage<JosVirtuemartCategory,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartCategory>(i => i.VirtuemartCategoryId,
                            "VirtuemartCategoryId", maxCategory);

                    #endregion

                    #region JosVirtuemartPaymentmethod language

                    engine
                        .MergeLanguageSlug<JosVirtuemartPaymentmethodsEnGb,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsEnGb>
                            (i => i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);
                    engine
                        .MergeLanguageSlug<JosVirtuemartPaymentmethodsEsE,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsEsE>
                            (i => i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);

                    engine
                        .MergeLanguageSlug<JosVirtuemartPaymentmethodsFrFr,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsFrFr>
                            (i => i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);

                    engine
                        .MergeLanguageSlug<JosVirtuemartPaymentmethodsItIt,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsItIt>
                            (i => i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);

                    engine
                        .MergeLanguageSlug<JosVirtuemartPaymentmethodsDeDe,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsDeDe>
                            (i => i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);

                    engine
                        .MergeLanguageSlug<JosVirtuemartPaymentmethodsRuRu,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsRuRu>
                            (i => i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);

                    #endregion

                    #region JosVirtuemartManufacturer language

                    engine
                        .MergeLanguage<JosVirtuemartManufacturersDeDe,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersDeDe>(
                            i => i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);
                    engine
                        .MergeLanguage<JosVirtuemartManufacturersEnGb,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersEnGb>(
                            i => i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);
                    engine
                        .MergeLanguage<JosVirtuemartManufacturersEsE,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersEsE>(
                            i => i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);
                    engine
                        .MergeLanguage<JosVirtuemartManufacturersFrFr,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersFrFr>(
                            i => i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);
                    engine
                        .MergeLanguage<JosVirtuemartManufacturersItIt,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersItIt>(
                            i => i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);

                    #endregion

                    

                    #region merge other type table

                    engine
                        .MergeJoinTable<JosVirtuemartCategoryMedia,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartCategoryMedia>(i => i.Id,
                            "Id",
                            new[]
                            {
                                new Pair {Name = "VirtuemartCategoryId", Plus = maxCategory},
                                new Pair {Name = "VirtuemartMediaId", Plus = maxMedia}
                            });

                    #endregion

                    #region Merge product Join table

                    engine
                        .MergeJoinTable<JosVirtuemartProductCategory,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartProductCategory>(
                            i => i.Id, "Id", new[]
                            {
                                new Pair {Name = "VirtuemartProductId", Plus = maxProduct},
                                new Pair {Name = "VirtuemartCategoryId", Plus = maxCategory}
                            });

                    engine
                        .MergeJoinTable<JosVirtuemartProductMedia,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartProductMedia>(
                            i => i.Id, "Id", new[]
                            {
                                new Pair {Name = "VirtuemartProductId", Plus = maxProduct},
                                new Pair {Name = "VirtuemartMediaId", Plus = maxMedia}
                            });

                    engine
                        .MergeJoinTable<JosVirtuemartProductPrice,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartProductPrice>(i => i.VirtuemartProductPriceId,
                            "VirtuemartProductPriceId",
                            new[] {new Pair() {Name = "VirtuemartProductId", Plus = maxProduct}});

                    engine
                        .MergeJoinTable<JosVirtuemartProductRelation,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartProductRelation>(i => i.Id,
                            "Id",
                            new[]
                            {
                                new Pair() {Name = "VirtuemartProductId", Plus = maxProduct},
                                new Pair() {Name = "RelatedProducts", Plus = maxProduct}
                            });

                    engine
                        .MergeJoinTable<JosVirtuemartProductCustomfield,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartProductCustomfield>(
                            i => i.VirtuemartCustomfieldId, "VirtuemartCustomfieldId",
                            new[]
                            {
                                new Pair {Name = "VirtuemartProductId", Plus = maxProduct},
                                new Pair {Name = "VirtuemartCustomId", Plus = maxCustom}
                            });

                    #endregion

                    int maxCalc =
                        engine
                            .MergeStatic<JosVirtuemartCalc,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartCalc>(i => i.VirtuemartCalcId,
                                "VirtuemartCalcId");
                    engine
                        .MergeJoinTable<JosVirtuemartCalcCategory,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartCalcCategory>(i => i.Id,
                            "Id",
                            new[]
                            {
                                new Pair {Name = "VirtuemartCalcId", Plus = maxCalc},
                                new Pair {Name = "VirtuemartCategoryId", Plus = maxCategory}
                            });


                    #region JOS USER

                    int maxJUser =
                        engine.MergeStatic<JosUser, DatabaseTwo.DatabaseTwo.JosUser>(i => i.Id,
                            (a) => true, "Id");

                    int maxUser =
                        engine
                            .MergeJoinTable<JosVirtuemartVmuser,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartVmuser>(i => i.VirtuemartUserId,
                                "VirtuemartUserId",
                                new[] {new Pair {Name = "VirtuemartPaymentmethodId", Plus = maxPaymentMethod}});
                    engine
                        .MergeJoinTableS1<JosVirtuemartUserinfo,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartUserinfo>(i => i.VirtuemartUserinfoId,
                            "VirtuemartUserinfoId", new[] {new Pair {Name = "VirtuemartUserId", Plus = maxUser}});
                    engine
                        .MergeJoinTable<JosVirtuemartVmuserShoppergroup,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartVmuserShoppergroup>(i => i.Id,
                            null,
                            new[]
                            {
                                new Pair {Name = "VirtuemartUserId", Plus = maxUser},
                                new Pair {Name = "VirtuemartShoppergroupId", Plus = 0}
                            });
                    engine.MergeJoinTable<JosWishlist, DatabaseTwo.DatabaseTwo.JosWishlist>(
                        i => i.Id, "Id", new[]
                        {
                            new Pair {Name = "VirtuemartProductId", Plus = maxProduct},
                            new Pair {Name = "Userid", Plus = maxJUser}
                        });

                    engine
                        .MergeJoinTable<JosVirtuemartCart, DatabaseTwo.DatabaseTwo.JosVirtuemartCart
                        >(i => i.VirtuemartCartId, "VirtuemartCartId",
                            new[] {new Pair {Name = "VirtuemartUserId", Plus = maxUser}});
                    engine
                        .MergeJoinTable<JosUserUsergroupMap,
                            DatabaseTwo.DatabaseTwo.JosUserUsergroupMap>(null, null, new[]
                        {
                            new Pair {Name = "UserId", Plus = maxJUser},
                            new Pair {Name = "GroupId", Plus = 0},
                        });

                    #endregion

                    engine
                        .MergeJoinTable<JosVirtuemartVendorMedia,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartVendorMedia>(i => i.Id, "Id", new[]
                        {
                            new Pair {Name = "VirtuemartMediaId", Plus = maxMedia},
                        });

                    #region Order

                    int maxOrder =
                        engine
                            .MergeJoinTable<JosVirtuemartOrder,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartOrder>(
                                i => i.VirtuemartOrderId,
                                "VirtuemartOrderId", new[]
                                {
                                    new Pair {Name = "VirtuemartUserId", Plus = maxUser},
                                    new Pair() {Name = "VirtuemartPaymentmethodId", Plus = maxPaymentMethod}
                                });

                    engine
                        .MergeJoinTable<JosVirtuemartOrderUserinfo,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartOrderUserinfo>(i => i.VirtuemartOrderUserinfoId,
                            "VirtuemartOrderUserinfoId",
                            new[]
                            {
                                new Pair {Name = "VirtuemartOrderId", Plus = maxOrder},
                                new Pair() {Name = "VirtuemartUserId", Plus = maxUser}
                            });

                    engine
                        .MergeJoinTable<JosVirtuemartOrderItem,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartOrderItem>(i => i.VirtuemartOrderItemId,
                            "VirtuemartOrderItemId",
                            new[]
                            {
                                new Pair {Name = "VirtuemartOrderId", Plus = maxOrder},
                                new Pair {Name = "VirtuemartProductId", Plus = maxProduct}
                            });
                    engine
                        .MergeJoinTable<JosVirtuemartOrderHistory,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartOrderHistory>(i => i.VirtuemartOrderHistoryId,
                            "VirtuemartOrderHistoryId", new[] {new Pair {Name = "VirtuemartOrderId", Plus = maxOrder}});
                    engine
                        .MergeJoinTable<JosVirtuemartOrderCalcRule,
                            DatabaseTwo.DatabaseTwo.JosVirtuemartOrderCalcRule>(i => i.VirtuemartOrderCalcRuleId,
                            "VirtuemartOrderCalcRuleId",
                            new[] {new Pair {Name = "VirtuemartOrderId", Plus = maxOrder}});

                    int maxInvoice =
                        engine
                            .MergeJoinTable<JosVirtuemartInvoice,
                                DatabaseTwo.DatabaseTwo.JosVirtuemartInvoice>(i => i.VirtuemartInvoiceId,
                                "VirtuemartInvoiceId", new[] {new Pair {Name = "VirtuemartOrderId", Plus = maxOrder}});

                    engine.MergeJoinTable<JosVirtuemartPaymentPlgAlatakMonetico
                        , DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgAlatakMonetico>(i => i.Id,
                        "Id", new[] {new Pair {Name = "VirtuemartOrderId", Plus = maxOrder}});

                    engine.MergeJoinTable<JosVirtuemartPaymentPlgAlatakSip
                        , DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgAlatakSip>(i => i.Id,
                        "Id", new[] {new Pair {Name = "VirtuemartOrderId", Plus = maxOrder}});
                    engine.MergeJoinTable<JosVirtuemartPaymentPlgPaypal
                        , DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgPaypal>(i => i.Id,
                        "Id", new[] {new Pair {Name = "VirtuemartOrderId", Plus = maxOrder}});

                    engine.MergeJoinTable<JosVirtuemartPaymentPlgStandard
                        , DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgStandard>(i => i.Id,
                        "Id", new[] {new Pair {Name = "VirtuemartOrderId", Plus = maxOrder}});

                    #endregion
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                Console.WriteLine("SUCCESS!");
            }
        }
    }
}