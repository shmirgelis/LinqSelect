using System;
using System.Collections.Generic;
using System.Text;

namespace LinqSelect
{
    public static class Selector
    {
        public static IEnumerable<int> AddsOne(this IEnumerable<int> source)
        {
            List<int> converted = new List<int>();
            foreach (var item in source)
            {
                converted.Add(item + 1);
            }

            return converted;
        }
    }
}
