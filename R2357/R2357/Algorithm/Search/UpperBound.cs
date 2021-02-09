using System;
using System.Collections.Generic;

namespace R2357.Algorithm {

    /// <summary>
    /// Perform a search
    /// </summary>
    public static partial class Search {

        /// <summary>
        /// Returns the first index in which a value greater than to the specified element appears.
        /// </summary>
        public static int UpperBound<T>(this List<T> list, T key) where T : IComparable {
            int l = 0;
            int r = list.Count-1;
            while(l - r < 1) {
                int center = ((r - l) >> 1) + l;
                if(list[center].CompareTo(key) <= 0) {
                    l = center + 1;
                }
                else {
                    r = center - 1;
                }
            }
            return l;
        }

        /// <summary>
        /// Returns the first index in which a value greater than to the specified element appears.
        /// </summary>
        public static int UpperBound<T>(this List<T> list, T key, Comparer<T> comparer) {
            int l = 0;
            int r = list.Count - 1;
            while(l - r < 1) {
                int center = ((r - l) >> 1) + l;
                if(comparer.Compare(list[center], key) <= 0) {
                    l = center + 1;
                }
                else {
                    r = center - 1;
                }
            }
            return l;
        }
    }
}