using AutoMapper;
using Merge.DatabaseOne;
using Merge.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<DatabaseTwo.JosCategory, DatabaseOne.JosCategory>();
            });
            IMapper iMapper = config.CreateMapper();

            var one = new DatabaseOneContext();
            using (var two = new DatabaseTwo.DatabaseTwoContext())
            {
                var jCategories = two.JosCategories.Where(i=>i.Id>1).ToList();
                int max = one.JosCategories.Max(i => i.Id);
                jCategories.ForEach(i =>
                {
                    i.Id += max;
                    if (i.ParentId != 1) {                   
                        i.ParentId += max;
                    }
                    one.JosCategories.Add(iMapper.Map(i, new JosCategory()));
                });
                one.SaveChanges();
            }
        }
    }
}