using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DatabaseOne.DatabaseOne;
using DatabaseOne.Extensions;
using DatabaseTwo.DatabaseTwo;

namespace Merge.Engine
{
    public class Engine
    {
        private DatabaseOneContext _databaseOneContext;
        private DatabaseTwoContext _databaseTwoContext;
        private IMapper _mapper;
        public Engine(DatabaseOneContext ctx1, DatabaseTwoContext ctx2, IMapper mapper)
        {
            _databaseOneContext = ctx1;
            _databaseTwoContext = ctx2;
            _mapper = mapper;
        }
        
        /// <summary>
        /// always return the plus range
        /// </summary>
        /// <param name="findMax"></param>
        /// <param name="identity"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <returns></returns>
        public int MergeStatic<T, V>(Func<T, int> findMax, string identity) where T : EntityUtilities, new() where V: DatabaseTwo.Extensions.EntityUtilities
        {
            int max = _databaseOneContext.Set<T>().Max(findMax) + 1;
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                i[identity] += max;
                var temp =  _mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
                
            });
            _databaseOneContext.SaveChanges();
            return max;
        }

        public void MergeLanguage<T, V>(Func<T, int> findMax, string identity, int max) where T : EntityUtilities, new() 
            where V: DatabaseTwo.Extensions.EntityUtilities, new()
        {
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                i[identity] += max;
                if (i is DatabaseTwo.DatabaseTwo.ISlug x)
                {
                    x.Slug += max;
                }
                var temp =_mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
        }
        
        public void MergeLanguageSlug<T, V>(Func<T, int> findMax, string identity, int max) where T : EntityUtilities, new() where V: DatabaseTwo.Extensions.EntityUtilities, new()
        {
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                i[identity] += max;
                if (i is DatabaseTwo.DatabaseTwo.ISlug x)
                {
                    x.Slug += max;
                }
                var temp =_mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
        }
        
        public int MergeStatic<T, V>(Func<T, int> findMax, Func<V, bool> predicate,string identity) where T : EntityUtilities, new() where V: DatabaseTwo.Extensions.EntityUtilities
        {
            int max = _databaseOneContext.Set<T>().Max(findMax)+ 1;
            List<V> list =  _databaseTwoContext.Set<V>().Where(predicate).ToList();
            list.ForEach(i =>
            {
                i[identity] += max;
                var temp = _mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
            return max;
        }
        
        public int MergeRelationSelf<T, V>(Func<T, int> findMax, string identity, string parent) where T : EntityUtilities, new() where V: DatabaseTwo.Extensions.EntityUtilities
        {
            int max = _databaseOneContext.Set<T>().Max(findMax) + 1;
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                i[identity] += max;
                if (i[parent] != 0)
                {
                    i[parent] += max;
                }
                var temp =_mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
            return max;
        }

        public void MergeJoinSelfTable<T, V>(Func<T, int> findMax, string identity, string parent,string join, int plus) where T : EntityUtilities, new() where V: DatabaseTwo.Extensions.EntityUtilities
        {
            int max = _databaseOneContext.Set<T>().Max(findMax) + 1; 
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                i[identity] += max;
                i[join] += plus;
                if (i[parent] != 0)
                {
                    i[parent] += plus;
                }
                
                var temp =_mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
        }
        
        
        public int MergeJoinTable<T, V>(Func<T, int> findMax, string identity, Pair[] pairs) where T : EntityUtilities, new() where V: DatabaseTwo.Extensions.EntityUtilities
        {
            int max;
            try
            {
                max = findMax==null ? _databaseOneContext.Set<T>().Count() : _databaseOneContext.Set<T>().Max(findMax)+ 1;
            }
            catch (Exception e)
            {
                max = 1;
            }
            
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                if (identity!=null)
                {
                    i[identity] += max;
                }

                foreach (var t in pairs)
                {
                    i[t.Name] += t.Plus;
                }
                var temp =_mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
            return max;
        }
        
        public int MergeJoinTableCustom<T, V>(Func<T, int> findMax, string identity, Pair[] pairs, Pair last) where T : EntityUtilities, new() where V: DatabaseTwo.Extensions.EntityUtilities
        {
            int max;
            try
            {
                max = findMax==null ? _databaseOneContext.Set<T>().Count() : _databaseOneContext.Set<T>().Max(findMax)+ 1;
            }
            catch (Exception e)
            {
                max = 1;
            }
            
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                if (identity!=null)
                {
                    i[identity] += max;
                }

                foreach (var t in pairs)
                {
                    i[t.Name] += t.Plus;
                }

                if (i is IHiddenParam x)
                {
                    var media = x.GetHidden();
                    x.SetHidden(media, last.Plus);
                }
                var temp =_mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
            return max;
        }
        
        public int MergeJoinTableCustom<T, V>(Func<T, int> findMax, string identity, Pair[] pairs, Pair last, Pair last2) where T : EntityUtilities, new() where V: DatabaseTwo.Extensions.EntityUtilities
        {
            int max;
            try
            {
                max = findMax==null ? _databaseOneContext.Set<T>().Count() : _databaseOneContext.Set<T>().Max(findMax)+ 1;
            }
            catch (Exception e)
            {
                max = 1;
            }
            
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                if (identity!=null)
                {
                    i[identity] += max;
                }

                foreach (var t in pairs)
                {
                    i[t.Name] += t.Plus;
                }

                if (i is IHiddenParam x)
                {
                    var media = x.GetHidden();
                    x.SetHidden(media, last.Plus);
                }

                if (i is DatabaseTwo.DatabaseTwo.JosVirtuemartProductCustomfield ix)
                {
                    var customField = ix.CustomfieldValue;
                    try
                    {
                        var productId = int.Parse(customField);
                        ix.CustomfieldValue = productId + last2.Plus+"";
                    }
                    catch (Exception e)
                    {
                        // skip
                    }
                }
                var temp =_mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
            return max;
        }
        
        public int MergeJoinTableCustom2<T, V>(Func<T, int> findMax, string identity, Pair[] pairs, Pair last) where T : EntityUtilities, new() where V: DatabaseTwo.Extensions.EntityUtilities
        {
            int max;
            try
            {
                max = findMax==null ? _databaseOneContext.Set<T>().Count() : _databaseOneContext.Set<T>().Max(findMax)+ 1;
            }
            catch (Exception e)
            {
                max = 1;
            }
            
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                if (identity!=null)
                {
                    i[identity] += max;
                }

                foreach (var t in pairs)
                {
                    i[t.Name] += t.Plus;
                }

                if (i is IHiddenParam x)
                {
                    var media = x.GetHidden();
                    x.SetHidden(media, last.Plus);
                }
                var temp =_mapper.Map(i, new T());
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
            return max;
        }
        
        public int MergeJoinTableS1<T, V>(Func<T, int> findMax, string identity, Pair[] pairs) where T : DatabaseOne.DatabaseOne.JosVirtuemartUserinfo, new() where V: DatabaseTwo.Extensions.EntityUtilities
        {
            int max;
            try
            {
                max = findMax==null ? _databaseOneContext.Set<T>().Count() : _databaseOneContext.Set<T>().Max(findMax)+ 1;
            }
            catch (Exception e)
            {
                max = 1;
            }
            
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                if (identity!=null)
                {
                    i[identity] += max;
                }

                foreach (var t in pairs)
                {
                    i[t.Name] += t.Plus;
                }
                var temp =_mapper.Map(i, new T()
                {
                    CeAdress1 = "",
                    CeAdress4 = "",
                    CeDoorCode1 = "",
                    CeDoorCode2 = "",
                    CeEntryPhone = "",
                });
                _databaseOneContext.Set<T>().Add(temp);
            });
            _databaseOneContext.SaveChanges();
            return max;
        }
    }

    public class Pair
    {
        public string Name { get; set; }
        public int Plus { get; set; }
    }
}
