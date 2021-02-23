using System.Runtime.CompilerServices;
using UnityEngine;

namespace R2357.Extensions {

    /// <summary>
    /// Extension methods (Number).
    /// </summary>
    public static class NumberExtension {

        /// <summary>
        /// [ExtensionMethod] Returns the value of ex power.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Pow(this float f, float ex) {
            return Mathf.Pow(f, ex);
        }

        /// <summary>
        /// [ExtensionMethod] Returns the value of square root.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sqrt(this float f) {
            return Mathf.Sqrt(f);
        }

        /// <summary>
        /// [ExtensionMethod] Returns the value rounded to the nearest integer.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Round(this float f) {
            return Mathf.Round(f);
        }

        /// <summary>
        /// [ExtensionMethod] Returns the smallest integer greater than or equal to this value.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Ceil(this float f) {
            return Mathf.Ceil(f);
        }

        /// <summary>
        /// [ExtensionMethod] Returns the smallest integer that is less than or equal to this value.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Floor(this float f) {
            return Mathf.Floor(f);
        }

    }
}