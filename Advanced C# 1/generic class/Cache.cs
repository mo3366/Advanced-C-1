using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C__1.generic_class
{
    public class Cache<TKey, TValue> where TKey : notnull
    {
        private class CacheItem
        {
            public TValue Value { get; set; }
            public DateTime ExpirationTime { get; set; }
        }

        private Dictionary<TKey, CacheItem> _store = new Dictionary<TKey, CacheItem>();

        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            _store[key] = new CacheItem
            {
                Value = value,
                ExpirationTime = DateTime.Now.Add(duration)
            };
        }

        public TValue Get(TKey key)
        {
            if (Contains(key))
            {
                return _store[key].Value;
            }
            return default(TValue);
        }

        public void Remove(TKey key)
        {
            _store.Remove(key);
        }

        public bool Contains(TKey key)
        {
            if (_store.TryGetValue(key, out var item))
            {
                if (item.ExpirationTime > DateTime.Now)
                {
                    return true;
                }
                _store.Remove(key); 
            }
            return false;
        }
    }
}
