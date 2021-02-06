using System.Collections.Generic;
using System;

namespace R2357.Extensions {

    /// <summary>
    /// Extension methods (List).
    /// </summary>
    public static class ListExtension {

        /// <summary>
        /// [ExtensionMethod] Returns the last element of the list.
        /// </summary>
        public static T Back<T>(this List<T> list) {
            return list[list.Count-1];
        }

        /// <summary>
        /// [ExtensionMethod] Returns the first element of the list.
        /// </summary>
        public static T Front<T>(this List<T> list) {
            return list[0];
        }

        /// <summary>
        /// [ExtensionMethod] Returns the sorted list.
        /// </summary>
        public static List<T> Sorted<T>(this List<T> list) {
            list.Sort();
            return list;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the reversed list.
        /// </summary>
        public static List<T> Reversed<T>(this List<T> list) {
            list.Reverse();
            return list;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the largest element of the list.
        /// </summary>
        public static T MaxElement<T>(this List<T> list) where T : IComparable {
            IComparable ret = list[0];
            foreach(IComparable x in list) if(x.CompareTo(ret) > 0) ret = x;
            return (T)ret;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the smallest element of the list.
        /// </summary>
        public static T MinElement<T>(this List<T> list) where T : IComparable {
            IComparable ret = list[0];
            foreach(IComparable x in list) if(x.CompareTo(ret) < 0) ret = x;
            return (T)ret;
        }
        
        //public static int MaxElementIndex<T>(this List<T> list) { }
        //public static int MinElementIndex<T>(this List<T> list) { }
    }
}