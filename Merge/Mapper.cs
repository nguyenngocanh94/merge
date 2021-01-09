using System.Reflection;
using AutoMapper;

namespace Merge
{
    public class Mapper
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.DatabaseTwoContext, DatabaseOne.DatabaseOne.DatabaseOneContext>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosAcymailingUserstat,
                    DatabaseOne.DatabaseOne.JosAcymailingUserstat>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosCategory, DatabaseOne.DatabaseOne.JosCategory>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosContent, DatabaseOne.DatabaseOne.JosContent>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosContentType, DatabaseOne.DatabaseOne.JosContentType>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosExtension, DatabaseOne.DatabaseOne.JosExtension>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosModulesMenu, DatabaseOne.DatabaseOne.JosModulesMenu>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosUser, DatabaseOne.DatabaseOne.JosUser>().ForAllOtherMembers(
                    o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosUsergroup, DatabaseOne.DatabaseOne.JosUsergroup>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosUserKey, DatabaseOne.DatabaseOne.JosUserKey>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosUserUsergroupMap, DatabaseOne.DatabaseOne.JosUserUsergroupMap
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartAdminmenuentry,
                    DatabaseOne.DatabaseOne.JosVirtuemartAdminmenuentry>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCalc, DatabaseOne.DatabaseOne.JosVirtuemartCalc>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCalcCategory,
                    DatabaseOne.DatabaseOne.JosVirtuemartCalcCategory>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCalcCountry,
                    DatabaseOne.DatabaseOne.JosVirtuemartCalcCountry>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCalcManufacturer,
                    DatabaseOne.DatabaseOne.JosVirtuemartCalcManufacturer>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCalcShoppergroup,
                    DatabaseOne.DatabaseOne.JosVirtuemartCalcShoppergroup>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCart, DatabaseOne.DatabaseOne.JosVirtuemartCart>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCategoriesEnGb,
                    DatabaseOne.DatabaseOne.JosVirtuemartCategoriesEnGb>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCategoriesFrFr,
                    DatabaseOne.DatabaseOne.JosVirtuemartCategoriesFrFr>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCategory,
                    DatabaseOne.DatabaseOne.JosVirtuemartCategory>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCategoryCategory,
                    DatabaseOne.DatabaseOne.JosVirtuemartCategoryCategory>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCategoryMedia,
                    DatabaseOne.DatabaseOne.JosVirtuemartCategoryMedia>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartConfig, DatabaseOne.DatabaseOne.JosVirtuemartConfig
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCountry, DatabaseOne.DatabaseOne.JosVirtuemartCountry
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCoupon, DatabaseOne.DatabaseOne.JosVirtuemartCoupon
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCurrency,
                    DatabaseOne.DatabaseOne.JosVirtuemartCurrency>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartCustom, DatabaseOne.DatabaseOne.JosVirtuemartCustom
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartInvoice, DatabaseOne.DatabaseOne.JosVirtuemartInvoice
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturer,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturer>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturercategoriesDeDe,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturercategoriesDeDe>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturercategoriesEnGb,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturercategoriesEnGb>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturercategoriesFrFr,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturercategoriesFrFr>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });

                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturercategoriesItIt,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturercategoriesItIt>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturercategoriesRuRu,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturercategoriesRuRu>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturercategory,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturercategory>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturerMedia,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturerMedia>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersDeDe,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturersDeDe>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersEnGb,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturersEnGb>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersEsE,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturersEsE>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersFrFr,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturersFrFr>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });

                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersItIt,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturersItIt>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartManufacturersRuRu,
                    DatabaseOne.DatabaseOne.JosVirtuemartManufacturersRuRu>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartMedia, DatabaseOne.DatabaseOne.JosVirtuemartMedia>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartMigrationOldtonewId,
                    DatabaseOne.DatabaseOne.JosVirtuemartMigrationOldtonewId>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartModule, DatabaseOne.DatabaseOne.JosVirtuemartModule
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartOrder, DatabaseOne.DatabaseOne.JosVirtuemartOrder>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartOrderCalcRule,
                    DatabaseOne.DatabaseOne.JosVirtuemartOrderCalcRule>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartOrderHistory,
                    DatabaseOne.DatabaseOne.JosVirtuemartOrderHistory>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartOrderItem,
                    DatabaseOne.DatabaseOne.JosVirtuemartOrderItem>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartOrderstate,
                    DatabaseOne.DatabaseOne.JosVirtuemartOrderstate>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartOrderUserinfo,
                    DatabaseOne.DatabaseOne.JosVirtuemartOrderUserinfo>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethod,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethod>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsDeDe,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsDeDe>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsEnGb,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsEnGb>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsEsE,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsEsE>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsFrFr,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsFrFr>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodShoppergroup,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodShoppergroup>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsItIt,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsItIt>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentmethodsRuRu,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentmethodsRuRu>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgAlatakMonetico,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgAlatakMonetico>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgAlatakSip,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgAlatakSip>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgAuthorizenet,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgAuthorizenet>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgHeidelpay,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgHeidelpay>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgPaypal,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgPaypal>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartPaymentPlgStandard,
                    DatabaseOne.DatabaseOne.JosVirtuemartPaymentPlgStandard>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProduct, DatabaseOne.DatabaseOne.JosVirtuemartProduct
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductCategory,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductCategory>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductCustomfield,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductCustomfield>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductCustomPlgIstraxxDownload,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductCustomPlgIstraxxDownload>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductCustomPlgParamRef,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductCustomPlgParamRef>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductCustomPlgParamValue,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductCustomPlgParamValue>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductCustomPlgVm2tag,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductCustomPlgVm2tag>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductManufacturer,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductManufacturer>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductMedia,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductMedia>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductPrice,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductPrice>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductRelation,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductRelation>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductsEnGb,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductsEnGb>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductsFrFr,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductsFrFr>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartProductShoppergroup,
                    DatabaseOne.DatabaseOne.JosVirtuemartProductShoppergroup>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartRating, DatabaseOne.DatabaseOne.JosVirtuemartRating
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartRatingReview,
                    DatabaseOne.DatabaseOne.JosVirtuemartRatingReview>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartShipmentmethod,
                    DatabaseOne.DatabaseOne.JosVirtuemartShipmentmethod>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartShipmentmethodsFrFr,
                    DatabaseOne.DatabaseOne.JosVirtuemartShipmentmethodsFrFr>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartShipmentmethodShoppergroup,
                    DatabaseOne.DatabaseOne.JosVirtuemartShipmentmethodShoppergroup>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartShipmentPlgWeightCountry,
                    DatabaseOne.DatabaseOne.JosVirtuemartShipmentPlgWeightCountry>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartShoppergroup,
                    DatabaseOne.DatabaseOne.JosVirtuemartShoppergroup>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartState, DatabaseOne.DatabaseOne.JosVirtuemartState>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartUserfield,
                    DatabaseOne.DatabaseOne.JosVirtuemartUserfield>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartUserfieldValue,
                    DatabaseOne.DatabaseOne.JosVirtuemartUserfieldValue>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartUserinfo,
                    DatabaseOne.DatabaseOne.JosVirtuemartUserinfo>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVendor, DatabaseOne.DatabaseOne.JosVirtuemartVendor
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVendorMedia,
                    DatabaseOne.DatabaseOne.JosVirtuemartVendorMedia>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVendorsDeDe,
                    DatabaseOne.DatabaseOne.JosVirtuemartVendorsDeDe>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVendorsEnGb,
                    DatabaseOne.DatabaseOne.JosVirtuemartVendorsEnGb>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVendorsFrFr,
                    DatabaseOne.DatabaseOne.JosVirtuemartVendorsFrFr>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVendorsFrFrbak,
                    DatabaseOne.DatabaseOne.JosVirtuemartVendorsFrFrbak>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVendorsItIt,
                    DatabaseOne.DatabaseOne.JosVirtuemartVendorsItIt>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVendorsRuRu,
                    DatabaseOne.DatabaseOne.JosVirtuemartVendorsRuRu>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVendorUser,
                    DatabaseOne.DatabaseOne.JosVirtuemartVendorUser>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVmuser, DatabaseOne.DatabaseOne.JosVirtuemartVmuser
                >().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartVmuserShoppergroup,
                    DatabaseOne.DatabaseOne.JosVirtuemartVmuserShoppergroup>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartWaitinguser,
                    DatabaseOne.DatabaseOne.JosVirtuemartWaitinguser>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosVirtuemartWorldzone,
                    DatabaseOne.DatabaseOne.JosVirtuemartWorldzone>().ForAllOtherMembers(o =>
                {
                    if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                    {
                        o.NullSubstitute("");
                    }
                });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosWeblink, DatabaseOne.DatabaseOne.JosWeblink>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosWfProfile, DatabaseOne.DatabaseOne.JosWfProfile>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosWishlist, DatabaseOne.DatabaseOne.JosWishlist>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
                cfg.CreateMap<DatabaseTwo.DatabaseTwo.JosContent, DatabaseOne.DatabaseOne.JosContent>()
                    .ForAllOtherMembers(o =>
                    {
                        if (((PropertyInfo) o.DestinationMember).PropertyType == typeof(string))
                        {
                            o.NullSubstitute("");
                        }
                    });
            });

            return config.CreateMapper();
        }
    }
}