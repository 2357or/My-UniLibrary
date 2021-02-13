using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;

namespace R2357.Extensions {

    /// <summary>
    /// Extension methods (List).
    /// </summary>
    public static class ListExtension {

        /// <summary>
        /// [ExtensionMethod] Returns the last element of the list.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Back<T>(this List<T> list) {
            if(list == null) throw new ArgumentNullException();
            return list[list.Count-1];
        }

        /// <summary>
        /// [ExtensionMethod] Returns the first element of the list.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Front<T>(this List<T> list) {
            if(list == null) throw new ArgumentNullException();
            return list[0];
        }

        /// <summary>
        /// [ExtensionMethod] Returns the sorted list.
        /// </summary>
        public static List<T> Sorted<T>(this List<T> list) {
            if(list == null) throw new ArgumentNullException();
            list.Sort();
            return list;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the sorted list.
        /// </summary>
        public static List<T> Sorted<T>(this List<T> list, IComparer<T> comparer) {
            if(list == null) throw new ArgumentNullException();
            list.Sort(comparer);
            return list;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the sorted list.
        /// </summary>
        public static List<T> Sorted<T>(this List<T> list, Comparison<T> comparison) {
            if(list == null) throw new ArgumentNullException();
            list.Sort(comparison);
            return list;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the sorted list.
        /// </summary>
        public static List<T> Sorted<T>(this List<T> list, int index, int count, IComparer<T> comparer) {
            if(list == null) throw new ArgumentNullException();
            list.Sort(index, count, comparer);
            return list;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the reversed list.
        /// </summary>
        public static List<T> Reversed<T>(this List<T> list) {
            if(list == null) throw new ArgumentNullException();
            list.Reverse();
            return list;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the reversed list.
        /// </summary>
        public static List<T> Reversed<T>(this List<T> list, int index, int count) {
            if(list == null) throw new ArgumentNullException();
            list.Reverse(index, count);
            return list;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the largest element of the list.
        /// </summary>
        public static T MaxElement<T>(this List<T> list) where T : IComparable<T> {
            if(list == null) throw new ArgumentNullException();
            T ret = list[0];
            foreach(T x in list) if(x.CompareTo(ret) > 0) ret = x;
            return ret;
        }

        /// <summary>
        /// [ExtensionMethod] Returns the smallest element of the list.
        /// </summary>
        public static T MinElement<T>(this List<T> list) where T : IComparable<T> {
            if(list == null) throw new ArgumentNullException();
            T ret = list[0];
            foreach(T x in list) if(x.CompareTo(ret) < 0) ret = x;
            return ret;
        }
        
        //public static int MaxElementIndex<T>(this List<T> list) { }
        //public static int MinElementIndex<T>(this List<T> list) { }
    }
}