using System;
using System.Collections.Generic;
using System.Text;

namespace LinqSelect
{
    public delegate int TransformsNumsFunction(int num);
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

        public static IEnumerable<int> Transform(this IEnumerable<int> source, TransformsNumsFunction numOperation)
        {
            
            List<int> converted = new List<int>();
            foreach (var item in source)
            {
                converted.Add(numOperation(item));
            }

            return converted;
        }
    }
}
