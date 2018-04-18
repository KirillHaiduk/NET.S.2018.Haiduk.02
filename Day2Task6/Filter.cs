using System;
using System.Collections.Generic;

namespace Day2Task6
{    
    /// <summary>
    /// The filtering class
    /// </summary>
    public static class Filter
    {        
        /// <summary>
        /// Filters a sequence of values based on a predicate
        /// </summary>
        /// <typeparam name="TSource">The type of the elements of sequence</typeparam>
        /// <param name="source">Sequence to filter</param>
        /// <param name="filter">A function to test each element for a condition</param>
        /// <returns>Sequence that contains elements from the input sequence that satisfy the condition</returns>
        public static IEnumerable<TSource> FindAll<TSource> (this IEnumerable<TSource> source, Func<TSource, bool> filter)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            foreach (var t in source)
            {
                if (filter(t))
                {
                    yield return t;
                }
            }
        }        
    }
}
