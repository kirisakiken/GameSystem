using System;
using System.Collections.Generic;
using System.Linq;

namespace KirisakiTechnologies.GameSystem.Scripts.Extensions
{
    public static class DictionaryExtensions
    {
        public static void UpdateAll<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue value)
        {
            var keys = dictionary.Keys.ToList();
            foreach (var key in keys)
                dictionary[key] = value;
        }

        public static void UpdateAll<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, Func<TValue, TValue> updatePredicate)
        {
            var keys = dictionary.Keys.ToList();
            foreach (var key in keys)
                dictionary[key] = updatePredicate(dictionary[key]);
        }

        public static void UpdateAll<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, Func<TKey, TValue, bool> matchPredicate, Func<TValue, TValue> updatePredicate)
        {
            var keys = dictionary.Keys.Where(k => matchPredicate(k, dictionary[k])).ToList();
            foreach (var key in keys)
                dictionary[key] = updatePredicate(dictionary[key]);
        }
    }
}