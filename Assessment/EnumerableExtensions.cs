using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            return Enumerable.Empty<T>();
        }
    }
}
