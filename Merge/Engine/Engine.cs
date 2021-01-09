using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Merge.Extensions;

namespace Merge.Engine
{
    public class Engine
    {
        private DatabaseOne.DatabaseOneContext _databaseOneContext;
        private DatabaseTwo.DatabaseTwoContext _databaseTwoContext;
        private IMapper _mapper;
        public Engine(DatabaseOne.DatabaseOneContext ctx1, DatabaseTwo.DatabaseTwoContext ctx2, IMapper mapper)
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
        public int MergeStatic<T, V>(Func<T, int> findMax, string identity) where T : EntityUtilities where V: EntityUtilities, new()
        {
            int max = _databaseOneContext.Set<T>().Max(findMax);
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                i[identity] += max;
                _mapper.Map(i, new V());
            });
            return max;
        }

        public void MergeLanguage<T, V>(Func<T, int> findMax, string identity, int max) where T : EntityUtilities where V: EntityUtilities, new()
        {
            List<V> list =  _databaseTwoContext.Set<V>().ToList();
            list.ForEach(i =>
            {
                i[identity] += max;
                _mapper.Map(i, new V());
            });
        }
        
        public int MergeStatic<T, V>(Func<T, int> findMax, Func<V, bool> predicate,string identity) where T : EntityUtilities, new() where V: EntityUtilities
        {
            int max = _databaseOneContext.Set<T>().Max(findMax);
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
        
        public int MergeRelationSelf<T, V>(Func<T, int> findMax, string identity, string parent) where T : EntityUtilities, new() where V: EntityUtilities
        {
            int max = _databaseOneContext.Set<T>().Max(findMax);
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

        public void MergeJoinSelfTable<T, V>(Func<T, int> findMax, string identity, string parent,string join, int plus) where T : EntityUtilities, new() where V: EntityUtilities
        {
            int max = _databaseOneContext.Set<T>().Max(findMax); 
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
        
        
        public int MergeJoinTable<T, V>(Func<T, int> findMax, string identity, Pair[] pairs) where T : EntityUtilities, new() where V: EntityUtilities
        {
            var max = findMax==null ? _databaseOneContext.Set<T>().Count() : _databaseOneContext.Set<T>().Max(findMax);
            
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
    }

    public class Pair
    {
        public string Name { get; set; }
        public int Plus { get; set; }
    }
}