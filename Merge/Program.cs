using AutoMapper;
using Merge.DatabaseOne;
using System.Linq;
using Merge.Engine;


namespace Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DatabaseTwo.JosCategory, DatabaseOne.JosCategory>();
                cfg.CreateMap<DatabaseTwo.JosContent, DatabaseOne.JosContent>();
            });
            IMapper iMapper = config.CreateMapper();

            var one = new DatabaseOneContext();
            using (var two = new DatabaseTwo.DatabaseTwoContext())
            {
                var jCategories = two.JosCategories.Where(i=>i.Id>1).ToList();
                int maxJCategories = one.JosCategories.Max(i => i.Id);
                jCategories.ForEach(i =>
                {
                    i.Id += maxJCategories;
                    if (i.ParentId != 1) {                   
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
                    one.JosContents.Add(iMapper.Map(i, new JosContent()));
                });
                one.SaveChanges();

                var engine = new Engine.Engine(one, two, iMapper);
                engine.MergeStatic<JosExtension, DatabaseTwo.JosExtension>(i=>i.ExtensionId, "ExtensionId");
                engine.MergeStatic<JosVirtuemartCoupon, DatabaseTwo.JosVirtuemartCoupon>(i=>i.VirtuemartCouponId, "VirtuemartCouponId");
                int maxCustom = engine.MergeRelationSelf<JosVirtuemartCustom, DatabaseTwo.JosVirtuemartCustom>(
                    i=>i.VirtuemartCustomId, "VirtuemartCustomId", "CustomParentId");
                var maxManufacture = engine.MergeStatic<JosVirtuemartManufacturer, DatabaseTwo.JosVirtuemartManufacturer>(
                    i=>i.VirtuemartManufacturerId, "VirtuemartManufacturerId");
                
                // can run parallel
                var maxMedia = engine.MergeStatic<JosVirtuemartMedia, DatabaseTwo.JosVirtuemartMedia>(i=>i.VirtuemartMediaId,
                    j=>j.VirtuemartMediaId>1, "VirtuemartMediaId");
                // run parallel
                var maxPaymentMethod = engine.MergeStatic<JosVirtuemartPaymentmethod, DatabaseTwo.JosVirtuemartPaymentmethod>
                (i=>i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId");
                
                // run parallel
                var maxProduct = engine.MergeRelationSelf<JosVirtuemartProduct, DatabaseTwo.JosVirtuemartProduct>(i=>i.VirtuemartProductId, 
                    "VirtuemartProductId", "ProductParentId");

                var maxCategory = engine.MergeStatic<JosVirtuemartCategory, DatabaseTwo.JosVirtuemartCategory>(i=>i.VirtuemartCategoryId,
                    "VirtuemartCategoryId");

                engine.MergeJoinSelfTable<JosVirtuemartCategoryCategory, DatabaseTwo.JosVirtuemartCategoryCategory>(i=>i.Id, 
                    "Id", "CategoryParentId", "CategoryChildId", maxCategory);

                #region JosVirtuemartCategory language
                engine.MergeLanguage<JosVirtuemartCategory, DatabaseTwo.JosVirtuemartCategory>(i=>i.VirtuemartCategoryId,
                    "VirtuemartCategoryId", maxCategory);
                engine.MergeLanguage<JosVirtuemartCategory, DatabaseTwo.JosVirtuemartCategory>(i=>i.VirtuemartCategoryId,
                    "VirtuemartCategoryId", maxCategory);
                #endregion
                #region JosVirtuemartPaymentmethod language
                engine.MergeLanguage<JosVirtuemartPaymentmethodsEnGb, DatabaseTwo.JosVirtuemartPaymentmethodsEnGb>
                    (i=>i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);
                engine.MergeLanguage<JosVirtuemartPaymentmethodsEsE, DatabaseTwo.JosVirtuemartPaymentmethodsEsE>
                    (i=>i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);

                engine.MergeLanguage<JosVirtuemartPaymentmethodsFrFr, DatabaseTwo.JosVirtuemartPaymentmethodsFrFr>
                    (i=>i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);
                
                engine.MergeLanguage<JosVirtuemartPaymentmethodsItIt, DatabaseTwo.JosVirtuemartPaymentmethodsItIt>
                    (i=>i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);
                
                engine.MergeLanguage<JosVirtuemartPaymentmethodsDeDe, DatabaseTwo.JosVirtuemartPaymentmethodsDeDe>
                    (i=>i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);
                
                engine.MergeLanguage<JosVirtuemartPaymentmethodsRuRu, DatabaseTwo.JosVirtuemartPaymentmethodsRuRu>
                    (i=>i.VirtuemartPaymentmethodId, "VirtuemartPaymentmethodId", maxPaymentMethod);
                #endregion
                #region JosVirtuemartManufacturer language
                engine.MergeLanguage<JosVirtuemartManufacturersDeDe, DatabaseTwo.JosVirtuemartManufacturersDeDe>(
                    i=>i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);
                engine.MergeLanguage<JosVirtuemartManufacturersEnGb, DatabaseTwo.JosVirtuemartManufacturersEnGb>(
                    i=>i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);
                engine.MergeLanguage<JosVirtuemartManufacturersEsE, DatabaseTwo.JosVirtuemartManufacturersEsE>(
                    i=>i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);
                engine.MergeLanguage<JosVirtuemartManufacturersFrFr, DatabaseTwo.JosVirtuemartManufacturersFrFr>(
                    i=>i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);
                engine.MergeLanguage<JosVirtuemartManufacturersItIt, DatabaseTwo.JosVirtuemartManufacturersItIt>(
                    i=>i.VirtuemartManufacturerId, "VirtuemartManufacturerId", maxManufacture);
                #endregion
                #region JosVirtuemartProduct language
                engine.MergeLanguage<JosVirtuemartProductsEnGb, DatabaseTwo.JosVirtuemartProductsEnGb>(i=>i.VirtuemartProductId, 
                    "VirtuemartProductId", maxProduct);
                engine.MergeLanguage<JosVirtuemartProductsFrFr, DatabaseTwo.JosVirtuemartProductsFrFr>(i=>i.VirtuemartProductId, 
                    "VirtuemartProductId", maxProduct);
                #endregion
                #region merge other type table
                engine.MergeJoinTable<JosVirtuemartCategoryMedia, DatabaseTwo.JosVirtuemartCategoryMedia>(i=>i.Id, 
                    "Id", new[]{new Pair{Name = "VirtuemartCategoryId", Plus = maxCategory}, new Pair{Name = "VirtuemartMediaId", Plus = maxMedia}});
                

                #endregion
                #region Merge product Join table
                
                engine.MergeJoinTable<JosVirtuemartProductCategory, DatabaseTwo.JosVirtuemartProductCategory>(
                    i=>i.Id, "Id", new []{new Pair {Name = "VirtuemartProductId", Plus = maxProduct}, 
                        new Pair {Name = "VirtuemartCategoryId", Plus = maxCategory}});
                
                engine.MergeJoinTable<JosVirtuemartProductMedia, DatabaseTwo.JosVirtuemartProductMedia>(
                    i=>i.Id, "Id", new []{new Pair {Name = "VirtuemartProductId", Plus = maxProduct}, 
                        new Pair {Name = "VirtuemartMediaId", Plus = maxMedia}});
                
                engine.MergeJoinTable<JosVirtuemartProductPrice, DatabaseTwo.JosVirtuemartProductPrice>(i=>i.VirtuemartProductPriceId,
                    "VirtuemartProductPriceId", new []{new Pair(){Name = "VirtuemartProductId", Plus = maxProduct}});
                
                engine.MergeJoinTable<JosVirtuemartProductRelation, DatabaseTwo.JosVirtuemartProductRelation>(i=>i.Id,
                    "Id", new []{new Pair(){Name = "VirtuemartProductId", Plus = maxProduct}, new Pair(){Name = "RelatedProducts", Plus = maxProduct} });
                
                engine.MergeJoinTable<JosVirtuemartProductCustomfield, DatabaseTwo.JosVirtuemartProductCustomfield>(
                    i=>i.VirtuemartCustomfieldId, "VirtuemartCustomfieldId", 
                    new []{new Pair{Name = "VirtuemartProductId", Plus = maxProduct}, new Pair{Name = "VirtuemartCustomId", Plus = maxCustom}});
                #endregion

                int maxCalc = engine.MergeStatic<JosVirtuemartCalc, DatabaseTwo.JosVirtuemartCalc>(i => i.VirtuemartCalcId,
                    "VirtuemartCalcId");
                engine.MergeJoinTable<JosVirtuemartCalcCategory, DatabaseTwo.JosVirtuemartCalcCategory>(i => i.Id,
                    "Id", new []{new Pair{Name = "VirtuemartCalcId", Plus = maxCalc},new Pair{Name = "VirtuemartCategoryId", Plus = maxCategory}});
                
                #region JOS USER

                int maxJUser = engine.MergeStatic<JosUser, DatabaseTwo.JosUser>(i=>i.Id, null, "Id");
                
                int maxUser = engine.MergeJoinTable<JosVirtuemartVmuser, DatabaseTwo.JosVirtuemartVmuser>(i=>i.VirtuemartUserId, "VirtuemartUserId", 
                    new []{new Pair{Name = "VirtuemartPaymentmethodId", Plus = maxPaymentMethod} });
                engine.MergeJoinTable<JosVirtuemartUserinfo, DatabaseTwo.JosVirtuemartUserinfo>(i=>i.VirtuemartUserinfoId,
                    "VirtuemartUserinfoId", new []{new Pair{Name = "VirtuemartUserId", Plus = maxUser}});
                engine.MergeJoinTable<JosVirtuemartVmuserShoppergroup, DatabaseTwo.JosVirtuemartVmuserShoppergroup>(i=>i.Id, 
                    null,new []{new Pair{Name = "VirtuemartUserId", Plus = maxUser}, new Pair{Name = "VirtuemartShoppergroupId", Plus = 0} });
                engine.MergeJoinTable<JosWishlist, DatabaseTwo.JosWishlist>(i=>i.Id, "Id", new []
                {
                    new Pair{Name = "VirtuemartProductId", Plus = maxProduct},
                    new Pair{Name = "Userid", Plus = maxJUser}
                });
                
                engine.MergeJoinTable<JosVirtuemartCart, DatabaseTwo.JosVirtuemartCart>(i=>i.VirtuemartCartId, "VirtuemartCartId",
                    new []{new Pair{Name = "VirtuemartUserId", Plus = maxUser} });
                engine.MergeJoinTable<JosUserUsergroupMap, DatabaseTwo.JosUserUsergroupMap>(null, null, new []
                {
                    new Pair{Name = "UserId", Plus = maxJUser}, 
                    new Pair{Name = "GroupId", Plus = 0}, 
                });
                
                #endregion
                
                engine.MergeJoinTable<JosVirtuemartVendorMedia, DatabaseTwo.JosVirtuemartVendorMedia>(i=>i.Id, "Id", new []
                {
                    new Pair{Name = "VirtuemartMediaId", Plus = maxMedia}, 
                });

                #region Order

                int maxOrder = engine.MergeJoinTable<JosVirtuemartOrder, DatabaseTwo.JosVirtuemartOrder>(
                    i => i.VirtuemartOrderId,
                    "VirtuemartOrderId", new []{ new Pair{Name = "VirtuemartUserId", Plus = maxUser}, 
                        new Pair(){Name = "VirtuemartPaymentmethodId", Plus = maxPaymentMethod} });
                
                engine.MergeJoinTable<JosVirtuemartOrderUserinfo, DatabaseTwo.JosVirtuemartOrderUserinfo>(i=>i.VirtuemartOrderUserinfoId,
                    "VirtuemartOrderUserinfoId", new []{new Pair{Name = "VirtuemartOrderId", Plus = maxOrder}, new Pair(){Name = "VirtuemartUserId", Plus = maxUser}  });

                engine.MergeJoinTable<JosVirtuemartOrderItem, DatabaseTwo.JosVirtuemartOrderItem>(i=>i.VirtuemartOrderItemId, "VirtuemartOrderItemId",
                    new []{new Pair{Name = "VirtuemartOrderId", Plus = maxOrder}, new Pair{Name = "VirtuemartProductId", Plus = maxProduct} });
                engine.MergeJoinTable<JosVirtuemartOrderHistory, DatabaseTwo.JosVirtuemartOrderHistory>(i=>i.VirtuemartOrderHistoryId, 
                    "VirtuemartOrderHistoryId", new []{new Pair{Name = "VirtuemartOrderId", Plus = maxOrder}});
                engine.MergeJoinTable<JosVirtuemartOrderCalcRule, DatabaseTwo.JosVirtuemartOrderCalcRule>(i=>i.VirtuemartOrderCalcRuleId, 
                    "VirtuemartOrderCalcRuleId", new []{new Pair{Name = "VirtuemartOrderId", Plus = maxOrder}});
                
                int maxInvoice = engine.MergeJoinTable<JosVirtuemartInvoice, DatabaseTwo.JosVirtuemartInvoice>(i=>i.VirtuemartInvoiceId, 
                    "VirtuemartInvoiceId", new []{new Pair{Name = "VirtuemartOrderId", Plus = maxOrder}});
                
               engine.MergeJoinTable<JosVirtuemartPaymentPlgAlatakMonetico
                   , DatabaseTwo.JosVirtuemartPaymentPlgAlatakMonetico>(i=>i.Id, 
                    "Id", new []{new Pair{Name = "VirtuemartOrderId", Plus = maxOrder}});
               
               engine.MergeJoinTable<JosVirtuemartPaymentPlgAlatakSip
                   , DatabaseTwo.JosVirtuemartPaymentPlgAlatakSip>(i=>i.Id, 
                   "Id", new []{new Pair{Name = "VirtuemartOrderId", Plus = maxOrder}});
               engine.MergeJoinTable<JosVirtuemartPaymentPlgPaypal
                   , DatabaseTwo.JosVirtuemartPaymentPlgPaypal>(i=>i.Id, 
                   "Id", new []{new Pair{Name = "VirtuemartOrderId", Plus = maxOrder}});
               
               engine.MergeJoinTable<JosVirtuemartPaymentPlgStandard
                   , DatabaseTwo.JosVirtuemartPaymentPlgStandard>(i=>i.Id, 
                   "Id", new []{new Pair{Name = "VirtuemartOrderId", Plus = maxOrder}});
                #endregion
            }
        }
        
        
    }
}