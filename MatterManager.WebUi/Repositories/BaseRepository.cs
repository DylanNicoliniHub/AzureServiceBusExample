using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using MatterManager.WebUi.Models;

namespace MatterManager.WebUi.Repositories
{
    public abstract class BaseRepository
    {
        private Cache _cache;

        protected BaseRepository()
        {
            // Here we add some sample data to cache
        }

        private Cache Cache
        {
            get
            {
                if (_cache != null)
                    return _cache;

                _cache = HttpContext.Current.Cache;
                return _cache;
            }
        }

        protected T Get<T>(int id) where T : Matter
        {
            var list = GetList<T>();
            if (list == null)
                return default(T);

            if (list.ContainsKey(id))
                return list[id];

            return default(T);
        }

        protected void Save<T>(T instance) where T : Matter
        {
            var list = GetList<T>();
            var id = instance.Id;

            if (id == 0)
            {
                if (list.Count > 0)
                    id = (from l in list
                          orderby l.Key descending
                          select l.Key).First();
                id++;
                instance.Id = id;
                if (list.ContainsKey(id))
                    list[id] = instance;
                else
                    list.Add(id, instance);
            }
            else
                list[id] = instance;
        }

        protected void Delete<T>(T instance) where T : Matter
        {
            var list = GetList<T>();
            if (list.ContainsKey(instance.Id))
                list.Remove(instance.Id);
        }

        protected IDictionary<int, T> GetList<T>() where T : Matter
        {
            var type = typeof(T).ToString();

            if (Cache[type] != null)
                return (IDictionary<int, T>)Cache[type];

            var list = new Dictionary<int, T>();
            Cache[type] = list;
            return list;
        }
    }
}